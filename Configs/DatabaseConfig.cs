using Microsoft.EntityFrameworkCore;
using PersonalizedHealthcareTrackingSystemFinal.Data;

namespace PersonalizedHealthcareTrackingSystemFinal.Configs;

public class DatabaseConfig
{
    private readonly DataContext _dataContext;
    public DatabaseConfig(DataContext dataContext)
    {
        _dataContext = dataContext;
    }
    public DataContext DataContext => _dataContext ?? throw new Exception("Database not initialized.");
    public async Task InitializeAsync()
    {
        await _dataContext.Database.MigrateAsync();
    }
}