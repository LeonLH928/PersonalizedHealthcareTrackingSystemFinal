using PersonalizedHealthcareTrackingSystemFinal.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        // Navigate to Sign Up
        private void SignUpLink_Click(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is LoginWindowViewModel vm)
            {
                vm.NavigateToSignUp(this);
            }
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }
    }
}