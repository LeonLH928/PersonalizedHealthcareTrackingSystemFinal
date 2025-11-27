using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels;
using PersonalizedHealthcareTrackingSystemFinal.Views;

namespace PersonalizedHealthcareTrackingSystem.DI;

public static class AppModule
{
    public static IServiceCollection RegisterDependency(this IServiceCollection services)
    {
        // Register Database
 

        // Register Data context
 
        
        // Register Views
        services.AddTransient<IntroductionWindow>();
        services.AddTransient<LoginWindow>();


        // Register ViewModels
        services.AddTransient<IntroductionWindowViewModel>();
        services.AddTransient<LoginWindowViewModel>();


        // Register Repositories


        // Register Services


        return services;
    }
}