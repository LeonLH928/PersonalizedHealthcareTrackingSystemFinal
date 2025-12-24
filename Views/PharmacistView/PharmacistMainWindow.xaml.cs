using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;
using PersonalizedHealthcareTrackingSystemFinal.Views.PharmacistView;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
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
        public PharmacistMainWindow(IServiceProvider serviceProvider, PharmacistMainWindowViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
            _serviceProvider = serviceProvider;
            Loaded += (s, e) =>
            {
                Sidebar.SelectedItem = Sidebar.Items[0];
                var DashboardPage = _serviceProvider.GetRequiredService<PharmacistDashboard>();
                PharmacistMainContent.Navigate(DashboardPage);
            };

            WeakReferenceMessenger.Default.Register<PageTypeMessage>(this, (r, m) =>
            {
                var page = _serviceProvider.GetRequiredService(m.Value);
                PharmacistMainContent.Navigate(page);
                if (m.Value == typeof(PharmacistQueuePage))
                    Sidebar.SelectedItem = Sidebar.Items[1];
                else if (m.Value == typeof(InventoryManagementPage))
                    Sidebar.SelectedItem = Sidebar.Items[2];
            });
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
                case "Inventory":
                    var InventoryManagementPage = _serviceProvider.GetRequiredService<InventoryManagementPage>();
                    PharmacistMainContent.Navigate(InventoryManagementPage);
                    break;
                case "History":
                    var HistoryPage = _serviceProvider.GetRequiredService<PharmacistHistoryPage>();
                    PharmacistMainContent.Navigate(HistoryPage);
                    break;
                case "Cancelled":
                    var CancelledPage = _serviceProvider.GetRequiredService<PharmacistCancelledPage>();
                    PharmacistMainContent.Navigate(CancelledPage);
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
