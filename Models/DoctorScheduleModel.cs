using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public class DoctorScheduleModel
{
    [Key]
    public string ScheduleID { get; set; } = "";
    [Required]
    public DateTime StartTime { get; set; } = DateTime.UtcNow;
    [Required]
    public DateTime EndTime { get; set; } = DateTime.UtcNow;
    public DateTime CreatedDatetime { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDatetime { get; set; } = DateTime.UtcNow;
    [ForeignKey(nameof(DoctorModel))]
    public string DoctorID { get; set; } = "";
    public virtual DoctorModel Doctor { get; set; } = null!;
}
