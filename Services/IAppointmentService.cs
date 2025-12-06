using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IAppointmentService
{
    Task AddAppointmentAsync(AppointmentModel NewAppointment);
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID);
    Task<AppointmentModel?> GetNearestAppointmentByDoctorIDAsync(string DoctorID);
    Task<AppointmentModel?> GetAppointmentByIDAsync(string AppointmentID);
}
