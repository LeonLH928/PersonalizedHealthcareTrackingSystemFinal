using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class MedicationAdherenceService : IMedicationAdherenceService
{
    private readonly IMedicationAdherenceRepository _medicationAdherenceRepository;
    public MedicationAdherenceService(IMedicationAdherenceRepository medicationAdherenceRepository)
    {
        _medicationAdherenceRepository = medicationAdherenceRepository;
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetAllAdherencesByPatientID(string PatientID)
    {
        return await _medicationAdherenceRepository.GetAllAdherencesByPatientID(PatientID);
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetPendingAdherencesByPatientID(string PatientID)
    {
        return await _medicationAdherenceRepository.GetPendingAdherencesByPatientID(PatientID);
    }
    public async Task<IEnumerable<MedicationAdherenceModel>> GetMissedAdherencesByPatientID(string PatientID)
    {
        return await _medicationAdherenceRepository.GetMissedAdherencesByPatientID(PatientID);
    }
    public async Task UpsertAdherence(MedicationAdherenceModel NewAdherence)
    {
        await _medicationAdherenceRepository.UpsertAdherence(NewAdherence);
    }
}
