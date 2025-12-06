using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class MedicalRecordService : IMedicalRecordService
{
    private readonly IMedicalRecordRepository _medicalRecordRepository;
    public MedicalRecordService(IMedicalRecordRepository medicalRecordRepository)
    {
        _medicalRecordRepository = medicalRecordRepository;
    }
    public async Task AddMedicalRecordAsync(MedicalRecordModel NewRecord)
    {
        await _medicalRecordRepository.AddMedicalRecordAsync(NewRecord);
    }
    public async Task<IEnumerable<MedicalRecordModel>> GetAllMedicalRecordsByPatientIDAsync(string PatientID)
    {
        return await _medicalRecordRepository.GetAllMedicalRecordsByPatientIDAsync(PatientID);
    }
}
