using PersonalizedHealthcareTrackingSystemFinal.Models;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("Appointments")]
public class AppointmentModel : BaseModel
{
    [PrimaryKey]
    [Column("AppointmentID")]
    public string AppointmentID { get; set; } = "";

    [Column("AppointmentDateTime")]
    public DateTime AppointmentDateTime { get; set; } = DateTime.UtcNow;

    [Column("ChiefComplaint")]
    public string ChiefComplaint { get; set; } = "";

    [Column("Location")]
    public string Location { get; set; } = "";

    [Column("Status")]
    public StatusAppointment Status { get; set; } = StatusAppointment.Scheduled;

    [Column("Note")]
    public string Note { get; set; } = "";

    [Column("Priority")]
    public Priority Priority { get; set; } = Priority.Routine;

    [Column("VisitNumber")]
    public int VisitNumber { get; set; }

    [Column("PatientID")]
    public string PatientID { get; set; } = "";

    [Column("DoctorID")]
    public string DoctorID { get; set; } = "";
}