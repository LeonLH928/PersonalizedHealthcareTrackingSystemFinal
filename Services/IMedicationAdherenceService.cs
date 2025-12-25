using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;

public interface IMedicationAdherenceService
{
    Task<IEnumerable<MedicationAdherenceModel>> GetAllAdherencesByPatientIDAsync(string PatientID);
    Task<IEnumerable<MedicationAdherenceModel>> GetPendingAdherencesByPatientIDAsync(string PatientID);
    Task<IEnumerable<MedicationAdherenceModel>> GetMissedAdherencesByPatientIDAsync(string PatientID);
    Task<IEnumerable<MedicationAdherenceModel>> GetTodayAdherencesByPatientIDAsync(string PatientID);
    Task UpsertAdherenceAsync(MedicationAdherenceModel NewAdherence);
    Task<List<MedicationAdherenceModel>> CreateMedicationAdherenceBatchAsync(IEnumerable<PrescriptionItemModel> items);
}
