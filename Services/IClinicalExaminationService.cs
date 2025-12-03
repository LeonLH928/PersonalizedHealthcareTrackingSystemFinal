using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IClinicalExaminationService
{
    Task<IEnumerable<ClinicalExaminationModel>> GetAllClinicalExaminationsByPatientIDAsync(string PatientID);
}
