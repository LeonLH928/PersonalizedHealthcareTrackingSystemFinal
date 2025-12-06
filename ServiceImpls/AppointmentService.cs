using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Services;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;
    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }
    public async Task AddAppointmentAsync(AppointmentModel NewAppointment)
    {
        await _appointmentRepository.AddAppointmentAsync(NewAppointment);
    }
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID)
    {
        return await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(DoctorID);
    }
    public async Task<AppointmentModel?> GetNearestAppointmentByDoctorIDAsync(string DoctorID)
    {
        return await _appointmentRepository.GetNearestAppointmentByDoctorIDAsync(DoctorID);
    }
    public async Task<AppointmentModel?> GetAppointmentByIDAsync(string AppointmentID)
    {
        return await _appointmentRepository.GetAppointmentByIDAsync(AppointmentID);
    }
}
