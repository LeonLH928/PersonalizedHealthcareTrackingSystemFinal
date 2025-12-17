using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IPharmacistService
{
    Task<PharmacistModel?> GetPharmacistByUserIDAsync(string UserID);
}
