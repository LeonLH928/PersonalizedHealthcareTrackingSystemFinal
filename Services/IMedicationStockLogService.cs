using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IMedicationStockLogService
{
    Task<IEnumerable<MedicationStockLogModel>> GetAllLogsAsync();
}
