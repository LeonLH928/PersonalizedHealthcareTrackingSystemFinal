using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public enum StatusAppointment
{
    Scheduled,
    Happening,
    Completed,
    Cancelled,
    No_show
}
public enum Priority
{
    Routine,   // Bình thường
    Urgent,    // Gấp
    Stat      // Tối khẩn cấp / Ngay lập tức
}
public class AppointmentModel
{
    [Key]
    public string AppointmentID { get; set; } = "";
    [Required]
    public DateTime AppointmentDateTime { get; set; } = DateTime.Now;
    public string ChiefComplaint { get; set; } = "";
    public string Location { get; set; } = "";
    public StatusAppointment Status { get; set; } = StatusAppointment.Scheduled;
    public string Note { get; set; } = "";
    public Priority Priority { get; set; } = Priority.Routine;
    public int VisitNumber { get; set; }

    [ForeignKey(nameof(PatientModel))]
    public string PatientID { get; set; } = "";
    public virtual PatientModel Patient { get; set; } = null!;
    [ForeignKey(nameof(DoctorModel))]
    public string DoctorID { get; set; } = "";
    public virtual DoctorModel Doctor { get; set; } = null!;
    public virtual MedicalRecordModel MedicalRecord { get; set; } = null!;
}
