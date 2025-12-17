using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationService
{
    Task<IEnumerable<MedicationModel>> SearchByText(string SearchText);
    Task<IEnumerable<MedicationModel>> GetAllMedications();
    Task<IEnumerable<MedicationModel>> GetAllMedicationsByIDs(List<string> MedicationIDs);
    Task<IEnumerable<MedicationModel>> GetAllLowStockMedications();
}
