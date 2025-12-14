using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using Supabase.Gotrue;
using System.Diagnostics;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class DoctorRepository : IDoctorRepository
{
    public readonly Supabase.Client _client;
    public JsonSerializerOptions options;
    public DoctorRepository(Supabase.Client client)
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
        var response = await _client.From<DoctorModel>()
                                    .Select("*, U:Users(*)")
                                    .Where(d => d.UserID == UserID)
                                    .Get();

        var content = response.Content!;

        content = content.Replace("\"Users\"", "\"tempU\"")
                         .Replace("\"U\"", "\"User\"");

        var list = JsonSerializer.Deserialize<List<DoctorModel>>(content, options);
        var doctor = list?.FirstOrDefault();

        return doctor;
    }
    public async Task<IEnumerable<DoctorModel>> GetAllDoctorsAsync()
    {
        var response = await _client.From<DoctorModel>()
                                    .Select("*, U:Users(*)")
                                    .Get();

        var content = response.Content!;

        content = content.Replace("\"Users\"", "\"tempU\"")
                         .Replace("\"U\"", "\"User\"");

        var list = JsonSerializer.Deserialize<List<DoctorModel>>(content, options);

        return list == null ? [] : list;
    }
    public async Task<IEnumerable<DoctorModel>> SearchByText(string SearchText)
    {
        var response = await _client.From<DoctorModel>()
                                    .Select("*, U:Users(*)")
                                    .Limit(20)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Users\"", "\"tempU\"")
                         .Replace("\"U\"", "\"User\"");

        var models = JsonSerializer.Deserialize<List<DoctorModel>>(content, options);

        if (models == null)
            return [];

        SearchText = SearchText.Replace("Dr.", "");
        var doctors = models.Where(d =>
            d.Specialization.ToLower().Contains(SearchText.ToLower().Trim())
         || d.User.FirstName.ToLower().Contains(SearchText.ToLower().Trim())
         || d.User.LastName.ToLower().Contains(SearchText.ToLower().Trim())
            );

        Debug.Write($"\n{doctors.Count()}\n");
        return doctors;
    }
}
