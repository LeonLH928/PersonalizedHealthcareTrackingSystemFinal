using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class ClinicalExaminationRepository : IClinicalExaminationRepository
{
    private readonly Client _client;
    public ClinicalExaminationRepository(Client client)
    {
        _client = client;
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
                                    .Select("*")
                                    .Filter("RecordID", Supabase.Postgrest.Constants.Operator.Equals, RecordID)
                                    .Get();

        return response.Model;
    }
    public async Task<IEnumerable<ClinicalExaminationModel>> GetAllClinicalExaminationsByMedicalRecordIDsAsync(List<string> MedicalRecordIDs)
    {
        var response = await _client.From<ClinicalExaminationModel>()
                                    .Select("*")
                                    .Filter("RecordID", Supabase.Postgrest.Constants.Operator.In, MedicalRecordIDs)
                                    .Get();

        return response.Models;
    }
}
