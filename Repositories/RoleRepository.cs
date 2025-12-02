using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using Supabase;
using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Repositories;
public class RoleRepository<T> : IRoleRepository<T> where T : BaseModel, new()
{
    private readonly Client _client;
    public RoleRepository(Client client)
    {
        _client = client;
    }
    public async Task AddRoleAsync(T RoleRecord)
    {
        await _client.From<T>().Insert(RoleRecord);
    }
}
