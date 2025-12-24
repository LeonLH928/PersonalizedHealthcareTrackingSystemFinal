using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
﻿using CommunityToolkit.Mvvm.Messaging;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
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
        public PatientMainWindow(IServiceProvider serviceProvider, PatientMainWindowViewModel vm)
        {
            InitializeComponent();

            DataContext = vm;

            _serviceProvider = serviceProvider;
            Loaded += (s, e) =>
            {
                Sidebar.SelectedItem = Sidebar.Items[0];
                var HomePage = _serviceProvider.GetRequiredService<PatientHomePage>();
                PatientMainContent.Navigate(HomePage);
            };
            WeakReferenceMessenger.Default.Register<PageTypeMessage>(this, (r, m) =>
            {
                var page = _serviceProvider.GetRequiredService(m.Value);
                PatientMainContent.Navigate(page);
                if (m.Value == typeof(PatientBookingPage))
                    Sidebar.SelectedItem = Sidebar.Items[1];
            });
        }

        private void NavigateToPage(string NamePage)
        {
            switch (NamePage)
            {
                case "Home":
                    var HomePage = _serviceProvider.GetRequiredService<PatientHomePage>();
                    PatientMainContent.Navigate(HomePage);
                    break;
                case "Booking":
                    var BookingPage = _serviceProvider.GetRequiredService<PatientBookingPage>();
                    PatientMainContent.Navigate(BookingPage);
                    break;
                case "Medication Schedule":
                    var MedicationSchedulePage = _serviceProvider.GetRequiredService<PatientMedicationSchedulePage>();
                    PatientMainContent.Navigate(MedicationSchedulePage);
                    break;

                case "Medical Records":
                    var MedicalRecordsPage = _serviceProvider.GetRequiredService<PatientMedicalRecordsPage>();
                    PatientMainContent.Navigate(MedicalRecordsPage);
                    break;

                case "Settings":
                    var SettingPage = _serviceProvider.GetRequiredService<PatientSetting>();
                    PatientMainContent.Navigate(SettingPage);
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
