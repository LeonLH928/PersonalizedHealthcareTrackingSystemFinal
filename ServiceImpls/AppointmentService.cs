using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Services;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class AppointmentService : IAppointmentService
{
    private readonly ICurrentUserStoreRepository _currentUserStoreRepository;
    private readonly IAppointmentRepository _appointmentRepository;
    public AppointmentService(IAppointmentRepository appointmentRepository,
                              ICurrentUserStoreRepository currentUserStoreRepository)
    {
        _appointmentRepository = appointmentRepository;
        _currentUserStoreRepository = currentUserStoreRepository;
    }
    public async Task<IEnumerable<AppointmentModel>> GetAllAppointmentsByDoctorIDAsync()
    {
        var Doctor = await _currentUserStoreRepository.GetDoctorFromUserAsync();
        return await _appointmentRepository.GetAllAppointmentsByDoctorIDAsync(Doctor.DoctorID);
    }
    public async Task<AppointmentModel> GetNearestAppointmentByDoctorIDAsync()
    {
        var Doctor = await _currentUserStoreRepository.GetDoctorFromUserAsync();
        return await _appointmentRepository.GetNearestAppointmentByDoctorIDAsync(Doctor.DoctorID);
    }
}
