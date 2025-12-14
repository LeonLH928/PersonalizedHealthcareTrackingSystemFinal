using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class DoctorService : IDoctorService
{
    private readonly IDoctorRepository _doctorRepository;
    public DoctorService(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }
    public async Task<DoctorModel?> GetDoctorByUserIDAsync(string UserID)
    {
        return await _doctorRepository.GetDoctorByUserIDAsync(UserID);
    }
    public async Task<IEnumerable<DoctorModel>> GetAllDoctorsAsync()
    {
        return await _doctorRepository.GetAllDoctorsAsync();
    }
    public async Task<IEnumerable<DoctorModel>> SearchByText(string SearchText)
    {
        return await _doctorRepository.SearchByText(SearchText);
    }
}
