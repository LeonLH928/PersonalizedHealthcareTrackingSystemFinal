using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IAppointmentService
{
    Task UpsertAppointmentAsync(AppointmentModel NewAppointment);
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID);
    Task<IEnumerable<AppointmentModel>> GetHappeningAppointmentByDoctorIDAsync(string DoctorID);
    Task<IEnumerable<AppointmentModel>> GetUpcomingAppointmentsByDoctorIDAsync(string DoctorID);
    Task<IEnumerable<AppointmentModel>> GetCompletedAppointmentsByDoctorIDAsync(string DoctorID);
    Task<IEnumerable<AppointmentModel>> GetCancelledAppointmentsByDoctorIDAsync(string DoctorID);
    Task<IEnumerable<AppointmentModel>> GetNotShowUpAppointmentsByDoctorIDAsync(string DoctorID);
    Task<AppointmentModel?> GetNearestAppointmentByDoctorIDAsync(string DoctorID);
    Task<AppointmentModel?> GetNearestAppointmentByPatientIDAsync(string PatientID);
    Task<AppointmentModel?> GetAppointmentByIDAsync(string AppointmentID);
    Task<IEnumerable<AppointmentModel>> SearchByTextAsync(string SearchText);
    Task<IEnumerable<AppointmentModel>> GetAppointmentsSortByLatestAsync(string DoctorID);
    Task<IEnumerable<AppointmentModel>> GetAppointmentsSortByNameAZAsync(string DoctorID);
}
