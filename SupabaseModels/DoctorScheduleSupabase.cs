using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels
{
    [Table("DoctorSchedules")]
    public class DoctorScheduleModel : BaseModel
    {
        [PrimaryKey]
        [Column("ScheduleID")]
        public string ScheduleID { get; set; } = "";

        [Column("StartTime")]
        public DateTime StartTime { get; set; } = DateTime.UtcNow;

        [Column("EndTime")]
        public DateTime EndTime { get; set; } = DateTime.UtcNow;

        [Column("DoctorID")]
        public string DoctorID { get; set; } = "";

        public DoctorModel Doctor { get; set; } = null!;
    }
}