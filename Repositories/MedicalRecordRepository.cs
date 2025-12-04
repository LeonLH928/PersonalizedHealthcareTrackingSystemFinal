using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Numerics;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class MedicalRecordRepository : IMedicalRecordRepository
{
    private readonly Client _client;
    public MedicalRecordRepository(Client client)
    {
        _client = client;
        InitializeSupabase();
    }
    private async void InitializeSupabase()
    {
        await _client.InitializeAsync();
    }
    public async Task<IEnumerable<MedicalRecordModel>> GetAllMedicalRecordsByPatientIDAsync(string PatientID)
    {
        var response = await _client
                                    .From<MedicalRecordModel>()
                                    .Select("*, Appointment:Appointments(*)")
                                    .Filter("Appointment.PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                    .Order("VisitTime", Supabase.Postgrest.Constants.Ordering.Descending)
                                    .Get();
        return response.Models;
    }
    public async Task<MedicalRecordModel> GetLatestMedicalRecordByPatientIDAsync(string PatientID)
    {
        var response = await _client
                                    .From<MedicalRecordModel>()
                                    .Select("*, Appointment:Appointments(*)")
                                    .Filter("Appointment.PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                    .Order("VisitTime", Supabase.Postgrest.Constants.Ordering.Descending)
                                    .Limit(1)
                                    .Single();

        return response ?? throw new Exception("No such medical record");
    }
}
