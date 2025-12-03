using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface ICurrentUserStoreRepository
{
    UserModel CurrentUser { get; }
    Task SetUser(UserModel user);
    Task ClearUser();
    bool IsLoggedIn => CurrentUser != null;
    Task<DoctorModel> GetDoctorFromUserAsync();
    Task<PatientModel> GetPatientFromUserAsync();
    Task<PharmacistModel> GetPharmacistFromUserAsync();
}
