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
                                           AP:Appointments(
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
        
        var content = recordsResponse.Content!;
        content = content.Replace("\"Appointments\"", "\"tempAP\"")
                         .Replace("\"AP\"", "\"Appointment\"");

        var records = JsonSerializer.Deserialize<List<MedicalRecordModel>>(content, options);

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
                                           AP:Appointments(
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
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Appointments\"", "\"tempAP\"")
                         .Replace("\"AP\"", "\"Appointment\"");

        var records = JsonSerializer.Deserialize<List<MedicalRecordModel>>(content, options);

        return records!.FirstOrDefault();
    }
    public async Task<IEnumerable<MedicalRecordModel>> SearchByTextAsync(string SearchText)
    {
        var response = await _client
                                    .From<MedicalRecordModel>()
                                    .Select("""
                                           *,
                                           AP:Appointments(
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
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Appointments\"", "\"tempAP\"")
                         .Replace("\"AP\"", "\"Appointment\"");

        var models = JsonSerializer.Deserialize<List<MedicalRecordModel>>(content, options);

        if (models == null)
            return [];

        SearchText = SearchText.Replace("Dr.", "").ToLower().Trim();

        var records = models.Where(r =>
            r.Appointment.Doctor.User.FirstName.ToLower().Contains(SearchText)
         || r.Appointment.Doctor.User.LastName.ToLower().Contains(SearchText)
         || r.Diagnosis.ToLower().Contains(SearchText)
         || r.Appointment.ChiefComplaint.ToLower().Contains(SearchText)
            );

        return records;
    }
}
