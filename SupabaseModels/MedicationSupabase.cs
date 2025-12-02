using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels
{
    [Table("Medications")]
    public class MedicationModel : BaseModel
    {
        [PrimaryKey]
        [Column("MedicationID")]
        public string MedicationID { get; set; } = "";

        [Column("Name")]
        public string Name { get; set; } = "";

        [Column("Form")]
        public Form Form { get; set; }

        [Column("Unit")]
        public string Unit { get; set; } = "";

        [Column("SideEffect")]
        public string SideEffect { get; set; } = "";

        [Column("StorageInstruction")]
        public string StorageInstruction { get; set; } = "";

        [Column("StockQuantity")]
        public int StockQuantity { get; set; }

        [Column("StockQuantityUnit")]
        public string StockQuantityUnit { get; set; } = "";

        [Column("Price")]
        public int Price { get; set; }
    }
}