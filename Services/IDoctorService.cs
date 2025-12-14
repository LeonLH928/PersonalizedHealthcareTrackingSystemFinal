using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IDoctorService
{
    Task<DoctorModel?> GetDoctorByUserIDAsync(string UserID);
    Task<IEnumerable<DoctorModel>> GetAllDoctorsAsync();
    Task<IEnumerable<DoctorModel>> SearchByText(string SearchText);
}
