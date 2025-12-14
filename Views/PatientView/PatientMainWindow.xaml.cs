using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PersonalizedHealthcareTrackingSystemFinal.Views.PatientView
{
    /// <summary>
    /// Interaction logic for PatientMainWindow.xaml
    /// </summary>
    public partial class PatientMainWindow : Window
    {
        private readonly IServiceProvider _serviceProvider;
        public PatientMainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            Loaded += (s, e) =>
            {
                Sidebar.SelectedItem = Sidebar.Items[0];
                var HomePage = _serviceProvider.GetRequiredService<PatientHomePage>();
                MainContent.Navigate(HomePage);
            };
        }

        private void NavigateToPage(string NamePage)
        {
            switch (NamePage)
            {
                case "Home":
                    var HomePage = _serviceProvider.GetRequiredService<PatientHomePage>();
                    MainContent.Navigate(HomePage);
                    break;
                case "Booking":
                    var BookingPage = _serviceProvider.GetRequiredService<PatientBookingPage>();
                    MainContent.Navigate(BookingPage);
                    break;
                case "Settings":
                    var SettingPage = _serviceProvider.GetRequiredService<PatientSetting>();
                    MainContent.Navigate(SettingPage);
                    break;
            }
        }
        private void Sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sidebar.SelectedItem is ListBoxItem lbi
                && lbi.Tag is string NamePage)
                NavigateToPage(NamePage);
        }
    }
}
