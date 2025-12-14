 using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class DoctorScheduleService : IDoctorScheduleService
{
    private readonly IDoctorScheduleRepository _doctorScheduleRepository;
    private readonly IAppointmentRepository _appointmentRepository;
    public DoctorScheduleService(IDoctorScheduleRepository doctorScheduleRepository,
                                 IAppointmentRepository appointmentRepository)
    {
        _doctorScheduleRepository = doctorScheduleRepository;
        _appointmentRepository = appointmentRepository;
    }
    public async Task<IEnumerable<DoctorScheduleModel>> GetAllSchedulesByDoctorIDAsync(string DoctorID)
    {
        return await _doctorScheduleRepository.GetAllSchedulesByDoctorIDAsync(DoctorID);
    }
    public async Task<DoctorScheduleModel?> GetLatestScheduleByDoctorIDAsync(string DoctorID)
    {
        return await _doctorScheduleRepository.GetLatestScheduleByDoctorIDAsync(DoctorID);
    }
    public async Task<(DoctorScheduleModel? Schedule, IEnumerable<AppointmentModel> Appointments)> GetScheduleAndAppointmentsAsync(string DoctorID, DateTime PreferredDate)
    {
        var schedule = await _doctorScheduleRepository.GetLatestScheduleByDoctorIDAsync(DoctorID);
        var appointments = await _appointmentRepository.GetAllAppointmentsByDatetimeAndDoctorIDAsync(PreferredDate, DoctorID);

        return (schedule, appointments);
    }
}
