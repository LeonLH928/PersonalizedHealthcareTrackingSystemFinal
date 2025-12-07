using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("Patients")]
public class PatientModel : BaseModel
{
    [PrimaryKey]
    [Column("PatientID")]
    public string PatientID { get; set; } = "";

    [Column("DateOfBirth")]
    public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;

    [Column("Gender")]
    public Gender Gender { get; set; }

    [Column("InsuranceNumber")]
    public string InsuranceNumber { get; set; } = "";

    [Column("BloodType")]
    public string BloodType { get; set; } = "";

    [Column("UserID")]
    public string UserID { get; set; } = "";

    public UserModel User { get; set; } = null!;
}