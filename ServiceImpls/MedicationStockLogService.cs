using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class MedicationStockLogService : IMedicationStockLogService
{
    private readonly IMedicationStockLogRepository _medicationStockLogRepository;
    public MedicationStockLogService(IMedicationStockLogRepository medicationStockLogRepository)
    {
        _medicationStockLogRepository = medicationStockLogRepository;
    }
    public async Task<IEnumerable<MedicationStockLogModel>> GetAllLogsAsync()
    {
        return await _medicationStockLogRepository.GetAllLogsAsync();
    }
}
