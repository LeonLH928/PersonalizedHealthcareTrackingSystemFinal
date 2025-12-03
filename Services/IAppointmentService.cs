using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IAppointmentService
{
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync();
    Task<AppointmentModel> GetNearestAppointmentByDoctorIDAsync();
}
