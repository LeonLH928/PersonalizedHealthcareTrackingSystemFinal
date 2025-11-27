using PersonalizedHealthcareTrackingSystemFinal.ViewModels;
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

namespace PersonalizedHealthcareTrackingSystemFinal.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow(LoginWindowViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            txtVisiblePassword.Text = pwdBox.Password;

            pwdBox.Visibility = Visibility.Collapsed;
            txtVisiblePassword.Visibility = Visibility.Visible;
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            pwdBox.Password = txtVisiblePassword.Text;

            txtVisiblePassword.Visibility = Visibility.Collapsed;
            pwdBox.Visibility = Visibility.Visible;
        }

        private void txtVisiblePassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtVisiblePassword.Visibility == Visibility.Visible)
            {
                if (pwdBox.Password != txtVisiblePassword.Text)
                {
                    pwdBox.Password = txtVisiblePassword.Text;
                }
            }
        }

        private void pwdBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwdBox.Visibility == Visibility.Visible)
            {
                if (txtVisiblePassword.Text != pwdBox.Password)
                {
                    txtVisiblePassword.Text = pwdBox.Password;
                }
            }

            if (DataContext is LoginWindowViewModel vm)
            {
                vm.Password = pwdBox.Password;
            }
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }
    }
}