using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IDoctorRepository
{
    Task<DoctorModel?> GetDoctorByUserIDAsync(string UserID);
    Task<IEnumerable<DoctorModel>> GetAllDoctorsAsync();
    Task<IEnumerable<DoctorModel>> SearchByText(string SearchText);
}
