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
        return medications.Where(m => m.StockTotalQuantity < 20);
    }
    public async Task<IEnumerable<MedicationModel>> GetAllZeroStockMedications()
    {
        var medications = await _medicationRepository.GetAllMedications();
        return medications.Where(m => m.StockTotalQuantity == 0);
    }
    public async Task<IEnumerable<MedicationModel>> GetAllAvailableMedications()
    {
        var medications = await _medicationRepository.GetAllMedications();
        return medications.Where(m => m.StockTotalQuantity > 20);
    }
    public async Task<IEnumerable<MedicationModel>> GetAllMedicationsByCategory(string Category)
    {
        IEnumerable<MedicationModel> resultCategory = [];
        var medications = await GetAllMedications();
        switch (Category)
        {
            case "All Categories":
                resultCategory = medications;
                break;
            case "Antibiotics":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.Antibiotic);
                break;
            case "Painkillers":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.PainReliever);
                break;
            case "Chronic Condition":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.ChronicCondition);
                break;
            case "Supplement":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.Supplement);
                break;
            case "Respiratory":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.Respiratory);
                break;
            case "Mental Health":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.MentalHealth);
                break;
            case "Allergy":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.Allergy);
                break;
            case "Other":
                resultCategory = medications.Where(m => m.Category == Models.MedicationCategory.Other);
                break;
        }
        return resultCategory;
    }
}
