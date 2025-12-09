using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class ClinicalExaminationRepository : IClinicalExaminationRepository
{
    private readonly Client _client;
    public JsonSerializerOptions options;
    public ClinicalExaminationRepository(Client client)
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
    public async Task AddClinicalExaminationAsync(ClinicalExaminationModel NewExam)
    {
        await _client
                    .From<ClinicalExaminationModel>()
                    .Insert(NewExam);
    }
    public async Task<ClinicalExaminationModel?> GetClinicalExaminationByMedicalRecordIDAsync(string RecordID)
    {
        var response = await _client.From<ClinicalExaminationModel>()
                                    .Select("""
                                        *,
                                        MR:MedicalRecords(
                                            *,
                                            Appointment:Appointments(
                                                *,
                                                Patient:Patients(
                                                    *,
                                                    User:Users(*)
                                                ),
                                                Doctor:Doctors(
                                                    *,
                                                    User:Users(*)
                                                )
                                            )
                                        )
                                     """)
                                    .Filter("RecordID", Supabase.Postgrest.Constants.Operator.Equals, RecordID)
                                    .Get();

        var content = response.Content!;
        
        content = content.Replace("\"MedicalRecords\"", "\"tempMR\"")
                         .Replace("\"MR\"", "\"MedicalRecord\"");

        var list = JsonSerializer.Deserialize<List<ClinicalExaminationModel>>(content, options);
        var examination = list?.FirstOrDefault();

        return examination;
    }
    public async Task<IEnumerable<ClinicalExaminationModel>> GetAllClinicalExaminationsByMedicalRecordIDsAsync(List<string> MedicalRecordIDs)
    {
        var response = await _client.From<ClinicalExaminationModel>()
                                    .Select("""
                                        *,
                                        MedicalRecord:MedicalRecords(
                                            *,
                                            Appointment:Appointments(
                                                *,
                                                Patient:Patients(
                                                    *,
                                                    User:Users(*)
                                                ),
                                                Doctor:Doctors(
                                                    *,
                                                    User:Users(*)
                                                )
                                            )
                                        )
                                     """)
                                    .Filter("RecordID", Supabase.Postgrest.Constants.Operator.In, MedicalRecordIDs)
                                    .Get();
        var content = response.Content!;

        content = content.Replace("\"MedicalRecords\"", "\"tempMR\"")
                         .Replace("\"MR\"", "\"MedicalRecord\"");

        var examinations = JsonSerializer.Deserialize<List<ClinicalExaminationModel>>(content, options);

        return examinations == null ? [] : examinations;
    }
}
