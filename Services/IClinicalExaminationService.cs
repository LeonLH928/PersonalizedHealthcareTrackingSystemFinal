using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IClinicalExaminationService
{
    Task AddClinicalExaminationAsync(ClinicalExaminationModel NewExam);
    Task<ClinicalExaminationModel?> GetLatestClinicalExaminationByPatientIDAsync(string PatientID);
    Task<IEnumerable<ClinicalExaminationModel>> GetClinicalExaminationsByPatientIDAsync(string PatientID);
    Task<ClinicalExaminationModel?> GetClinicalExaminationByMedicalRecordIDAsync(string RecordID);
}
