
using PersonalizedHealthcareTrackingSystemFinal.Models;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.Services;
public interface IAuthService
{
    Task<SupabaseModels.UserModel> SignInAsync(string usernameOrEmail, string password);
    Task<SupabaseModels.UserModel> SignUpAsync(string email, string password, UserRole role, string firstName, string lastName, string username, string phoneNumber);
    void SignOut();
}
