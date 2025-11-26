using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.DI;
using PersonalizedHealthcareTrackingSystemFinal.Views;
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
        public IServiceProvider ServiceProvider { get; private set; } = null!;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ServiceCollection services = new();
            services.RegisterDependency();
            ServiceProvider = services.BuildServiceProvider();

            var IntroductionWindow = ServiceProvider.GetRequiredService<IntroductionWindow>();
            IntroductionWindow.Show();
        }
    }

}