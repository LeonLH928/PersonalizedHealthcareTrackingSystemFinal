using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;

public interface IMedicalRecordRepository
{
    Task<IEnumerable<MedicalRecordModel>> GetAllMedicalRecordsByPatientIDAsync(string PatientID);
    Task<MedicalRecordModel> GetLatestMedicalRecordByPatientIDAsync(string PatientID);
}
