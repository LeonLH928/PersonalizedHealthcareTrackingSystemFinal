using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class CurrentUserStoreRepository : ICurrentUserStoreRepository
{
    public UserModel CurrentUser { get; set; } = null!;
    public void SetUser(UserModel User)
    {
        CurrentUser = User;
    }
    public void ClearUser()
    {
        CurrentUser = null!;
    }
}
