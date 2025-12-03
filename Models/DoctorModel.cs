using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.RightsManagement;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public class DoctorModel
{
    [Key]
    public string DoctorID { get; set; } = "";
    [Required]
    public string Specialization { get; set; } = "";
    public double ConsultationFee { get; set; }
    public double Rating { get; set; }
    public int YearsOfExperience { get; set; }
    [ForeignKey(nameof(UserModel))]
    public string UserID { get; set; } = "";
    public virtual UserModel User { get; set; } = null!;
    public virtual List<DoctorScheduleModel> DoctorSchedules { get; set; } = [];
    public virtual List<AppointmentModel> Appointments { get; set; } = [];
}
