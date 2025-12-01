using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum Gender
{
    male,
    female,
    unknown,
    other
}
public class PatientModel
{
    [Key]
    public string PatientID { get; set; } = "";
    [Required]
    public DateTime DateOfBirth { get; set; } = DateTime.Now;
    public Gender Gender { get; set; } = Gender.other;
    [Required]
    public string InsuranceNumber { get; set; } = "";
    public string BloodType { get; set; } = "";
    [ForeignKey(nameof(UserModel))]
    public string UserID { get; set; } = "";
    public virtual UserModel User { get; set; } = null!;
}
