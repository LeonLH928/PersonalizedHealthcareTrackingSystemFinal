using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Configs;
using PersonalizedHealthcareTrackingSystemFinal.DI;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
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
            var PharmacistQueueWindow = ServiceProvider.GetRequiredService<PharmacistMainWindow>();
            PharmacistQueueWindow.Show();
            //var PharmacistQueueWindow = ServiceProvider.GetRequiredService<DoctorConsultationWindow>();
            //PharmacistQueueWindow.Show();
            //WeakReferenceMessenger.Default.Send(new SelectedAppointmentIDMessage("appt-06"));
            //var PharmacistQueueWindow = ServiceProvider.GetRequiredService<AddDrugWindow>();
            //PharmacistQueueWindow.Show();
        }
    }

}