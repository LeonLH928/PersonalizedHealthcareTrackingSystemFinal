using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IDoctorService
{
    Task<DoctorModel?> GetDoctorByUserIDAsync(string UserID);
}
