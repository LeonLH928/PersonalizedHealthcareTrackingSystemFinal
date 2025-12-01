using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum PrescriptionStatus
{
    pending,
    verified,
    dispensed,
    cancelled
}
public class PrescriptionModel
{
    [Key]
    public string PrescriptionId { get; set; } = "";
    [Required]
    public DateTime PrescriptionDateTime { get; set; } = DateTime.Now;
    public PrescriptionStatus Status { get; set; } = PrescriptionStatus.pending;
    public DateTime VerifiedAt { get; set; } = DateTime.Now;
    public DateTime DispensedAt { get; set; } = DateTime.Now;
    [Required]
    public Priority Priority { get; set; } = Priority.routine;
    [ForeignKey(nameof(MedicalRecordModel))]
    public string RecordID { get; set; } = "";
    public virtual MedicalRecordModel MedicalRecord { get; set; } = null!;
    [ForeignKey(nameof(PharmacistModel))]
    public string PharmacistID { get; set; } = "";
    public virtual PharmacistModel PharmacistChecking { get; set; } = null!;
    public virtual List<PrescriptionItemModel> PrescriptionItems { get; set; } = [];
    public virtual List<MedicationStockLogModel> MedicationStockLogs { get; set; } = [];
}
