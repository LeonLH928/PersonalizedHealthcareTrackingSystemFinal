using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationService
{
    Task<IEnumerable<MedicationModel>> SearchByText(string SearchText);
}
