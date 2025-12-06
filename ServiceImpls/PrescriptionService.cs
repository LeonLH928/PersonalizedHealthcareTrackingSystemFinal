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
}
