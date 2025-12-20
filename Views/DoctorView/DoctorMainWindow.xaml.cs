using LiveChartsCore.Painting;
using Microsoft.Extensions.DependencyInjection;
using System;
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

namespace PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView
{
    /// <summary>
    /// Interaction logic for DoctorMainWindow.xaml
    /// </summary>
    public partial class DoctorMainWindow : Window
    {
        private readonly IServiceProvider _serviceProvider = null!;
        public DoctorMainWindow(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            Loaded += (s, e) =>
            {
                Sidebar.SelectedItem = Sidebar.Items[0];
                var DashboardPage = _serviceProvider.GetRequiredService<DoctorDashboardPage>();
                DoctorMainContent.Navigate(DashboardPage);
            };
        }
        private void NavigateToPage(string NamePage)
        {
            switch (NamePage)
            {
                case "Dashboard":
                    var DashboardPage = _serviceProvider.GetRequiredService<DoctorDashboardPage>();
                    DoctorMainContent.Navigate(DashboardPage);
                    break;

                case "Waiting List":
                    var WaitingListPage = _serviceProvider.GetRequiredService<DoctorUpcomingsPage>();
                    DoctorMainContent.Navigate(WaitingListPage);
                    break;

                case "Examination And Prescription":
                    var ExaminationAndPrescriptionPage = _serviceProvider.GetRequiredService<DoctorExaminationAndPrescriptionPage>();
                    DoctorMainContent.Navigate(ExaminationAndPrescriptionPage);
                    break;

                case "Patient List":
                    var PatientListPage = _serviceProvider.GetRequiredService<DoctorPatientListPage>();
                    DoctorMainContent.Navigate(PatientListPage);
                    break;

                case "Work Schedule":
                    var WorkSchedulePage = _serviceProvider.GetRequiredService<DoctorWorkSchedulePage>();
                    DoctorMainContent.Navigate(WorkSchedulePage);
                    break;

                case "Pharmacy Inventory":
                    var PharmacyInventoryPage = _serviceProvider.GetRequiredService<DoctorPharmacyInventoryPage>();
                    DoctorMainContent.Navigate(PharmacyInventoryPage);
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
