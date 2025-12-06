using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.CodeDom;
using System.Diagnostics;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class AppointmentRepository : IAppointmentRepository
{
    public readonly Client _client;
    public AppointmentRepository(Client client)
    {
        _client = client;
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
                                    .Select("*")
                                    .Filter("DoctorID", Supabase.Postgrest.Constants.Operator.Equals, DoctorID)
                                    .Get();
        return response.Models;
    }
    public async Task<AppointmentModel?> GetNearestAppointmentByDoctorIDAsync(string DoctorID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("*")
                                    .Filter("DoctorID", Supabase.Postgrest.Constants.Operator.Equals, DoctorID)
                                    .Filter("Status", Supabase.Postgrest.Constants.Operator.Equals, (int)Models.StatusAppointment.Scheduled)
                                    .Order("AppointmentDateTime", Supabase.Postgrest.Constants.Ordering.Ascending)
                                    .Get();
        return response.Model;
    }
    public async Task<AppointmentModel?> GetAppointmentByIDAsync(string AppointmentID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("*")
                                    .Where(a => a.AppointmentID == AppointmentID)
                                    .Single();
        return response;
    }
}
