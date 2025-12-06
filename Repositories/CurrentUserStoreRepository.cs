using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class CurrentUserStoreRepository : ICurrentUserStoreRepository
{
    private readonly Client _client;
    public CurrentUserStoreRepository(Client client)
    {
        _client = client;
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public UserModel CurrentUser { get; set; } = null!;
    public async Task SetUser(UserModel User)
    {
        CurrentUser = User;
        await _client
                .From<UserModel>()
                .Where(u => u.UserID == CurrentUser.UserID)
                .Set(u => u.IsActive, true)
                .Update();        
    }
    public async Task ClearUser()
    {
        await _client
                .From<UserModel>()
                .Where(u => u.UserID == CurrentUser.UserID)
                .Set(u => u.IsActive, false)
                .Update();
        CurrentUser = null!;
    }
    public UserModel? GetCurrentUserAsync()
    {
        return CurrentUser;
    }
}
