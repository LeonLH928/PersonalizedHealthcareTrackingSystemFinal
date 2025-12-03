using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IAppointmentRepository
{
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID);
    Task<AppointmentModel> GetNearestAppointmentByDoctorIDAsync(string DoctorID);
}
