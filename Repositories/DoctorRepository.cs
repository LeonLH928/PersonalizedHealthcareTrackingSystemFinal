using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class DoctorRepository : IDoctorRepository
{
    public readonly Client _client;
    public DoctorRepository(Client client)
    {
        _client = client;
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public async Task<DoctorModel?> GetDoctorByUserIDAsync(string UserID)
    {
        return await _client.From<DoctorModel>()
                            .Select("*")
                            .Where(d => d.UserID == UserID)
                            .Single();
    }
}
