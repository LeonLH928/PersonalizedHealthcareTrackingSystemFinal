using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class PrescriptionItemRepository : IPrescriptionItemRepository
{
    private readonly Client _client;
    public JsonSerializerOptions options;
    public PrescriptionItemRepository(Client client)
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
    public async Task AddPrescriptionItemAsync(PrescriptionItemModel NewItem)
    {
        await _client.From<PrescriptionItemModel>()
                     .Upsert(NewItem);
    }
    public async Task<IEnumerable<PrescriptionItemModel>> GetAllPrescriptionItemsByPrescriptionID(string PrescriptionID)
    {
        var response = await _client.From<PrescriptionItemModel>()
                                    .Select("""
                                        *,
                                        Medication:Medications(
                                            *
                                        )
                                     """)
                                    .Where(p => p.PrescriptionID == PrescriptionID)
                                    .Get();

        var prescriptionItems = JsonSerializer.Deserialize<List<PrescriptionItemModel>>(response.Content!, options);

        return prescriptionItems == null ? [] : prescriptionItems;
    }
}
