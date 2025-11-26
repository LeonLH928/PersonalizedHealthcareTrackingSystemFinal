using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.DI;
using PersonalizedHealthcareTrackingSystemFinal.Views.PatientView;
using System.Configuration;
using System.Data;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; } = null!;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ServiceCollection services = new();
            services.RegisterServices();
            ServiceProvider = services.BuildServiceProvider();

            var MainWindow = ServiceProvider.GetRequiredService<PatientMainWindow>();
            MainWindow.Show();
        }
    }

}
