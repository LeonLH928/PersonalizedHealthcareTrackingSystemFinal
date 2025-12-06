using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class PatientRepository : IPatientRepository
{
    private readonly Client _client;
    public PatientRepository(Client client)
    {
        _client = client;
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public async Task<PatientModel?> GetPatientByIDAsync(string PatientID)
    {
        var response = await _client.From<PatientModel>()
                                    .Select("*")
                                    .Filter("PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                    .Get();
        return response.Model;
    }
}
