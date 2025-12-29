using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IPrescriptionRepository
{
    Task UpsertPrescriptionAsync(PrescriptionModel NewPrescription);
    Task<IEnumerable<PrescriptionModel>> GetAllPendingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllDispensingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCompletedPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCancelledPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllPrescriptionsByPatientIDAsync(string PatientID);
    Task<IEnumerable<PrescriptionModel>> SearchByTextAsync(string SearchText);
    Task<PrescriptionModel> GetPrescriptionByMedicalRecordIDAsync(string RecordID);
}
