using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IPrescriptionItemService
{
    Task AddPrescriptionItemAsync(PrescriptionItemModel NewItem);
    Task<IEnumerable<PrescriptionItemModel>> GetAllPrescriptionItemsByPrescriptionID(string PrescriptionID);
    Task<IEnumerable<PrescriptionItemModel>> FilterAsNeeded(List<PrescriptionItemModel> items);
}
