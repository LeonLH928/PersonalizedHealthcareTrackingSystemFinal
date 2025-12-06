using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class PatientService : IPatientService
{
    private readonly IPatientRepository _patientRepository;
    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
    public async Task<PatientModel?> GetPatientByIDAsync(string PatientID)
    {
        return await _patientRepository.GetPatientByIDAsync(PatientID);
    }
}
