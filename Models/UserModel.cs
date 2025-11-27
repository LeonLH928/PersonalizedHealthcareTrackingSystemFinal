using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.RightsManagement;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum UserRole
{
    Patient,
    Doctor,
    Pharmacist
}
[Index(nameof(Username), IsUnique = true)]
public class UserModel
{
    [Key]
    public int UserID { get; set; }
    [MaxLength(50, ErrorMessage = "Maximum length is 50")]
    public string FirstName { get; set; } = "";
    [MaxLength(50, ErrorMessage = "Maximum length is 50")]
    public string LastName { get; set; } = "";
    public string Username { get; set; } = "";
    [Required]
    [MaxLength(100, ErrorMessage = "Maximum length is 100")]
    [RegularExpression("^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{8,}$", ErrorMessage = "The password must be at least 8 characters long and include at least one letter, one number, and one special character")]
    [PasswordPropertyText(true)]
    public string PasswordHash { get; set; } = "";
    [Required]
    public UserRole Role { get; set; } = UserRole.Patient;
    [EmailAddress(ErrorMessage = "The Email is invalid")]
    public string Email { get; set; } = "";
    [Phone]
    public string PhoneNumber { get; set; } = "";
    public bool IsActive { get; set; } = false;
}
