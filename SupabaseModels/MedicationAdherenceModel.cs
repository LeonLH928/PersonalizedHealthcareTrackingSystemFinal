using PersonalizedHealthcareTrackingSystemFinal.Models;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("MedicationAdherences")]
public class MedicationAdherenceModel : BaseModel
{
    [PrimaryKey]
    [Column("AdherenceID")]
    public string AdherenceID { get; set; } = "";

    [Column("ScheduledDateTime")]
    public DateTime ScheduledDateTime { get; set; }

    [Column("TakenDateTime")]
    public DateTime? TakenDateTime { get; set; }

    [Column("Status")]
    public AdherenceStatus Status { get; set; } = AdherenceStatus.Pending;

    [Column("Notes")]
    public string? Notes { get; set; }

    [Reference(typeof(PrescriptionItemModel))]
    public PrescriptionItemModel PrescriptionItem { get; set; } = null!;

    [Column("PrescriptionItemID")]
    public string PrescriptionItemID { get; set; } = null!;
}
