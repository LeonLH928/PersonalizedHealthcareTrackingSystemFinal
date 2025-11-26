using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels;
using PersonalizedHealthcareTrackingSystemFinal.Views;

namespace PersonalizedHealthcareTrackingSystemFinal.DI;
public static class AppModule
{
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        // Register Database
        

        // Register Data context
        

        // Register Views
        services.AddTransient<IntroductionWindow>();
        services.AddTransient<Views.PatientView.PatientMainWindow>();
        services.AddTransient<Views.PatientView.PatientBookingPage>();
        services.AddTransient<Views.PatientView.PatientHomePage>();
        services.AddTransient<Views.DoctorView.DoctorMainWindow>();
        services.AddTransient<Views.DoctorView.DoctorDashboardPage>();

        // Register ViewModels
        services.AddTransient<IntroductionWindowViewModel>();
        services.AddTransient<ViewModels.DoctorViewModel.DoctorDashboardPageViewModel>();

        // Register Repositories


        // Register Services


        return services;
    }
}