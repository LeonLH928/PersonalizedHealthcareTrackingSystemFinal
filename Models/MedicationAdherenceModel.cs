using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;

public enum AdherenceStatus
{
    Pending, 
    Taken,   
    Skipped, 
    Missed   
}
public class MedicationAdherenceModel
{
    [Key]
    public string AdherenceID { get; set; } = "";
    public DateTime ScheduledDateTime { get; set; }

    public DateTime? TakenDateTime { get; set; }

    public AdherenceStatus Status { get; set; } = AdherenceStatus.Pending;

    public string? Notes { get; set; }

    [ForeignKey(nameof(PrescriptionItemModel))]
    public string PrescriptionItemID { get; set; } = null!;
    public virtual PrescriptionItemModel PrescriptionItem { get; set; } = null!;
}

