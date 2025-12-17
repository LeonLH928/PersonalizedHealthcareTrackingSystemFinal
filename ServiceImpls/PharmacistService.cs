using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class PharmacistService : IPharmacistService
{
    private readonly IPharmacistRepository _pharmacistRepository;
    public PharmacistService(IPharmacistRepository pharmacistRepository)
    {
        _pharmacistRepository = pharmacistRepository;
    }
    public async Task<PharmacistModel?> GetPharmacistByUserIDAsync(string UserID)
    {
        return await _pharmacistRepository.GetPharmacistByUserIDAsync(UserID);
    }
}
