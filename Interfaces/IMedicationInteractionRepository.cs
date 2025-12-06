using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IMedicationInteractionRepository
{
    Task<IEnumerable<MedicationInteractionModel>> GetAllMedicationInteractionsByMedicationIDs(List<string> MedicationIDs);
}
