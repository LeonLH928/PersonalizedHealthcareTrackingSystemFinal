using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("Prescriptions")]
public class PrescriptionModel : BaseModel
{
    [PrimaryKey]
    [Column("PrescriptionID")]
    public string PrescriptionID { get; set; } = "";

    [Column("PrescriptionDateTime")]
    public DateTime PrescriptionDateTime { get; set; } = DateTime.UtcNow;

    [Column("Status")]
    public PrescriptionStatus Status { get; set; } = PrescriptionStatus.Pending;

    [Column("VerifiedAt")]
    public DateTime VerifiedAt { get; set; } = DateTime.UtcNow;

    [Column("DispensedAt")]
    public DateTime DispensedAt { get; set; } = DateTime.UtcNow;

    [Column("Priority")]
    public Priority Priority { get; set; } = Priority.Routine;

    [Column("RecordID")]
    public string RecordID { get; set; } = "";

    [Column("PharmacistID")]
    public string PharmacistID { get; set; } = "";

    [Reference(typeof(MedicationModel))]
    public MedicalRecordModel MedicalRecord { get; set; } = null!;

    [Reference(typeof(PharmacistModel))]
    public PharmacistModel Pharmacist { get; set; } = null!;
}