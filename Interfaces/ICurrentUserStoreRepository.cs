using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface ICurrentUserStoreRepository
{
    UserModel CurrentUser { get; }
    Task SetUser(UserModel user);
    Task ClearUser();
    bool IsLoggedIn => CurrentUser != null;
    UserModel? GetCurrentUser();
}
