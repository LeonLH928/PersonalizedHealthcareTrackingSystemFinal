using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Views.PharmacistView;
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

namespace PersonalizedHealthcareTrackingSystemFinal.Views.PharmacistView
{
    /// <summary>
    /// Interaction logic for PharmacistMainWindow.xaml
    /// </summary>
    public partial class PharmacistMainWindow : Window
    {
        private readonly IServiceProvider _serviceProvider = null!;
        public PharmacistMainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            Loaded += (s, e) =>
            {
                Sidebar.SelectedItem = Sidebar.Items[0];
                var DashboardPage = _serviceProvider.GetRequiredService<PharmacistDashboard>();
                PharmacistMainContent.Navigate(DashboardPage);
            };
        }
        private void NavigateToPage(string NamePage)
        {
            switch (NamePage)
            {
                case "Dashboard":
                    var DashboardPage = _serviceProvider.GetRequiredService<PharmacistDashboard>();
                    PharmacistMainContent.Navigate(DashboardPage);
                    break;
                case "VerifyingQueue":
                    var PatientQueuePage = _serviceProvider.GetRequiredService<PharmacistQueuePage>();
                    PharmacistMainContent.Navigate(PatientQueuePage);
                    break;

                case "Inventory Management":
                    var InventoryManagementPage = _serviceProvider.GetRequiredKeyedService<InventoryManagementPage>();
                    PharmacistMainContent.Navigate(InventoryManagementPage);
                    break;
            }
        }
        private void Sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sidebar.SelectedItem is ListBoxItem lbi
                && lbi.Tag is string NamePage)
            {
                NavigateToPage(NamePage);
            }
        }
    }
}
