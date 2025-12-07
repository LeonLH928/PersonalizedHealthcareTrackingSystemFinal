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
                                            Patient:Patients(*, User:Users(*)),
                                            Doctor:Doctors(*, User:Users(*))
                                            """)
                                    .Filter("DoctorID", Supabase.Postgrest.Constants.Operator.Equals, DoctorID)
                                    .Get();
        var appointments = JsonSerializer.Deserialize<List<AppointmentModel>>(response.Content!, options);

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
        var appointments = JsonSerializer.Deserialize<AppointmentModel>(response.Content!, options);

        return appointments;
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
                                    .Single();

        return response;
    }
}
