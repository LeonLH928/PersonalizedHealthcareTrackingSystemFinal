using Supabase.Postgrest.Models;

namespace PersonalizedHealthcareTrackingSystemFinal.Interfaces;
public interface IRoleRepository<T> where T : BaseModel, new()
{
    Task AddRoleAsync(T RoleRecord);
}
