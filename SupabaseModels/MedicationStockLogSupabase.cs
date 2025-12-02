using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels
{
    [Table("MedicationStockLogs")]
    public class MedicationStockLogModel : BaseModel
    {
        [PrimaryKey]
        [Column("LogID")]
        public string LogID { get; set; } = "";

        [Column("QuantityChange")]
        public int QuantityChange { get; set; }

        [Column("Reason")]
        public string Reason { get; set; } = "";

        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column("MedicationID")]
        public string MedicationID { get; set; } = "";

        [Column("RelatedPrescriptionID")]
        public string RelatedPrescriptionID { get; set; } = "";
    }
}