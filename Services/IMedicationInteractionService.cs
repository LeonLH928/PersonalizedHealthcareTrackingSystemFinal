using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationInteractionService
{
    Task<IEnumerable<MedicationInteractionModel>> GetAllMedicationInteractionsByMedicationIDs(List<string> MedicationIDs);
}
