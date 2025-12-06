using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IDoctorRepository
{
    Task<DoctorModel?> GetDoctorByUserIDAsync(string UserID);
}
