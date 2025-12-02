using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface ICurrentUserStoreRepository
{
    UserModel CurrentUser { get; }
    void SetUser(UserModel user);
    void ClearUser();
    bool IsLoggedIn => CurrentUser != null;
}
