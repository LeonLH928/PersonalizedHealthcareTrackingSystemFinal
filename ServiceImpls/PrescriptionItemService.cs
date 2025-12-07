using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class PrescriptionItemService : IPrescriptionItemService
{
    private readonly IPrescriptionItemRepository _prescriptionItemRepository;
    public PrescriptionItemService(IPrescriptionItemRepository prescriptionItemRepository)
    {
        _prescriptionItemRepository = prescriptionItemRepository;
    }
    public async Task AddPrescriptionItemAsync(PrescriptionItemModel NewItem)
    {
        await _prescriptionItemRepository.AddPrescriptionItemAsync(NewItem);
    }
    public async Task<IEnumerable<PrescriptionItemModel>> GetAllPrescriptionItemsByPrescriptionID(string PrescriptionID)
    {
        return await _prescriptionItemRepository.GetAllPrescriptionItemsByPrescriptionID(PrescriptionID);
    }
}
