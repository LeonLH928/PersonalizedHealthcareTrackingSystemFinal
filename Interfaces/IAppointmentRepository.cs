using PersonalizedHealthcareTrackingSystemFinal.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IAppointmentRepository
{
    Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync(string DoctorID);
}
