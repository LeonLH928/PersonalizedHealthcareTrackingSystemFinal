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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalizedHealthcareTrackingSystemFinal.Views.PatientView
{
    /// <summary>
    /// Interaction logic for PatientBookingPage.xaml
    /// </summary>
    public partial class PatientBookingPage : Page
    {
        public PatientBookingPage()
        {
            InitializeComponent();
        }

        private void TimeSlot_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag is string timeSlot)
            {
                SelectedTimeSlot.Text = timeSlot;
                ModalOverlay.Visibility = Visibility.Visible;
            }
        }

        private void CancelBooking_Click(object sender, RoutedEventArgs e)
        {
            ModalOverlay.Visibility = Visibility.Collapsed;
        }

        private void ConfirmBooking_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
                $"Đặt lịch thành công!\nThời gian: {SelectedTimeSlot.Text}",
                "Thành công",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );

            ModalOverlay.Visibility = Visibility.Collapsed;
        }
    }
}
