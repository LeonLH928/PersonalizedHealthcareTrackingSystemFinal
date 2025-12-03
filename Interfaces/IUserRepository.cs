using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IUserRepository
{
    Task<UserModel> GetUserByIDAsync(string userId);
    Task<UserModel> GetUserByUsernameAsync(string username);
    Task<bool> UsernameExistsAsync(string username);
    Task<bool> EmailExistsAsync(string email);
    Task<UserModel> AddUserAsync(UserModel NewUser);
}
