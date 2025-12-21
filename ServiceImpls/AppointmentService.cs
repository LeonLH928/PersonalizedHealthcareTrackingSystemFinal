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
    public async Task<AppointmentModel?> GetNearestAppointmentByPatientIDAsync(string PatientID)
    {
        return await _appointmentRepository.GetNearestAppointmentByPatientIDAsync(PatientID);
    }
    public async Task<AppointmentModel?> GetAppointmentByIDAsync(string AppointmentID)
    {
        return await _appointmentRepository.GetAppointmentByIDAsync(AppointmentID);
    }
    public async Task<IEnumerable<AppointmentModel>> GetHappeningAppointmentByDoctorIDAsync(string DoctorID)
    {
        var Appointments = await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(DoctorID);
        return Appointments.Where(a => a.Status == Models.StatusAppointment.Happening);
    }
    public async Task<IEnumerable<AppointmentModel>> GetUpcomingAppointmentsByDoctorIDAsync(string DoctorID)
    {
        var Appointments = await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(DoctorID);
        return Appointments.Where(a => a.Status == Models.StatusAppointment.Scheduled);
    }
    public async Task<IEnumerable<AppointmentModel>> GetCompletedAppointmentsByDoctorIDAsync(string DoctorID)
    {
        var Appointments = await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(DoctorID);
        return Appointments.Where(a => a.Status == Models.StatusAppointment.Completed);
    }
    public async Task<IEnumerable<AppointmentModel>> GetCancelledAppointmentsByDoctorIDAsync(string DoctorID)
    {
        var Appointments = await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(DoctorID);
        return Appointments.Where(a => a.Status == Models.StatusAppointment.Cancelled);
    }
    public async Task<IEnumerable<AppointmentModel>> GetNotShowUpAppointmentsByDoctorIDAsync(string DoctorID)
    {
        var Appointments = await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(DoctorID);
        return Appointments.Where(a => a.Status == Models.StatusAppointment.No_show);
    }
    public async Task<IEnumerable<AppointmentModel>> SearchByText(string SearchText)
    {
        return await _appointmentRepository.SearchByText(SearchText);
    }
}
