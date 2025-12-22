using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationService
{
    Task<IEnumerable<MedicationModel>> SearchByText(string SearchText);
    Task<IEnumerable<MedicationModel>> GetAllMedications();
    Task<IEnumerable<MedicationModel>> GetAllMedicationsByIDs(List<string> MedicationIDs);
    Task<IEnumerable<MedicationModel>> GetAllLowStockMedications();
    Task<IEnumerable<MedicationModel>> GetAllZeroStockMedications();
    Task<IEnumerable<MedicationModel>> GetAllAvailableMedications();
    Task<IEnumerable<MedicationModel>> GetAllMedicationsByCategory(string Category);
}
