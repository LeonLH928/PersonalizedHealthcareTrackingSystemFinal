using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IPrescriptionRepository
{
    Task AddPrescriptionAsync(PrescriptionModel NewPrescription);
    Task<IEnumerable<PrescriptionModel>> GetAllPendingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllDispensingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCompletedPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCancelledPrescriptionsAsync();
}
