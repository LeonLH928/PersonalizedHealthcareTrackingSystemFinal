using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class DoctorRepository : IDoctorRepository
{
    public readonly Client _client;
    public JsonSerializerOptions options;
    public DoctorRepository(Client client)
    {
        _client = client;
        options = new()
        {
            PropertyNameCaseInsensitive = true
        };
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public async Task<DoctorModel?> GetDoctorByUserIDAsync(string UserID)
    {
        return await _client.From<DoctorModel>()
                            .Select("*, User:Users(*)")
                            .Where(d => d.UserID == UserID)
                            .Single();
    }
}
