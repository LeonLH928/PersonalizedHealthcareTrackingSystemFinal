using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
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
                                    .Filter("RecordID", Supabase.Postgrest.Constants.Operator.Equals, RecordID)
                                    .Get();

        return response.Model;
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
        var examinations = JsonSerializer.Deserialize<List<ClinicalExaminationModel>>(response.Content!, options);

        return examinations == null ? [] : examinations;
    }
}
