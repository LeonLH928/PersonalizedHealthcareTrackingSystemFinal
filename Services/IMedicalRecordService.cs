using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicalRecordService
{
    Task AddMedicalRecordAsync(MedicalRecordModel NewRecord);
    Task<IEnumerable<MedicalRecordModel>> GetAllMedicalRecordsByPatientIDAsync(string PatientID);
    Task<IEnumerable<MedicalRecordModel>> SearchByTextAsync(string SearchText);
}
