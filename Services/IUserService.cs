using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IUserService
{
    Task<IEnumerable<UserModel>> GetAllUsers();
    Task<UserModel> GetUserByIDAsync(string UserID);
}
