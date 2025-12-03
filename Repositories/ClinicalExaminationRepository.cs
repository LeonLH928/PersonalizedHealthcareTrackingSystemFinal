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
    public async Task<IEnumerable<ClinicalExaminationModel>> GetAllClinicalExaminationsByPatientIDAsync(string PatientID)
    {
        var response = await _client
                                .From<ClinicalExaminationModel>()
                                .Select("*, MedicalRecro(Appointments())")
                                .Filter("MedicalRecords.Appointments.PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                .Get();

        return response.Models;
    }
}
