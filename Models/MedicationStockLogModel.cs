using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public class MedicationStockLogModel
{
    [Key]
    public string LogID { get; set; } = "";
    [Required]
    public int QuantityChange { get; set; }
    public string Reason { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [ForeignKey(nameof(MedicationModel))]
    public string MedicationID { get; set; } = "";
    public virtual MedicationModel Medication { get; set; } = null!;
    [ForeignKey(nameof(PrescriptionModel))]
    public string RelatedPrescriptionID { get; set; } = "";
    public virtual PrescriptionModel Prescription { get; set; } = null!;
}
