using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalizedHealthcareTrackingSystemFinal.Models;
public class PharmacistModel
{
    [Key]
    public string PharmacistID { get; set; } = "";
    public string Department { get; set; } = "";
    [ForeignKey(nameof(UserModel))]
    public string UserID { get; set; } = "";
    public virtual UserModel User { get; set; } = null!;
    public virtual List<PrescriptionModel> Prescriptions { get; set; } = null!;
}
