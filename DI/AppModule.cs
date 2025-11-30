using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;
using PersonalizedHealthcareTrackingSystemFinal.Configs;
using PersonalizedHealthcareTrackingSystemFinal.Data;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels;
using PersonalizedHealthcareTrackingSystemFinal.Views;

namespace PersonalizedHealthcareTrackingSystemFinal.DI;
public static class AppModule
{
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        // Register Database
        services.AddSingleton<DatabaseConfig>();

        // Register Data context
        services.AddDbContext<DataContext>(options =>
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                                    .AddUserSecrets<DataContextFactory>()
                                                    .Build();

            string dbPassword = configuration["Supabase:DbPassword"] ?? throw new InvalidOperationException("Could not find 'Supabase:DbPassword' in User Secrets. Did you run 'dotnet user-secrets set...'?");

            var builder = new NpgsqlConnectionStringBuilder("User Id=postgres.acrsnysomjcvidbbadac;Server=aws-1-ap-south-1.pooler.supabase.com;Port=5432;Database=postgres");

            builder.Password = dbPassword;

            options.UseNpgsql(builder.ConnectionString);      
        });

        // Register Views
        services.AddTransient<IntroductionWindow>();
        services.AddTransient<LoginWindow>();
        services.AddTransient<Views.PatientView.PatientMainWindow>();
        services.AddTransient<Views.PatientView.PatientBookingPage>();
        services.AddTransient<Views.PatientView.PatientHomePage>();
        services.AddTransient<Views.DoctorView.DoctorMainWindow>();
        services.AddTransient<Views.DoctorView.DoctorDashboardPage>();
        services.AddTransient<Views.DoctorView.DoctorUpcomingsPage>();
        services.AddTransient<Views.DoctorView.DoctorConsultationPage>();

        // Register ViewModels
        services.AddTransient<IntroductionWindowViewModel>();
        services.AddTransient<LoginWindowViewModel>();
        services.AddTransient<ViewModels.DoctorViewModel.DoctorDashboardPageViewModel>();

        // Register Repositories


        // Register Services


        return services;
    }
}