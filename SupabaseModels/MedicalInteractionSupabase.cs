using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("MedicationInteractions")]
public class MedicationInteractionModel : BaseModel
{
    [PrimaryKey]
    [Column("InteractionId")]
    public string InteractionId { get; set; } = "";

    [Column("Severity")]
    public Severity Severity { get; set; }

    [Column("Description")]
    public string Description { get; set; } = "";

    [Column("ClinicalEffects")]
    public string ClinicalEffects { get; set; } = "";

    [Column("Management")]
    public string Management { get; set; } = "";

    [Column("MedicationID1")]
    public string MedicationID1 { get; set; } = "";

    [Column("MedicationID2")]
    public string MedicationID2 { get; set; } = "";
}