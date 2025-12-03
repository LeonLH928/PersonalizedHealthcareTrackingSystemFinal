using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum Gender
{
    Male,
    Female,
    Unknown,
    Other
}
public class PatientModel
{
    [Key]
    public string PatientID { get; set; } = "";
    [Required]
    public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
    [Required]
    public Gender Gender { get; set; }
    [Required]
    public string InsuranceNumber { get; set; } = "";
    public string BloodType { get; set; } = "";
    [ForeignKey(nameof(UserModel))]
    public string UserID { get; set; } = "";
    public virtual UserModel User { get; set; } = null!;
    public virtual List<AppointmentModel> Appointments { get; set; } = [];
}
