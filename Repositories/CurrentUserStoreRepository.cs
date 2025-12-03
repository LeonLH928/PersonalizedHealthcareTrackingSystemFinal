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
    public async Task<DoctorModel> GetDoctorFromUserAsync()
    {
        var Doctor = await _client
                .From<DoctorModel>()
                .Where(d => d.UserID == CurrentUser.UserID)
                .Get();
        return Doctor.Model ?? throw new Exception("You are not a doctor!");
    }
    public async Task<PatientModel> GetPatientFromUserAsync()
    {
        var Patient = await _client
                .From<PatientModel>()
                .Where(p => p.UserID == CurrentUser.UserID)
                .Get();
        return Patient.Model ?? throw new Exception("You are not a patient!");
    }
    public async Task<PharmacistModel> GetPharmacistFromUserAsync()
    {
        var Pharmacist = await _client
                .From<PharmacistModel>()
                .Where(p => p.UserID == CurrentUser.UserID)
                .Get();
        return Pharmacist.Model ?? throw new Exception("You are not a pharmacist!");
    }
}
