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
    public async Task<IEnumerable<MedicationModel>> GetAllMedications()
    {
        return await _medicationRepository.GetAllMedications();
    }
    public async Task<IEnumerable<MedicationModel>> GetAllMedicationsByIDs(List<string> MedicationIDs)
    {
        return await _medicationRepository.GetAllMedicationsByIDs(MedicationIDs);
    }
    public async Task<IEnumerable<MedicationModel>> GetAllLowStockMedications()
    {
        var medications = await _medicationRepository.GetAllMedications();
        return medications.Where(m => m.StockTotalQuantity < 50).ToList();
    }
}
