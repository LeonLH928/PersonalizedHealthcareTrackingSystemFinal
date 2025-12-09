using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum PrescriptionStatus
{
    Pending,
    Completed,
    Dispensed,
    Cancelled
}
public class PrescriptionModel
{
    [Key]
    public string PrescriptionID { get; set; } = "";
    [Required]
    public DateTime PrescriptionDateTime { get; set; } = DateTime.UtcNow;
    public PrescriptionStatus Status { get; set; } = PrescriptionStatus.Pending;
    public DateTime? VerifiedAt { get; set; } = null!;
    public DateTime? DispensedAt { get; set; } = null!;
    public DateTime? CancelledAt { get; set; } = null!;
    public string? Reason { get; set; } = "";
    [Required]
    public Priority Priority { get; set; } = Priority.Routine;
    [ForeignKey(nameof(MedicalRecordModel))]
    public string RecordID { get; set; } = "";
    public virtual MedicalRecordModel MedicalRecord { get; set; } = null!;
    [ForeignKey(nameof(PharmacistModel))]
    public string PharmacistID { get; set; } = "";
    public virtual PharmacistModel PharmacistChecking { get; set; } = null!;
    public virtual List<PrescriptionItemModel> PrescriptionItems { get; set; } = [];
    public virtual List<MedicationStockLogModel> MedicationStockLogs { get; set; } = [];
}
