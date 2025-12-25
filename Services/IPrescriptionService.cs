using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Windows.Markup;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IPrescriptionService
{
    Task AddPrescriptionAsync(PrescriptionModel NewPrescription);
    Task<IEnumerable<PrescriptionModel>> GetAllPendingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllDispensingPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCompletedPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllCancelledPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllPrescriptionsAsync();
    Task<IEnumerable<PrescriptionModel>> GetAllPrescriptionsByPatientIDAsync(string PatientID);
    Task<IEnumerable<PrescriptionModel>> SearchByText(string SearchText);
    Task<PrescriptionModel?> GetLatestPrescriptionByPatientIDAsync(string PatientID);
}
