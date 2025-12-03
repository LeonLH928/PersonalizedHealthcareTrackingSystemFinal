using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IUserService
{
    Task<UserModel> GetUserByIDAsync(string UserID);
}
