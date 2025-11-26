using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Views.PatientView;

namespace PersonalizedHealthcareTrackingSystemFinal.DI;
public static class AppModule 
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        // Register Views
        services.AddTransient<PatientMainWindow>();
        services.AddTransient<PatientBookingPage>();
        services.AddTransient<PatientHomePage>();

        return services;
    }
}
