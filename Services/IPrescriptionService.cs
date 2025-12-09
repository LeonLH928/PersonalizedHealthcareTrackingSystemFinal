using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IPrescriptionService
{
    Task AddPrescriptionAsync(PrescriptionModel NewPrescription);
    Task<IEnumerable<PrescriptionModel>> GetAllPendingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllDispensingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCompletedPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCancelledPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> SearchByText(string SearchText);
}
