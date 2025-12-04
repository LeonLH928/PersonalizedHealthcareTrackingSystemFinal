using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class MedicationInteractionService : IMedicationInteractionService
{
    private readonly IMedicationInteractionRepository _medicationInteractionRepository;
    public MedicationInteractionService(IMedicationInteractionRepository mediicationInteractionRepository)
    {
        _medicationInteractionRepository = mediicationInteractionRepository;
    }
    public async Task<IEnumerable<MedicationInteractionModel>> GetAllMedicationInteractionsByMedicationIDs(List<string> MedicationIDs)
    {
        return await _medicationInteractionRepository.GetAllMedicationInteractionsByMedicationIDs(MedicationIDs);
    }
}
