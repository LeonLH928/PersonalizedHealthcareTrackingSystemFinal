using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IDoctorScheduleRepository
{
    Task<IEnumerable<DoctorScheduleModel>> GetAllSchedulesByDoctorIDAsync(string DoctorID);
    Task<DoctorScheduleModel?> GetLatestScheduleByDoctorIDAsync(string DoctorID);
}
