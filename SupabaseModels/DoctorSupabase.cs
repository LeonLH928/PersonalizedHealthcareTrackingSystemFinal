using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("Doctors")]
public class DoctorModel : BaseModel
{
    [PrimaryKey]
    [Column("DoctorID")]
    public string DoctorID { get; set; } = "";

    [Column("Specialization")]
    public string Specialization { get; set; } = "";

    [Column("ConsultationFee")]
    public double ConsultationFee { get; set; }

    [Column("Rating")]
    public double Rating { get; set; }

    [Column("YearsOfExperience")]
    public int YearsOfExperience { get; set; }

    [Column("UserID")]
    public string UserID { get; set; } = "";

    [Reference(typeof(UserModel))]
    public UserModel User { get; set; } = null!;
}