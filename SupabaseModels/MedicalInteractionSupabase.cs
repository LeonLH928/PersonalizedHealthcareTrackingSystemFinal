using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("MedicationInteractions")]
public class MedicationInteractionModel : BaseModel
{
    [PrimaryKey]
    [Column("InteractionID")]
    public string InteractionID { get; set; } = "";

    [Column("Severity")]
    public Severity Severity { get; set; }

    [Column("Description")]
    public string Description { get; set; } = "";

    [Column("ClinicalEffects")]
    public string ClinicalEffects { get; set; } = "";

    [Column("Management")]
    public string Management { get; set; } = "";

    [Column("Medication1ID")]
    public string Medication1ID { get; set; } = "";

    [Column("Medication2ID")]
    public string Medication2ID { get; set; } = "";

    public MedicationModel Med1 { get; set; } = null!;

    public MedicationModel Med2 { get; set; } = null!;
}