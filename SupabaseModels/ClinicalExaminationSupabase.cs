using PersonalizedHealthcareTrackingSystemFinal.Models;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("ClinicalExaminations")]
public class ClinicalExaminationModel : BaseModel
{
    [PrimaryKey]
    [Column("ClinicalID")]
    public string ClinicalID { get; set; } = "";

    [Column("Symptoms")]
    public string Symptoms { get; set; } = "";

    [Column("MedicalHistory")]
    public string MedicalHistory { get; set; } = "";

    [Column("FamilyHistory")]
    public string FamilyHistory { get; set; } = "";

    [Column("LifestyleHabits")]
    public string LifestyleHabits { get; set; } = "";

    [Column("Allergies")]
    public string Allergies { get; set; } = "";

    [Column("Temperature")]
    public double Temperature { get; set; }

    [Column("Height")]
    public double Height { get; set; }

    [Column("Weight")]
    public double Weight { get; set; }
    
    [Column("BMI")]
    public double BMI { get; set; }
    
    [Column("StatusBMI")]
    public StatusBMI StatusBMI { get; set; } = StatusBMI.Normal;

    [Column("Pulse")]
    public double Pulse { get; set; }

    [Column("BloodPressure")]
    public string BloodPressure { get; set; } = "";

    [Column("RespiratoryRate")]
    public double RespiratoryRate { get; set; }

    [Column("OxygenSaturation")]
    public double OxygenSaturation { get; set; }

    [Column("RecordID")]
    public string RecordID { get; set; } = "";

    public MedicalRecordModel MedicalRecord { get; set; } = null!;
}