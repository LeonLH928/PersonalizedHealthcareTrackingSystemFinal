using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IPatientRepository
{
    Task<PatientModel?> GetPatientByIDAsync(string PatientID);
    Task<PatientModel?> GetPatientByUserIDAsync(string UserID);
}
