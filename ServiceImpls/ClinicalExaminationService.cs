using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class ClinicalExaminationService : IClinicalExaminationService
{
    private readonly IClinicalExaminationRepository _clinicalExaminationRepository;
    public ClinicalExaminationService(IClinicalExaminationRepository clinicalExaminationRepository)
    {
        _clinicalExaminationRepository = clinicalExaminationRepository;
    }
    public async Task<IEnumerable<ClinicalExaminationModel>> GetAllClinicalExaminationsByPatientIDAsync(string PatientID)
    {
        return await _clinicalExaminationRepository.GetAllClinicalExaminationsByPatientIDAsync(PatientID);
    }
}
