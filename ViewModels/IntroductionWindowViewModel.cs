using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using System.Windows;
using System.Windows.Threading;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels
{
    public partial class IntroductionWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _loadingText = "LOADING ...";

        [ObservableProperty]
        private double _progress = 0;

        private readonly DispatcherTimer _timer;
        private readonly IServiceProvider _serviceProvider;

        public IntroductionWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(30)
            };
            _timer.Tick += Timer_Tick;

            _timer.Start();
        }

        private async void Timer_Tick(object? sender, EventArgs e)
        {
            Progress += 1;

            LoadingText = Progress switch
            {
                < 30 => "LOADING ...",
                < 60 => "INITIALIZING SYSTEM ...",
                < 90 => "PREPARING INTERFACE ...",
                _ => "ALMOST READY ..."
            };

            if (Progress >= 100)
            {
                _timer.Stop();
                await Task.Delay(500);

                var loginWindow = _serviceProvider.GetRequiredService<LoginWindow>();
                loginWindow.Show();

                CloseWindow();
            }
        }
        public void CloseWindow()
        {
            Application.Current.Windows.OfType<IntroductionWindow>()
                .FirstOrDefault()?
                .Close();
        }
    }
}