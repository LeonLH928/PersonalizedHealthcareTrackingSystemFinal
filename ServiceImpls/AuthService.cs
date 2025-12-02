using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Models;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly ICurrentUserStoreRepository _currentUserStore;
    private readonly IRoleRepository<SupabaseModels.PatientModel> _patientRepo;
    private readonly IRoleRepository<SupabaseModels.DoctorModel> _doctorRepo;
    private readonly IRoleRepository<SupabaseModels.PharmacistModel> _pharmacistRepo;
    private readonly Client _client;
    public AuthService(IUserRepository userRepository, 
                       ICurrentUserStoreRepository currentUserStore,
                       IRoleRepository<SupabaseModels.PatientModel> patientRepo,
                       IRoleRepository<SupabaseModels.DoctorModel> doctorRepo,
                       IRoleRepository<SupabaseModels.PharmacistModel> pharmacistRepo,
                       Client client)
    {
        _userRepository = userRepository;
        _currentUserStore = currentUserStore;
        _doctorRepo = doctorRepo;
        _patientRepo = patientRepo;
        _pharmacistRepo = pharmacistRepo;
        _client = client;
    }
    public async Task<SupabaseModels.UserModel> SignInAsync(string usernameOrEmail, string password)
    {
        var response = await _client
                    .From<SupabaseModels.UserModel>()
                    .Where(x => x.Username == usernameOrEmail || x.Email == usernameOrEmail)
                    .Get();

        var user = response?.Models?.FirstOrDefault();

        if (user == null) 
            throw new Exception("User not found");

        if (user.PasswordHash != password) 
            throw new Exception("Invalid password");

        if (!user.IsActive) 
            throw new Exception("Account is deactivated");

        _currentUserStore.SetUser(user);

        return user;
    }
    public void SignOut()
    {
        _currentUserStore.ClearUser();
    }
    public async Task<SupabaseModels.UserModel> SignUpAsync(string email, string password, UserRole role, string firstName, string lastName, string username, string phoneNumber)
    {
        if (await _userRepository.UsernameExistsAsync(username)) throw new Exception("Username exists");
        if (await _userRepository.EmailExistsAsync(email)) throw new Exception("Email exists");

        var newUser = new SupabaseModels.UserModel
        {
            UserID = Guid.NewGuid().ToString(),
            FirstName = firstName,
            LastName = lastName,
            Username = username,
            Email = email,
            PhoneNumber = phoneNumber,
            PasswordHash = password,
            Role = role,
            IsActive = true
        };
        var insertedUser = await _userRepository.AddUserAsync(newUser);

        await CreateRoleSpecificRecord(insertedUser.UserID, role);
        return insertedUser;
    }
    private async Task CreateRoleSpecificRecord(string userId, UserRole role)
    {
        switch (role)
        {
            case UserRole.Patient:
                await _patientRepo.AddRoleAsync(new SupabaseModels.PatientModel { PatientID = Guid.NewGuid().ToString(), UserID = userId });
                break;
            case UserRole.Doctor:
                await _doctorRepo.AddRoleAsync(new SupabaseModels.DoctorModel { DoctorID = Guid.NewGuid().ToString(), UserID = userId });
                break;
            case UserRole.Pharmacist:
                await _pharmacistRepo.AddRoleAsync(new SupabaseModels.PharmacistModel { PharmacistID = Guid.NewGuid().ToString(), UserID = userId });
                break;
        }
    }
}
