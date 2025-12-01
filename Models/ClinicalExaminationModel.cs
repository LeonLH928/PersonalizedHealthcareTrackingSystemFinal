using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public class ClinicalExaminationModel
{
    [Key]
    public string ClinicalID { get; set; } = "";
    public string Symptoms { get; set; } = "";
    public string MedicalHistory { get; set; } = "";
    public string FamilyHistory { get; set; } = "";
    public string LifestyleHabits { get; set; } = "";
    public string Allergies { get; set; } = "";
    public double Temperature { get; set; } 
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Pulse { get; set; }
    public string BloodPressure { get; set; } = "";
    public double RespiratoryRate { get; set; }
    public double OxygenSaturation { get; set; }
    [ForeignKey(nameof(MedicalRecordModel))]
    public string RecordID { get; set; } = "";
    public virtual MedicalRecordModel MedicalRecord { get; set; } = null!;
}
