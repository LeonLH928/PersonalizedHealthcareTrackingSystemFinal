using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
public class PrescriptionService : IPrescriptionService
{
    private readonly IPrescriptionRepository _prescriptionRepository;
    public PrescriptionService(IPrescriptionRepository prescriptionRepository)
    {
        _prescriptionRepository = prescriptionRepository;
    }
    public async Task AddPrescriptionAsync(PrescriptionModel NewPrescription)
    {
        await _prescriptionRepository.AddPrescriptionAsync(NewPrescription);
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllPendingPrescriptionsAsync()
    {
        return await _prescriptionRepository.GetAllPendingPrescriptionsAsync();
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllDispensingPrescriptionsAsync()
    {
        return await _prescriptionRepository.GetAllDispensingPrescriptionsAsync();
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllCompletedPrescriptionsAsync()
    {
        return await _prescriptionRepository.GetAllCompletedPrescriptionsAsync();
    }
    public async Task<IEnumerable<PrescriptionModel>> GetAllCancelledPrescriptionsAsync()
    {
        return await _prescriptionRepository.GetAllCancelledPrescriptionsAsync();
    }
}
