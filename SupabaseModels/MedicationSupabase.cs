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

        [Column("ActiveIngredient")]
        public string ActiveIngredient { get; set; } = ""; 
        
        [Column("Form")]
        public Form Form { get; set; }

        [Column("BaseUnit")]
        public string BaseUnit { get; set; } = "";

        [Column("StockTotalQuantity")]
        public int StockTotalQuantity { get; set; }

        [Column("PackingUnit")]
        public string PackingUnit { get; set; } = "";

        [Column("UnitsPerPack")]
        public int UnitsPerPack { get; set; }

        [Column("PackingDescription")]
        public string PackingDescription { get; set; } = "";

        [Column("SideEffect")]
        public string SideEffect { get; set; } = "";

        [Column("StorageInstruction")]
        public string StorageInstruction { get; set; } = "";

        [Column("Price")]
        public int Price { get; set; }
    }
}