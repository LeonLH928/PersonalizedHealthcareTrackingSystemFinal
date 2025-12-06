using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IPrescriptionService
{
    Task AddPrescriptionAsync(PrescriptionModel NewPrescription);
}
