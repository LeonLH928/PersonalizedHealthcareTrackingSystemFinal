using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class CurrentUserStoreService : ICurrentUserStoreService
{
    private readonly ICurrentUserStoreRepository _currentUserStoreRepository;
    public CurrentUserStoreService(ICurrentUserStoreRepository currentUserStoreRepository)
    {
        _currentUserStoreRepository = currentUserStoreRepository;
    }
    public UserModel? GetCurrentUser()
    {
        return _currentUserStoreRepository.GetCurrentUser();
    }
}
