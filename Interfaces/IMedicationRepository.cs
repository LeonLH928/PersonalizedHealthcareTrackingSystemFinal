using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IMedicationRepository
{
    Task<IEnumerable<MedicationModel>> SearchByTextAsync(string SearchText);
    Task<IEnumerable<MedicationModel>> GetAllMedicationsAsync();
    Task<IEnumerable<MedicationModel>> GetAllMedicationsByIDsAsync(List<string> MedicationIDs);
    Task UpsertMedication(MedicationModel NewMedication);
}
