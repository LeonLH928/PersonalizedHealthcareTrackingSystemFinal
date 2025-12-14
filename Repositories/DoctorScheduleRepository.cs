using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class DoctorScheduleRepository : IDoctorScheduleRepository
{
    public readonly Client _client;
    public JsonSerializerOptions options;
    public DoctorScheduleRepository(Client client)
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
    public async Task<IEnumerable<DoctorScheduleModel>> GetAllSchedulesByDoctorIDAsync(string DoctorID)
    {
        var response = await _client
                                    .From<DoctorScheduleModel>()
                                    .Where(ds => ds.DoctorID == DoctorID)
                                    .Select("""
                                        *,
                                        D:Doctors(*, Users(*))
                                     """)
                                    .Get();

        var content = response.Content!;

        content = content.Replace("\"Doctors\"", "\"tempD\"")
                         .Replace("\"D\"", "\"Doctor\"");

        var list = JsonSerializer.Deserialize<List<DoctorScheduleModel>>(content, options);

        return list == null ? [] : list;
    }
    public async Task<DoctorScheduleModel?> GetLatestScheduleByDoctorIDAsync(string DoctorID)
    {
        var response = await _client
                                    .From<DoctorScheduleModel>()
                                    .Where(ds => ds.DoctorID == DoctorID)
                                    .Select("""
                                        *,
                                        D:Doctors(*, Users(*))
                                     """)
                                    .Order("UpdatedDatetime", Supabase.Postgrest.Constants.Ordering.Descending)
                                    .Get();

        var content = response.Content!;

        content = content.Replace("\"Doctors\"", "\"tempD\"")
                         .Replace("\"D\"", "\"Doctor\"");

        var list = JsonSerializer.Deserialize<List<DoctorScheduleModel>>(content, options);
        var schedule = list?.FirstOrDefault();
        
        return schedule;
    }
}
