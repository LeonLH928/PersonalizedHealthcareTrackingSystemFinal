using System.ComponentModel.DataAnnotations;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum Form
{
    tablet,
    capsule,
    syrup,
    injection,
    cream,
    drops,
    inhaler,
    other
}
public class MedicationModel
{
    [Key]
    public string MedicationID { get; set; } = "";
    [Required]
    public string Name { get; set; } = "";
    [Required]
    public Form Form { get; set; }
    public string Unit { get; set; } = "";
    public string SideEffect { get; set; } = "";
    public string StorageInstruction { get; set; } = "";
    public int StockQuantity { get; set; }
    public string StockQuantityUnit { get; set; } = "";
    public int Price { get; set; }
    public virtual List<PrescriptionItemModel> PrescriptionItems { get; set; } = [];
    public virtual List<MedicationInteractionModel> MedicationInteractions { get; set; } = [];
    public virtual List<MedicationStockLogModel> MedicationStockLogs { get; set; } = []; 
}
