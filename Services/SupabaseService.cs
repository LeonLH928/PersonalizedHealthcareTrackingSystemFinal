using Supabase;
using System;
using System.Linq;
using System.Threading.Tasks;
using PersonalizedHealthcareTrackingSystemFinal.Models;
using System.Security.Cryptography;
using System.Text;

namespace PersonalizedHealthcareTrackingSystemFinal.Services
{
    public class SupabaseService
    {
        private static SupabaseService? _instance;
        private readonly Supabase.Client _client;
        private const string SUPABASE_URL = "https://acrsnysomjcvidbbadac.supabase.co"; 
        private const string SUPABASE_KEY = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImFjcnNueXNvbWpjdmlkYmJhZGFjIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjQxNzU1MDAsImV4cCI6MjA3OTc1MTUwMH0.8NL3tECh1ZMQBI_H7gFz0ecFqPFMrznTGk95oGO1Dg8"; 

        // Store current logged in user
        public UserTable? CurrentUser { get; private set; }

        private SupabaseService()
        {
            var options = new SupabaseOptions
            {
                AutoRefreshToken = false,
                AutoConnectRealtime = false
            };

            _client = new Supabase.Client(SUPABASE_URL, SUPABASE_KEY, options);
        }

        public static SupabaseService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SupabaseService();
                }
                return _instance;
            }
        }

        public async Task InitializeAsync()
        {
            await _client.InitializeAsync();
        }

        public Supabase.Client GetClient()
        {
            return _client;
        }

        // Simple password hashing
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        // Sign Up - Simple version
        public async Task<UserTable?> SignUpAsync(string email, string password, UserRole role, string firstName, string lastName, string username, string phoneNumber)
        {
            try
            {
                // Check if username exists
                var existingUser = await _client
                    .From<UserTable>()
                    .Where(x => x.Username == username)
                    .Get();

                if (existingUser?.Models?.Count > 0)
                {
                    throw new Exception("Username already exists");
                }

                // Check if email exists
                var existingEmail = await _client
                    .From<UserTable>()
                    .Where(x => x.Email == email)
                    .Get();

                if (existingEmail?.Models?.Count > 0)
                {
                    throw new Exception("Email already exists");
                }

                // Create user
                var newUser = new UserTable
                {
                    UserId = Guid.NewGuid().ToString(),
                    FirstName = firstName,
                    LastName = lastName,
                    Username = username,
                    Email = email,
                    Phone = phoneNumber,
                    PasswordHash = HashPassword(password),
                    Role = role.ToString().ToLower(),
                    IsActive = true
                };

                var result = await _client.From<UserTable>().Insert(newUser);
                var insertedUser = result.Models.FirstOrDefault();

                if (insertedUser != null)
                {
                    // Create role-specific record
                    await CreateRoleSpecificRecord(insertedUser.UserId, role);
                    return insertedUser;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception($"Sign up failed: {ex.Message}", ex);
            }
        }

        // Sign In - Simple version
        public async Task<UserTable?> SignInAsync(string usernameOrEmail, string password)
        {
            try
            {
                var hashedPassword = HashPassword(password);

                // Try to find user by username or email
                var response = await _client
                    .From<UserTable>()
                    .Where(x => x.Username == usernameOrEmail || x.Email == usernameOrEmail)
                    .Get();

                var user = response?.Models?.FirstOrDefault();

                if (user == null)
                {
                    throw new Exception("User not found");
                }

                // Verify password
                if (user.PasswordHash != hashedPassword)
                {
                    throw new Exception("Invalid password");
                }

                if (!user.IsActive)
                {
                    throw new Exception("Account is deactivated");
                }

                // Set current user
                CurrentUser = user;
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Sign in failed: {ex.Message}", ex);
            }
        }

        // Sign Out
        public void SignOut()
        {
            CurrentUser = null;
        }

        // Get user by ID
        public async Task<UserTable?> GetUserByIdAsync(string userId)
        {
            try
            {
                var result = await _client
                    .From<UserTable>()
                    .Where(x => x.UserId == userId)
                    .Single();

                return result;
            }
            catch
            {
                return null;
            }
        }

        // Get user by username
        public async Task<UserTable?> GetUserByUsernameAsync(string username)
        {
            try
            {
                var result = await _client
                    .From<UserTable>()
                    .Where(x => x.Username == username)
                    .Single();

                return result;
            }
            catch
            {
                return null;
            }
        }

        // Check if username exists
        public async Task<bool> IsUsernameExistsAsync(string username)
        {
            try
            {
                var result = await _client
                    .From<UserTable>()
                    .Where(x => x.Username == username)
                    .Get();

                return result?.Models?.Count > 0;
            }
            catch
            {
                return false;
            }
        }

        // Create role-specific record
        private async Task CreateRoleSpecificRecord(string userId, UserRole role)
        {
            try
            {
                switch (role)
                {
                    case UserRole.Patient:
                        var patient = new PatientTable
                        {
                            PatientId = Guid.NewGuid().ToString(),
                            UserId = userId
                        };
                        await _client.From<PatientTable>().Insert(patient);
                        break;

                    case UserRole.Doctor:
                        var doctor = new DoctorTable
                        {
                            DoctorId = Guid.NewGuid().ToString(),
                            UserId = userId
                        };
                        await _client.From<DoctorTable>().Insert(doctor);
                        break;

                    case UserRole.Pharmacist:
                        var pharmacist = new PharmacistTable
                        {
                            PharmacistId = Guid.NewGuid().ToString(),
                            UserId = userId
                        };
                        await _client.From<PharmacistTable>().Insert(pharmacist);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create role-specific record: {ex.Message}", ex);
            }
        }
    }

    // Supabase Table Models
    [Supabase.Postgrest.Attributes.Table("users")]
    public class UserTable : Supabase.Postgrest.Models.BaseModel
    {
        [Supabase.Postgrest.Attributes.PrimaryKey("user_id")]
        public string UserId { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("first_name")]
        public string FirstName { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("last_name")]
        public string LastName { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("username")]
        public string Username { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("password_hash")]
        public string PasswordHash { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("email")]
        public string Email { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("phone")]
        public string Phone { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("role")]
        public string Role { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("is_active")]
        public bool IsActive { get; set; }
    }

    [Supabase.Postgrest.Attributes.Table("patients")]
    public class PatientTable : Supabase.Postgrest.Models.BaseModel
    {
        [Supabase.Postgrest.Attributes.PrimaryKey("patient_id")]
        public string PatientId { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("user_id")]
        public string UserId { get; set; } = "";
    }

    [Supabase.Postgrest.Attributes.Table("doctors")]
    public class DoctorTable : Supabase.Postgrest.Models.BaseModel
    {
        [Supabase.Postgrest.Attributes.PrimaryKey("doctor_id")]
        public string DoctorId { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("user_id")]
        public string UserId { get; set; } = "";
    }

    [Supabase.Postgrest.Attributes.Table("pharmacists")]
    public class PharmacistTable : Supabase.Postgrest.Models.BaseModel
    {
        [Supabase.Postgrest.Attributes.PrimaryKey("pharmacist_id")]
        public string PharmacistId { get; set; } = "";

        [Supabase.Postgrest.Attributes.Column("user_id")]
        public string UserId { get; set; } = "";
    }
}