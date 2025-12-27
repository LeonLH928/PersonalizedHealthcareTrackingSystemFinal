using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.CodeDom;
using System.Diagnostics;
using System.Text.Json;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class AppointmentRepository : IAppointmentRepository
{
    public readonly Client _client;
    public JsonSerializerOptions options;
    public AppointmentRepository(Client client)
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
    
    public async Task AddAppointmentAsync(AppointmentModel NewAppointment)
    {
        await _client.From<AppointmentModel>()
                     .Upsert(NewAppointment);
    }
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("""
                                            *,
                                            P:Patients(*, User:Users(*)),
                                            D:Doctors(*, User:Users(*))
                                            """)
                                    .Filter("DoctorID", Supabase.Postgrest.Constants.Operator.Equals, DoctorID)
                                    .Get();
        
        var content = response.Content!;
        content = content.Replace("\"Patients\"", "\"tempP\"")
                         .Replace("\"Doctors\"", "\"tempD\"")
                         .Replace("\"P\"", "\"Patient\"")
                         .Replace("\"D\"", "\"Doctor\"");

        var appointments = JsonSerializer.Deserialize<List<AppointmentModel>>(content, options);

        return appointments == null ? [] : appointments;
    }
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDatetimeAndDoctorIDAsync(DateTime datetime, string DoctorID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("""
                                            *,
                                            P:Patients(*, User:Users(*)),
                                            D:Doctors(*, User:Users(*))
                                            """)
                                    .Where(a => a.DoctorID == DoctorID)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Patients\"", "\"tempP\"")
                         .Replace("\"Doctors\"", "\"tempD\"")
                         .Replace("\"P\"", "\"Patient\"")
                         .Replace("\"D\"", "\"Doctor\"");

        var appointments = JsonSerializer.Deserialize<List<AppointmentModel>>(content, options);

        appointments = appointments!.Where(a => a.AppointmentDateTime.Date == datetime.Date).ToList();

        return appointments == null ? [] : appointments;
    }
    public async Task<AppointmentModel?> GetNearestAppointmentByDoctorIDAsync(string DoctorID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("""
                                            *,
                                            Patient:Patients(*, User:Users(*)),
                                            Doctor:Doctors(*, User:Users(*))
                                            """)
                                    .Filter("DoctorID", Supabase.Postgrest.Constants.Operator.Equals, DoctorID)
                                    .Filter("Status", Supabase.Postgrest.Constants.Operator.Equals, (int)Models.StatusAppointment.Scheduled)
                                    .Order("AppointmentDateTime", Supabase.Postgrest.Constants.Ordering.Ascending)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Patients\"", "\"tempP\"")
                         .Replace("\"Doctors\"", "\"tempD\"")
                         .Replace("\"P\"", "\"Patient\"")
                         .Replace("\"D\"", "\"Doctor\"");

        var appointments = JsonSerializer.Deserialize<List<AppointmentModel>>(content, options);

        return appointments?.FirstOrDefault();
    }
    public async Task<AppointmentModel?> GetNearestAppointmentByPatientIDAsync(string PatientID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("""
                                            *,
                                            Patient:Patients(*, User:Users(*)),
                                            Doctor:Doctors(*, User:Users(*))
                                            """)
                                    .Filter("PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                                    .Filter("Status", Supabase.Postgrest.Constants.Operator.Equals, (int)Models.StatusAppointment.Scheduled)
                                    .Order("AppointmentDateTime", Supabase.Postgrest.Constants.Ordering.Ascending)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Patients\"", "\"tempP\"")
                         .Replace("\"Doctors\"", "\"tempD\"")
                         .Replace("\"P\"", "\"Patient\"")
                         .Replace("\"D\"", "\"Doctor\"");

        var list = JsonSerializer.Deserialize<List<AppointmentModel>>(content, options);

        var appointment = list?.FirstOrDefault();

        return appointment;
    }
    public async Task<AppointmentModel?> GetAppointmentByIDAsync(string AppointmentID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("""
                                            *,
                                            Patient:Patients(*, User:Users(*)),
                                            Doctor:Doctors(*, User:Users(*))
                                            """)
                                    .Where(a => a.AppointmentID == AppointmentID)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Patients\"", "\"tempP\"")
                         .Replace("\"Doctors\"", "\"tempD\"")
                         .Replace("\"P\"", "\"Patient\"")
                         .Replace("\"D\"", "\"Doctor\"");

        var list = JsonSerializer.Deserialize<List<AppointmentModel>>(content, options);

        var appointment = list?.FirstOrDefault();

        return appointment;
    }
    public async Task<IEnumerable<AppointmentModel>> SearchByTextAsync(string SearchText)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("""
                                                *,
                                                PA:Patients(
                                                    *,
                                                    User:Users(*)
                                                ),
                                                DO:Doctors(
                                                    *,
                                                    User:Users(*)
                                                )
                                             """)
                                    .Limit(20)
                                    .Get();

        var content = response.Content!;
        content = content.Replace("\"Patients\"", "\"tempPA\"")
                         .Replace("\"PA\"", "\"Patient\"")
                         .Replace("\"Doctors\"", "\"tempDO\"")
                         .Replace("\"DO\"", "\"Doctor\"");

        var models = JsonSerializer.Deserialize<List<AppointmentModel>>(content, options);

        if (models == null)
            return [];

        SearchText = SearchText.ToLower().Trim();
        var appointments = models.Where(a =>
            a.Priority.ToString().ToLower().Contains(SearchText)
         || a.ChiefComplaint.ToLower().Contains(SearchText)
         || a.Doctor.User.FirstName.ToLower().Contains(SearchText)
         || a.Doctor.User.LastName.ToLower().Contains(SearchText)
         || a.Patient.User.LastName.ToLower().Contains(SearchText)
         || a.Patient.User.FirstName.ToLower().Contains(SearchText)
         || a.AppointmentDateTime.ToString().ToLower().Contains(SearchText)
         || SearchText.Contains(a.Patient.Age.ToString().ToLower())
            );

        return appointments;
    }
}
