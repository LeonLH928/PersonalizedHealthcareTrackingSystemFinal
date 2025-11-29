using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels
{
    public partial class LoginWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username = string.Empty;

        [ObservableProperty]
        private string _password = string.Empty;

        [RelayCommand]
        private void CloseApp(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        [RelayCommand]
        private void MinimizeApp(Window window)
        {
            if (window != null)
            {
                window.WindowState = WindowState.Minimized;
            }
        }

        public void NavigateToSignUp(Window currentWindow)
        {
            try
            {
                var signUpViewModel = new SignUpWindowViewModel();
                var signUpWindow = new Views.SignUpWindow(signUpViewModel);
                signUpWindow.Show();
                currentWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Navigation failed: {ex.Message}",
                               "Error",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
            }
        }
    }
}