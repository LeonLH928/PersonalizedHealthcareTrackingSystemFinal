using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystem.DI;

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

            var Services = new ServiceCollection();
            Services.RegisterDependency();
            ServiceProvider = Services.BuildServiceProvider();

            var IntroductionWindow = ServiceProvider.GetRequiredService<Views.IntroductionWindow>();
            IntroductionWindow.Show();
        }
    }

}