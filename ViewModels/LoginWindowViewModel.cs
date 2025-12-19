using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using Supabase;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels
{
    public partial class LoginWindowViewModel : ObservableObject
    {
        private readonly IAuthService _authService;
        private readonly Client _client;
        private readonly IServiceProvider _serviceProvider;

        [ObservableProperty]
        private string _username = string.Empty;

        [ObservableProperty]
        private string _password = string.Empty;

        [ObservableProperty]
        private string _errorMessage = string.Empty;

        [ObservableProperty]
        private bool _hasError = false;

        [ObservableProperty]
        private bool _isLoading = false;

        public LoginWindowViewModel(IServiceProvider serviceProvider, IAuthService authService, Client client)
        {
            _serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
            _authService = authService;
            _client = client;
            InitializeSupabase();
        }
        private async void InitializeSupabase()
        {
            try
            {
                await _client.InitializeAsync();
            }
            catch (Exception ex)
            {
                ShowError($"Failed to initialize: {ex.Message}");
            }
        }


        [RelayCommand]
        private async Task Login()
        {
            // Clear previous errors
            HasError = false;
            ErrorMessage = string.Empty;

            // Validation
            if (string.IsNullOrWhiteSpace(Username))
            {
                ShowError("Please enter your username or email.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                ShowError("Please enter your password.");
                return;
            }

            IsLoading = true;

            try
            {
                // Sign in
                var user = await _authService.SignInAsync(Username.Trim(), Password);

                if (user != null)
                {
                    if (user.Role == Models.UserRole.Patient)
                    {
                        NavigateToPatientHomePage();
                    }
                    else if (user.Role == Models.UserRole.Doctor)
                    {
                        NavigateToDoctorMainWindow();
                    }
                    else if (user.Role == Models.UserRole.Pharmacist)
                    {
                        NavigateToPharmacistMainWindow(); 
                    }
                    else
                    {
                        ShowError("Unknown user role.");
                    }
                }
                else
                {
                    ShowError("Login failed. Please check your credentials.");
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
            finally
            {
                IsLoading = false;
            }
        }

        private void NavigateToPatientHomePage()
        {
            try
            {
                var PatientMainWindow = _serviceProvider.GetRequiredService<Views.PatientView.PatientMainWindow>();
                PatientMainWindow.Show();
                Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault()?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Navigation failed: {ex.Message}",
                               "Error",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
            }
        }

        private void NavigateToDoctorMainWindow()
        {
            try
            {
                var doctorMainWindow = _serviceProvider.GetRequiredService<Views.DoctorView.DoctorMainWindow>();
                doctorMainWindow.Show();
                Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault()?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Navigation failed: {ex.Message}",
                               "Error",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
            }
        }

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

        private void NavigateToPharmacistMainWindow()
        {
            try
            {
                var pharmacistMainWindow = _serviceProvider.GetRequiredService<Views.PharmacistView.PharmacistMainWindow>();
                pharmacistMainWindow.Show();
                Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault()?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Navigation failed: {ex.Message}",
                               "Error",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
            }
        }

        public void NavigateToSignUp(Window currentWindow)
        {
            try
            {
                var signUpWindow = _serviceProvider.GetRequiredService<SignUpWindow>();
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

        private void ShowError(string message)
        {
            HasError = true;
            ErrorMessage = message;
        }
    }
}