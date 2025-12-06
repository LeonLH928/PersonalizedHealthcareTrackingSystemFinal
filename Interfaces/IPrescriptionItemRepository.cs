using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IPrescriptionItemRepository
{
    Task AddPrescriptionItemAsync(PrescriptionItemModel NewItem);
}
