using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IAppointmentService
{
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorID(string DoctorID);
}
