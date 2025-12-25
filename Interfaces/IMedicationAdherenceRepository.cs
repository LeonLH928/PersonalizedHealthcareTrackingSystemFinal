using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IMedicationAdherenceRepository
{
    Task<IEnumerable<MedicationAdherenceModel>> GetAllAdherencesByPatientIDAsync(string PatientID);
    Task<IEnumerable<MedicationAdherenceModel>> GetPendingAdherencesByPatientIDAsync(string PatientID);
    Task<IEnumerable<MedicationAdherenceModel>> GetMissedAdherencesByPatientIDAsync(string PatientID);
    Task UpsertAdherenceAsync(MedicationAdherenceModel NewAdherence);
}
