using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalizedHealthcareTrackingSystemFinal.Models;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using System;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using Supabase;
using Microsoft.Extensions.DependencyInjection;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels
{
    public partial class SignUpWindowViewModel : ObservableObject
    {
        private readonly IAuthService _authService;
        private readonly IServiceProvider _serviceProvider;
        private readonly Client _client;

        [ObservableProperty]
        private string _firstName = string.Empty;

        [ObservableProperty]
        private string _lastName = string.Empty;

        [ObservableProperty]
        private string _email = string.Empty;

        [ObservableProperty]
        private string _phoneNumber = string.Empty;

        [ObservableProperty]
        private string _username = string.Empty;

        [ObservableProperty]
        private string _password = string.Empty;

        [ObservableProperty]
        private string _confirmPassword = string.Empty;

        [ObservableProperty]
        private bool _isPatientSelected = true;

        [ObservableProperty]
        private bool _isDoctorSelected = false;

        [ObservableProperty]
        private bool _isPharmacistSelected = false;

        [ObservableProperty]
        private string _errorMessage = string.Empty;

        [ObservableProperty]
        private bool _hasError = false;

        [ObservableProperty]
        private bool _isLoading = false;

        public SignUpWindowViewModel(IAuthService authService, IServiceProvider serviceProvider, Client client)
        {
            _authService = authService;
            _serviceProvider = serviceProvider;
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
        private async Task SignUp()
        {
            HasError = false;
            ErrorMessage = string.Empty;

            if (!ValidateInput())
            {
                return;
            }

            IsLoading = true;

            try
            {
                // Determine selected role
                UserRole selectedRole = UserRole.Patient;
                if (IsDoctorSelected)
                    selectedRole = UserRole.Doctor;
                else if (IsPharmacistSelected)
                    selectedRole = UserRole.Pharmacist;

                // Sign up
                var user = await _authService.SignUpAsync(
                    Email.Trim(),
                    Password,
                    selectedRole,
                    FirstName.Trim(),
                    LastName.Trim(),
                    Username.Trim(),
                    PhoneNumber.Trim()
                );

                if (user != null)
                {
                    NavigateToLogin(Window.GetWindow(Application.Current.MainWindow));
                }
                else
                {
                    ShowError("Registration failed. Please try again.");
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

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(FirstName))
            {
                ShowError("Please enter your first name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                ShowError("Please enter your last name.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Email))
            {
                ShowError("Please enter your email address.");
                return false;
            }

            if (!IsValidEmail(Email))
            {
                ShowError("Please enter a valid email address.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                ShowError("Please enter your phone number.");
                return false;
            }

            if (!IsValidPhoneNumber(PhoneNumber))
            {
                ShowError("Please enter a valid phone number.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Username))
            {
                ShowError("Please enter a username.");
                return false;
            }

            if (Username.Length < 4)
            {
                ShowError("Username must be at least 4 characters long.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                ShowError("Please enter a password.");
                return false;
            }

            if (!IsValidPassword(Password))
            {
                ShowError("Password must be at least 8 characters long and include at least one letter, one number, and one special character.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                ShowError("Please confirm your password.");
                return false;
            }

            if (Password != ConfirmPassword)
            {
                ShowError("Passwords do not match.");
                return false;
            }

            if (!IsPatientSelected && !IsDoctorSelected && !IsPharmacistSelected)
            {
                ShowError("Please select a role.");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return emailRegex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhoneNumber(string phone)
        {
            var phoneRegex = new Regex(@"^[\d\s\+\-\(\)]+$");
            return phoneRegex.IsMatch(phone) && phone.Replace(" ", "").Length >= 10;
        }

        private bool IsValidPassword(string password)
        {
            var passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$");
            return passwordRegex.IsMatch(password);
        }

        private void ShowError(string message)
        {
            HasError = true;
            ErrorMessage = message;
        }

        public void NavigateToLogin(Window currentWindow)
        {
            try
            {
                var loginWindow = _serviceProvider.GetRequiredService<LoginWindow>();
                loginWindow.Show();
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