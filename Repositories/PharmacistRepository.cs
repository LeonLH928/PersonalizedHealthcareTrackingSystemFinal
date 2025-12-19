using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class PharmacistRepository : IPharmacistRepository
{
    public readonly Client _client;
    public JsonSerializerOptions options;
    public PharmacistRepository(Client client)
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
    public async Task<PharmacistModel?> GetPharmacistByUserIDAsync(string UserID)
    {
        var response = await _client.From<PharmacistModel>()
                                    .Select("*, U:Users(*)")
                                    .Where(p => p.UserID == UserID)
                                    .Get();

        var content = response.Content!;

        content = content.Replace("\"Users\"", "\"tempU\"")
                         .Replace("\"U\"", "\"User\"");

        var list = JsonSerializer.Deserialize<List<PharmacistModel>>(content, options);
        var pharmacist = list?.FirstOrDefault();

        return pharmacist;
    }
}
