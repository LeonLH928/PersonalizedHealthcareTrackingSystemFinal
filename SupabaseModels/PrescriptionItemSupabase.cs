using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels
{
    [Table("PrescriptionItems")]
    public class PrescriptionItemModel : BaseModel
    {
        [PrimaryKey]
        [Column("ItemID")]
        public string ItemID { get; set; } = "";

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("Dosage")]
        public string Dosage { get; set; } = "";

        [Column("Frequency")]
        public string Frequency { get; set; } = "";

        [Column("DurationDays")]
        public int DurationDays { get; set; }

        [Column("Instruction")]
        public string Instruction { get; set; } = "";

        [Column("Indication")]
        public string Indication { get; set; } = "";

        [Column("DoseScheduleJSON")]
        public string DoseScheduleJSON { get; set; } = "";

        [Column("PrescriptionID")]
        public string PrescriptionID { get; set; } = "";

        [Column("MedicationID")]
        public string MedicationID { get; set; } = "";
    }
}