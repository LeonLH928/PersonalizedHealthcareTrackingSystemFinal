using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;

public interface IClinicalExaminationRepository
{
    Task AddClinicalExaminationAsync(ClinicalExaminationModel NewExam);
    Task<ClinicalExaminationModel?> GetClinicalExaminationByMedicalRecordIDAsync(string RecordID);
    Task<IEnumerable<ClinicalExaminationModel>> GetAllClinicalExaminationsByMedicalRecordIDsAsync(List<string> MedicalRecordIDs);
}
