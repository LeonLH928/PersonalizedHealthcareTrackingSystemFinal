using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase.Postgrest;
using Supabase.Postgrest.Interfaces;
using static Supabase.Postgrest.Constants;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class MedicationRepository : IMedicationRepository
{
    public readonly Supabase.Client _client;
    public MedicationRepository(Supabase.Client client)
    {
        _client = client;
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public async Task<IEnumerable<MedicationModel>> SearchByTextAsync(string SearchText)
    {
        var cleanText = $"%{SearchText.Trim()}%";

        var filters = new List<IPostgrestQueryFilter>
        {
            new QueryFilter("MedicationID", Operator.ILike, cleanText),
            new QueryFilter("Name", Operator.ILike, cleanText),
            new QueryFilter("SideEffect", Operator.ILike, cleanText),
            new QueryFilter("StorageInstruction", Operator.ILike, cleanText),
        };

        var response = await _client
                                    .From<MedicationModel>()
                                    .Select("*")
                                    .Or(filters)
                                    .Limit(20)
                                    .Get();

        return response.Models;
    }
    public async Task<IEnumerable<MedicationModel>> GetAllMedicationsAsync()
    {
        var response = await _client
                                    .From<MedicationModel>()
                                    .Select("*")
                                    .Get();
        return response.Models;
    }
    public async Task<IEnumerable<MedicationModel>> GetAllMedicationsByIDsAsync(List<string> MedicationIDs)
    {
        var response = await _client
                                    .From<MedicationModel>()
                                    .Select("*")
                                    .Filter("MedicationID", Operator.In, MedicationIDs)
                                    .Get();
        return response.Models;
    }
}
