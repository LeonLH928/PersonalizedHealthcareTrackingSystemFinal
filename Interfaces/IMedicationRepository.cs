using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IMedicationRepository
{
    Task<IEnumerable<MedicationModel>> SearchByText(string SearchText);
    Task<IEnumerable<MedicationModel>> GetAllMedications();
    Task<IEnumerable<MedicationModel>> GetAllMedicationsByIDs(List<string> MedicationIDs);
}
