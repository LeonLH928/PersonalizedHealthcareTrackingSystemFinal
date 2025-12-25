using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface ICurrentUserStoreRepository
{
    UserModel CurrentUser { get; }
    Task SetUserAsync(UserModel user);
    Task ClearUserAsync();
    bool IsLoggedIn => CurrentUser != null;
    UserModel? GetCurrentUser();
}
