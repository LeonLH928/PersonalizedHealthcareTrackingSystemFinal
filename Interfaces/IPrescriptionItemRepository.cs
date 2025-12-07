using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IPrescriptionItemRepository
{
    Task AddPrescriptionItemAsync(PrescriptionItemModel NewItem);
    Task<IEnumerable<PrescriptionItemModel>> GetAllPrescriptionItemsByPrescriptionID(string PrescriptionID);
}
