using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class MedicationStockLogRepository : IMedicationStockLogRepository
{
    public readonly Client _client;
    public JsonSerializerOptions options;
    public MedicationStockLogRepository(Client client)
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
    public async Task<IEnumerable<MedicationStockLogModel>> GetAllLogsAsync()
    {
        var response = await _client.From<MedicationStockLogModel>()
                                    .Select("""
                                            *,
                                            ME:Medications(*),
                                            PE:Prescriptions(*)
                                            """)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Medications\"", "\"tempME\"")
                         .Replace("\"Prescriptions\"", "\"tempPE\"")
                         .Replace("\"ME\"", "\"Medication\"")
                         .Replace("\"PE\"", "\"Prescription\"");

        var logs = JsonSerializer.Deserialize<List<MedicationStockLogModel>>(content, options);

        return logs == null ? [] : logs;
    }

}
