using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;

public interface IClinicalExaminationRepository
{
    Task AddClinicalExaminationAsync(ClinicalExaminationModel NewExam);
    Task<IEnumerable<ClinicalExaminationModel>> GetAllClinicalExaminationsByPatientIDAsync(string PatientID);
}
