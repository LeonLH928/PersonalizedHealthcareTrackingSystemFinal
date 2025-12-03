using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public class PrescriptionItemModel
{
    [Key]
    public string ItemID { get; set; } = "";
    public int Quantity { get; set; }
    public string Dosage { get; set; } = "";
    public string Frequency { get; set; } = "";
    public int DurationDays { get; set; }
    public string Instruction { get; set; } = "";
    public string Indication { get; set; } = "";
    public string DoseScheduleJSON { get; set; } = "";
    [ForeignKey(nameof(PrescriptionModel))]
    public string PrescriptionID { get; set; } = "";
    public virtual PrescriptionModel Prescription { get; set; } = null!;
    [ForeignKey(nameof(MedicationModel))]
    public string MedicationID { get; set; } = "";
    public virtual MedicationModel Medication { get; set; } = null!;
}
 