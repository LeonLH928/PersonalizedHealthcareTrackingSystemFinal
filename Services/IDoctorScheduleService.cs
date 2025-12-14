using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IDoctorScheduleService
{
    Task<IEnumerable<DoctorScheduleModel>> GetAllSchedulesByDoctorIDAsync(string DoctorID);
    Task<DoctorScheduleModel?> GetLatestScheduleByDoctorIDAsync(string DoctorID);
    Task<(DoctorScheduleModel? Schedule, IEnumerable<AppointmentModel> Appointments)> GetScheduleAndAppointmentsAsync(string DoctorID, DateTime PreferredDate);
}
