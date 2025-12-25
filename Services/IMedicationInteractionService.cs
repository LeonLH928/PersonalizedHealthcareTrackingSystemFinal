using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationInteractionService
{
    Task<IEnumerable<MedicationInteractionModel>> GetAllMedicationInteractionsByMedicationIDsAsync(List<string> MedicationIDs);
}
