using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IPrescriptionRepository
{
    Task AddPrescriptionAsync(PrescriptionModel NewPrescription);
}
