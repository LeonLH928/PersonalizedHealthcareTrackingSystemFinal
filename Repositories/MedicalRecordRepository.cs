using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;
using System.Numerics;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class MedicalRecordRepository : IMedicalRecordRepository
{
    private readonly Client _client;
    public JsonSerializerOptions options;
    public MedicalRecordRepository(Client client)
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
                                    .Select("""
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
            
                                    """)
                                    .Filter("AppointmentID", Supabase.Postgrest.Constants.Operator.In, appointmentIds)
                                    .Order("VisitTime", Supabase.Postgrest.Constants.Ordering.Descending)
                                    .Get();
        
        var records = JsonSerializer.Deserialize<List<MedicalRecordModel>>(recordsResponse.Content!, options);

        return records == null ? [] : records;
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
                                    .Select("""
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
            
                                    """)
                                    .Filter("AppointmentID", Supabase.Postgrest.Constants.Operator.In, appointmentIds)
                                    .Order("VisitTime", Supabase.Postgrest.Constants.Ordering.Descending)
                                    .Limit(1)
                                    .Single();

        return response;
    }
}
