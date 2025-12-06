using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;

public interface IMedicalRecordRepository
{
    Task AddMedicalRecordAsync(MedicalRecordModel NewRecord);
    Task<IEnumerable<MedicalRecordModel>> GetAllMedicalRecordsByPatientIDAsync(string PatientID);
    Task<MedicalRecordModel?> GetLatestMedicalRecordByPatientIDAsync(string PatientID);
}
