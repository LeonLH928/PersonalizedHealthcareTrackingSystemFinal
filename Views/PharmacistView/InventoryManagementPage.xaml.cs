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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalizedHealthcareTrackingSystemFinal.Views.PharmacistView
{
    /// <summary>
    /// Interaction logic for InventoryManagementPage.xaml
    /// </summary>
    public partial class InventoryManagementPage : Page
    {
        public InventoryManagementPage()
        {
            InitializeComponent();
        }

        private void AdjustButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && button.Tag != null)
            {
                var medication = button.Tag;
               
                SlideOverPanel.Visibility = Visibility.Visible;
                
                var slideIn = new DoubleAnimation
                {
                    From = 400,
                    To = 0,
                    Duration = TimeSpan.FromMilliseconds(300),
                    EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut }
                };
                
                SlideTransform.BeginAnimation(System.Windows.Media.TranslateTransform.XProperty, slideIn);
            }
        }

        private void ClosePanel_Click(object sender, RoutedEventArgs e)
        {
            var slideOut = new DoubleAnimation
            {
                From = 0,
                To = 400,
                Duration = TimeSpan.FromMilliseconds(300),
                EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseIn }
            };
            
            slideOut.Completed += (s, args) => SlideOverPanel.Visibility = Visibility.Collapsed;
            SlideTransform.BeginAnimation(System.Windows.Media.TranslateTransform.XProperty, slideOut);
        }

        private void SaveAdjustment_Click(object sender, RoutedEventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(QuantityInput.Text))
            {
                MessageBox.Show("Please enter a quantity.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(QuantityInput.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            
            MessageBox.Show("Stock adjustment saved successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            
            QuantityInput.Clear();
            ReasonInput.Clear();
            DocumentInput.Clear();
            RadioAdd.IsChecked = true;
            
            ClosePanel_Click(sender, e);
        }
    }
}
