using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationAdherenceService
{
    Task<IEnumerable<MedicationAdherenceModel>> GetAllAdherencesByPatientID(string PatientID);
    Task<IEnumerable<MedicationAdherenceModel>> GetPendingAdherencesByPatientID(string PatientID);
    Task<IEnumerable<MedicationAdherenceModel>> GetMissedAdherencesByPatientID(string PatientID);
    Task UpsertAdherence(MedicationAdherenceModel NewAdherence);
}
