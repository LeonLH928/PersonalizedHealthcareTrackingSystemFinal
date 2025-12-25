using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IMedicationInteractionRepository
{
    Task<IEnumerable<MedicationInteractionModel>> GetAllMedicationInteractionsByMedicationIDsAsync(List<string> MedicationIDs);
}
