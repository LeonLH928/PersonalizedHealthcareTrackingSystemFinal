using PersonalizedHealthcareTrackingSystemFinal.Models;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("Users")]
public class UserModel : BaseModel
{
    [PrimaryKey]
    [Column("UserID")]
    public string UserID { get; set; } = "";

    [Column("FirstName")]
    public string FirstName { get; set; } = "";

    [Column("LastName")]
    public string LastName { get; set; } = "";

    [Column("Username")]
    public string Username { get; set; } = "";

    [Column("PasswordHash")]
    public string PasswordHash { get; set; } = "";

    [Column("Role")]
    public UserRole Role { get; set; } = UserRole.Patient;

    [Column("Email")]
    public string Email { get; set; } = "";

    [Column("PhoneNumber")]
    public string PhoneNumber { get; set; } = "";

    [Column("IsActive")]
    public bool IsActive { get; set; } = false;

}