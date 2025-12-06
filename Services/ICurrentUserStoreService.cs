using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface ICurrentUserStoreService
{
    UserModel? GetCurrentUserAsync();
}
