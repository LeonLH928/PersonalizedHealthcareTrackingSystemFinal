using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum Severity
{
    Mild,
    Moderate,
    Severe,
    Contraindicated
}
public class MedicationInteractionModel
{
    [Key]
    public string InteractionID { get; set; } = "";
    [Required]
    public Severity Severity { get; set; }
    public string Description { get; set; } = "";
    public string ClinicalEffects { get; set; } = "";
    public string Management { get; set; } = "";
    [ForeignKey(nameof(MedicationModel))]
    public string Medication1ID { get; set; } = "";
    public virtual MedicationModel Medication1 { get; set; } = null!;
    [ForeignKey(nameof(MedicationModel))]
    public string Medication2ID { get; set; } = "";
    public virtual MedicationModel Medication2 { get; set; } = null!;
}
