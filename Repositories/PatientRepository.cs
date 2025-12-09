using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class PatientRepository : IPatientRepository
{
    private readonly Client _client;
    public JsonSerializerOptions options;

    public PatientRepository(Client client)
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
    public async Task<PatientModel?> GetPatientByIDAsync(string PatientID)
    {
        var response = await _client.From<PatientModel>()
                                    .Select("*, U:Users(*)")
                                    .Filter("PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Users\"", "\"tempU\"")
                         .Replace("\"U\"", "\"User\"");

        

        return response.Model;
    }
    public async Task<PatientModel?> GetPatientByIDAsync(string UserID)
    {
        var response = await _client.From<PatientModel>()
                                    .Select("*, User:Users(*)")
                                    .Filter("UserID", Supabase.Postgrest.Constants.Operator.Equals, UserID)
                                    .Get();
        return response.Model;
    }
}
