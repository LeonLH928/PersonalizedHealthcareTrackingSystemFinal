using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IPatientService
{
    Task<PatientModel?> GetPatientByIDAsync(string PatientID);
    Task<PatientModel?> GetPatientByUserIDAsync(string UserID);
}
