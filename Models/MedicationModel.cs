using System.ComponentModel.DataAnnotations;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum Form
{
    Tablet,
    Capsule,
    Syrup,
    Injection,
    Cream,
    Drops,
    Inhaler,
    Other
}

public enum MedicationCategory
{
    Antibiotic,
    PainReliever,
    ChronicCondition, 
    Supplement,       
    Respiratory,      
    MentalHealth,     
    Allergy,
    Other
}

public class MedicationModel
{
    [Key]
    public string MedicationID { get; set; } = "";
    [Required]
    public string Name { get; set; } = "";
    public string ActiveIngredient { get; set; } = "";

    [Required]
    public Form Form { get; set; }
    [Required]
    public MedicationCategory Category { get; set; } = MedicationCategory.Other;
    public string BaseUnit { get; set; } = "";
    public int StockTotalQuantity { get; set; }
    public string PackingUnit { get; set; } = "";
    public int UnitsPerPack { get; set; }
    public string PackingDescription { get; set; } = "";
    public string SideEffect { get; set; } = "";
    public string StorageInstruction { get; set; } = "";
    public int Price { get; set; }
    public virtual List<PrescriptionItemModel> PrescriptionItems { get; set; } = [];
    public virtual List<MedicationInteractionModel> MedicationInteractions1 { get; set; } = [];
    public virtual List<MedicationInteractionModel> MedicationInteractions2 { get; set; } = [];
    public virtual List<MedicationStockLogModel> MedicationStockLogs { get; set; } = []; 
}
