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
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("*, Doctors(*), Patients(*)")
                                    .Filter("DoctorID", Supabase.Postgrest.Constants.Operator.Equals, DoctorID)
                                    .Get();
        return response.Models;
    }
    public async Task<AppointmentModel> GetNearestAppointmentByDoctorIDAsync(string DoctorID)
    {
        var response = await _client.From<AppointmentModel>()
                                    .Select("*, Doctors(*), Patients(*)")
                                    .Filter("DoctorID", Supabase.Postgrest.Constants.Operator.Equals, DoctorID)
                                    .Filter("Status", Supabase.Postgrest.Constants.Operator.Equals, (int)Models.StatusAppointment.Scheduled)
                                    .Order("AppointmentDateTime", Supabase.Postgrest.Constants.Ordering.Ascending)
                                    .Get();
        return response.Model ?? throw new Exception("No upcomings!");
    }
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentIDsByPatientIDAsync(string PatientID)
    {
        var response = await _client.From<AppointmentModel>()
                            .Select("AppointmentID")
                            .Filter("PatientID", Supabase.Postgrest.Constants.Operator.Equals, PatientID)
                            .Get();

        return response.Models;
    }
}
