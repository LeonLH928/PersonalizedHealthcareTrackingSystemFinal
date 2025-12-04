using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IClinicalExaminationService
{
    Task<ClinicalExaminationModel> GetLatestClinicalExaminationByPatientID(string PatientID);
    Task<IEnumerable<ClinicalExaminationModel>> GetClinicalExaminationsByPatientID(string PatientID);
}
