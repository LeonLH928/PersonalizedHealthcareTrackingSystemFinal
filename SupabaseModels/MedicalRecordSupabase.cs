using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using System;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels
{
    [Table("MedicalRecords")]
    public class MedicalRecordModel : BaseModel
    {
        [PrimaryKey]
        [Column("RecordID")]
        public string RecordID { get; set; } = "";

        [Column("VisitTime")]
        public DateTime VisitTime { get; set; } = DateTime.UtcNow;

        [Column("Diagnosis")]
        public string Diagnosis { get; set; } = "";

        [Column("TreatmentPlan")]
        public string TreatmentPlan { get; set; } = "";

        [Column("DoctorNotes")]
        public string DoctorNotes { get; set; } = "";

        [Column("NextVisitDate")]
        public DateTime NextVisitDate { get; set; } = DateTime.UtcNow;

        [Column("AppointmentID")]
        public string AppointmentID { get; set; } = "";
    }
}