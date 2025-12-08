using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IClinicalExaminationService
{
    Task AddClinicalExaminationAsync(ClinicalExaminationModel NewExam);
    Task<ClinicalExaminationModel?> GetLatestClinicalExaminationByPatientID(string PatientID);
    Task<IEnumerable<ClinicalExaminationModel>> GetClinicalExaminationsByPatientID(string PatientID);
    Task<ClinicalExaminationModel?> GetClinicalExaminationByMedicalRecordIDAsync(string RecordID);
}
