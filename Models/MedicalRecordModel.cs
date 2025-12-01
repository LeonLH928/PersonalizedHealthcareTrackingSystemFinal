using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public class MedicalRecordModel
{
    [Key]
    public string RecordID { get; set; } = "";
    [Required]
    public DateTime VisitTime { get; set; } = DateTime.Now;
    public string Diagnosis { get; set; } = "";
    public string DoctorNotes { get; set; } = "";
    public DateTime NextVisitDate { get; set; }= DateTime.Now;
    [ForeignKey(nameof(AppointmentModel))]
    public string AppointmentID { get; set; } = "";
    public virtual AppointmentModel Appointment { get; set; } = null!;
    public virtual ClinicalExaminationModel ClinicalExamination { get; set; } = null!;
    public virtual PrescriptionModel Prescription { get; set; } = null!;
}
