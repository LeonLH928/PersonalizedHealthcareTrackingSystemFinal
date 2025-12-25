using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Printing.IndexedProperties;
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
    public async Task<IEnumerable<PrescriptionItemModel>> GetAllPrescriptionItemsByPrescriptionIDAsync(string PrescriptionID)
    {
        var response = await _client.From<PrescriptionItemModel>()
                                    .Select("""
                                        *,
                                        ME:Medications(*),
                                        PE:Prescriptions(*)
                                        """)
                                    .Where(p => p.PrescriptionID == PrescriptionID)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Medications\"", "\"tempME\"")
                         .Replace("\"ME\"", "\"Medication\"")
                         .Replace("\"Prescriptions\"", "\"tempPE\"")
                         .Replace("\"PE\"", "\"Prescription\"");

        var prescriptionItems = JsonSerializer.Deserialize<List<PrescriptionItemModel>>(content, options);

        return prescriptionItems == null ? [] : prescriptionItems;
    }
}
