using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace PersonalizedHealthcareTrackingSystemFinal.Data;
public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
                                                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                                .AddUserSecrets<DataContextFactory>()
                                                .Build();

        string dbPassword = configuration["Supabase:DbPassword"] ?? throw new InvalidOperationException("Could not find 'Supabase:DbPassword' in User Secrets. Did you run 'dotnet user-secrets set...'?");

        var builder = new NpgsqlConnectionStringBuilder("User Id=postgres.acrsnysomjcvidbbadac;Server=aws-1-ap-south-1.pooler.supabase.com;Port=5432;Database=postgres");

        builder.Password = dbPassword;

        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseNpgsql(builder.ConnectionString);

        return new DataContext(optionsBuilder.Options);
    }
}
