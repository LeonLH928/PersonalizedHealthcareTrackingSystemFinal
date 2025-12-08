using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

[Table("Pharmacists")]
public class PharmacistModel : BaseModel
{
    [PrimaryKey]
    [Column("PharmacistID")]
    public string PharmacistID { get; set; } = "";

    [Column("Department")]
    public string Department { get; set; } = "";

    [Column("UserID")]
    public string UserID { get; set; } = "";

    public UserModel User { get; set; } = null!;
}