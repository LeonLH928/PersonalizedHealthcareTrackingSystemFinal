using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class ClinicalExaminationService : IClinicalExaminationService
{
    private readonly IClinicalExaminationRepository _clinicalExaminationRepository;
    private readonly IMedicalRecordRepository _medicalRecordRepository;
    public ClinicalExaminationService(IClinicalExaminationRepository clinicalExaminationRepository,
                                      IMedicalRecordRepository medicalRecordRepository)
    {
        _clinicalExaminationRepository = clinicalExaminationRepository;
        _medicalRecordRepository = medicalRecordRepository;
    }
    public async Task<ClinicalExaminationModel> GetLatestClinicalExaminationByPatientID(string PatientID)
    {
        var LatestRecord = await _medicalRecordRepository.GetLatestMedicalRecordByPatientIDAsync(PatientID);
        return await _clinicalExaminationRepository.GetClinicalExaminationByMedicalRecordIDAsync(LatestRecord.RecordID);
    }
    public async Task<IEnumerable<ClinicalExaminationModel>> GetClinicalExaminationsByPatientID(string PatientID)
    {
        var Records = await _medicalRecordRepository.GetAllMedicalRecordsByPatientIDAsync(PatientID);
        var RecordsList = Records.Select(r => r.RecordID).ToList();
        return await _clinicalExaminationRepository.GetAllClinicalExaminationsByMedicalRecordIDsAsync(RecordsList);
    }
}
