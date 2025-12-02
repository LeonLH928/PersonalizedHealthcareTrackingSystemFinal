using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Models;
using PersonalizedHealthcareTrackingSystemFinal.Services;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class AppointmentService : IAppointmentService
{
    public readonly IAppointmentRepository _appointmentRepository;
    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorID(string DoctorID)
    {
        return await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(DoctorID);
    }
}
