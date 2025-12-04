using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IMedicationRepository
{
    Task<IEnumerable<MedicationModel>> SearchByText(string SearchText);
}
