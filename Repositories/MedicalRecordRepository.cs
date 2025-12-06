using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;
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
    public async Task AddMedicalRecordAsync(MedicalRecordModel NewRecord)
    {
        await _client.From<MedicalRecordModel>()
                     .Insert(NewRecord);
    }
    public async Task<IEnumerable<MedicalRecordModel>> GetAllMedicalRecordsByPatientIDAsync(string PatientID)
    {
        var appointmentResponse = await _client
                                            .From<AppointmentModel>()
                                            .Select("AppointmentID")
                                            .Filter("PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                            .Get();

        var appointmentIds = appointmentResponse.Models.Select(a => a.AppointmentID).ToList();

        var recordsResponse = await _client
                                    .From<MedicalRecordModel>()
                                    .Select("*")
                                    .Filter("AppointmentID", Supabase.Postgrest.Constants.Operator.In, appointmentIds)
                                    .Order("VisitTime", Supabase.Postgrest.Constants.Ordering.Descending)
                                    .Get();

        return recordsResponse.Models;
    }
    public async Task<MedicalRecordModel?> GetLatestMedicalRecordByPatientIDAsync(string PatientID)
    {
        var appointmentResponse = await _client
                                            .From<AppointmentModel>()
                                            .Select("AppointmentID")
                                            .Filter("PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                            .Get();

        var appointmentIds = appointmentResponse.Models.Select(a => a.AppointmentID).ToList();

        var response = await _client
                                    .From<MedicalRecordModel>()
                                    .Select("*")
                                    .Filter("AppointmentID", Supabase.Postgrest.Constants.Operator.In, appointmentIds)
                                    .Order("VisitTime", Supabase.Postgrest.Constants.Ordering.Descending)
                                    .Limit(1)
                                    .Single();

        return response;
    }
}
