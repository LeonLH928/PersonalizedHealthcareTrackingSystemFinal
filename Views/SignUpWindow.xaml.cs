using PersonalizedHealthcareTrackingSystemFinal.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PersonalizedHealthcareTrackingSystemFinal.Views
{
    public partial class SignUpWindow : Window
    {
        public SignUpWindow(SignUpWindowViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        // Password visibility toggle
        private void ShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            txtVisiblePassword.Text = pwdBox.Password;
            pwdBox.Visibility = Visibility.Collapsed;
            txtVisiblePassword.Visibility = Visibility.Visible;
            txtVisiblePassword.Focus();
        }

        private void ShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            pwdBox.Password = txtVisiblePassword.Text;
            txtVisiblePassword.Visibility = Visibility.Collapsed;
            pwdBox.Visibility = Visibility.Visible;
            pwdBox.Focus();
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

            if (DataContext is SignUpWindowViewModel vm)
            {
                vm.Password = pwdBox.Password;
            }
        }

        // Confirm Password visibility toggle
        private void ShowConfirmPassword_Checked(object sender, RoutedEventArgs e)
        {
            txtVisibleConfirmPassword.Text = pwdConfirmBox.Password;
            pwdConfirmBox.Visibility = Visibility.Collapsed;
            txtVisibleConfirmPassword.Visibility = Visibility.Visible;
            txtVisibleConfirmPassword.Focus();
        }

        private void ShowConfirmPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            pwdConfirmBox.Password = txtVisibleConfirmPassword.Text;
            txtVisibleConfirmPassword.Visibility = Visibility.Collapsed;
            pwdConfirmBox.Visibility = Visibility.Visible;
            pwdConfirmBox.Focus();
        }

        private void txtVisibleConfirmPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtVisibleConfirmPassword.Visibility == Visibility.Visible)
            {
                if (pwdConfirmBox.Password != txtVisibleConfirmPassword.Text)
                {
                    pwdConfirmBox.Password = txtVisibleConfirmPassword.Text;
                }
            }
        }

        private void pwdConfirmBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwdConfirmBox.Visibility == Visibility.Visible)
            {
                if (txtVisibleConfirmPassword.Text != pwdConfirmBox.Password)
                {
                    txtVisibleConfirmPassword.Text = pwdConfirmBox.Password;
                }
            }

            if (DataContext is SignUpWindowViewModel vm)
            {
                vm.ConfirmPassword = pwdConfirmBox.Password;
            }
        }

        // Navigate to Login
        private void LoginLink_Click(object sender, MouseButtonEventArgs e)
        {
            if (DataContext is SignUpWindowViewModel vm)
            {
                vm.NavigateToLogin(this);
            }
        }

        // Enable window dragging
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }
    }
}