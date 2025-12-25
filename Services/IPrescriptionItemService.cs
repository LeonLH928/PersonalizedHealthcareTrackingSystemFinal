using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IPrescriptionItemService
{
    Task AddPrescriptionItemAsync(PrescriptionItemModel NewItem);
    Task<IEnumerable<PrescriptionItemModel>> GetAllPrescriptionItemsByPrescriptionIDAsync(string PrescriptionID);
    Task<IEnumerable<PrescriptionItemModel>> FilterAsNeededAsync(List<PrescriptionItemModel> items);
}
