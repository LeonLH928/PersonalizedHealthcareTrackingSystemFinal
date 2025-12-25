using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationService
{
    Task<IEnumerable<MedicationModel>> SearchByTextAsync(string SearchText);
    Task<IEnumerable<MedicationModel>> GetAllMedicationsAsync();
    Task<IEnumerable<MedicationModel>> GetAllMedicationsByIDsAsync(List<string> MedicationIDs);
    Task<IEnumerable<MedicationModel>> GetAllLowStockMedicationsAsync();
    Task<IEnumerable<MedicationModel>> GetAllZeroStockMedicationsAsync();
    Task<IEnumerable<MedicationModel>> GetAllAvailableMedicationsAsync();
    Task<IEnumerable<MedicationModel>> GetAllMedicationsByCategoryAsync(string Category);
}
