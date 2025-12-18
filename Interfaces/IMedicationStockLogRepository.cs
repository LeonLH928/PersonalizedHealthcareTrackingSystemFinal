using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IMedicationStockLogRepository
{
    Task<IEnumerable<MedicationStockLogModel>> GetAllLogsAsync();
}
