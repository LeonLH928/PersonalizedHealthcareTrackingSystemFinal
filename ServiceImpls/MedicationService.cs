using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class MedicationService : IMedicationService
{
    private readonly IMedicationRepository _medicationRepository;
    public MedicationService(IMedicationRepository medicationRepository)
    {
        _medicationRepository = medicationRepository;
    }
    public async Task<IEnumerable<MedicationModel>> SearchByText(string SearchText)
    {
        return await _medicationRepository.SearchByText(SearchText);
    }
}
