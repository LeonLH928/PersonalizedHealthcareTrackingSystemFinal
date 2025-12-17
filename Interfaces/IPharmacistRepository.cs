using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IPharmacistRepository
{
    Task<PharmacistModel?> GetPharmacistByUserIDAsync(string UserID);
}
