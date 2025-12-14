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

        [Column("CreatedDatetime")]
        public DateTime CreatedDatetime { get; set; } = DateTime.UtcNow;

        [Column("UpdatedDatetime")]
        public DateTime UpdatedDatetime { get; set; } = DateTime.UtcNow;

        public DoctorModel Doctor { get; set; } = null!;
    }
}