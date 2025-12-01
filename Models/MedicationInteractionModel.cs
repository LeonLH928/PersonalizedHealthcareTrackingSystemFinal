using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum Severity
{
    mild,
    moderate,
    severe,
    contraindicated
}
public class MedicationInteractionModel
{
    [Key]
    public int InteractionId { get; set; }
    [Required]
    public Severity Severity { get; set; }
    public string Description { get; set; } = "";
    public string ClinicalEffects { get; set; } = "";
    public string Management { get; set; } = "";
    [ForeignKey(nameof(MedicationModel))]
    public string MedicationID1 { get; set; } = "";
    public virtual MedicationModel Medication1 { get; set; } = null!;
    [ForeignKey(nameof(MedicationModel))]
    public string MedicationID2 { get; set; } = "";
    public virtual MedicationModel Medication2 { get; set; } = null!;
}
