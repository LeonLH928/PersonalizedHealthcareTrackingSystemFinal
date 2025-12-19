using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Configs;
using PersonalizedHealthcareTrackingSystemFinal.DI;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using PersonalizedHealthcareTrackingSystemFinal.Views.PatientView;
using PersonalizedHealthcareTrackingSystemFinal.Views.PharmacistView;
using Supabase;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; } = null!;
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ServiceCollection services = new();
            services.RegisterDependency();
            ServiceProvider = services.BuildServiceProvider();

            //var IntroductionWindow = ServiceProvider.GetRequiredService<IntroductionWindow>();
            //IntroductionWindow.Show(); 
            //var LoginWindow = ServiceProvider.GetRequiredService<LoginWindow>();
            //LoginWindow.Show();
            //var PatientMainWindow = ServiceProvider.GetRequiredService<PatientMainWindow>();   
            //PatientMainWindow.Show();
            //var DoctorMainWindow = ServiceProvider.GetRequiredService<DoctorMainWindow>();
            //DoctorMainWindow.Show();
            //var PharmacistMainWindow = ServiceProvider.GetRequiredService<PharmacistMainWindow>();
            //PharmacistMainWindow.Show();
        }
    }

}