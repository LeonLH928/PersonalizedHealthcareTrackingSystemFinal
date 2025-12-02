using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using Supabase;
using System.Diagnostics;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;

public class UserRepository : IUserRepository
{
    private readonly Client _client;
    public UserRepository(Client client)
    {
        _client = client;
    }
    public async Task<UserModel> GetUserByIdAsync(string userId)
    {
        var result = await _client
                .From<UserModel>()
                .Where(x => x.UserID == userId)
                .Single();

        return result ?? throw new Exception("User not existed");
    }
    public async Task<UserModel> GetUserByUsernameAsync(string username)
    {
        var result = await _client
                .From<UserModel>()
                .Where(x => x.Username == username)
                .Single();

        return result ?? throw new Exception("User not existed");
    }
    public async Task<bool> UsernameExistsAsync(string username)
    {
        var result = await _client.From<UserModel>().Where(x => x.Username == username).Get();
        return result.Models.Count > 0;
    }
    public async Task<bool> EmailExistsAsync(string email)
    {
        var result = await _client.From<UserModel>().Where(x => x.Email == email).Get();
        return result.Models.Count > 0;
    }
    public async Task<UserModel> AddUserAsync(UserModel NewUser)
    {
        Debug.Write($"\n{NewUser.UserID}\n");
        var result = await _client.From<UserModel>().Insert(NewUser);
        return result.Models.FirstOrDefault() ?? throw new Exception("Add unsuccessfully. Please try again.");
    }
}
