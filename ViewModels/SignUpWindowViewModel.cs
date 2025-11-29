using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OpenTK.Audio.OpenAL;
using PersonalizedHealthcareTrackingSystemFinal.Models;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using System.Text.RegularExpressions;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels
{
    public partial class SignUpWindowViewModel : ObservableObject
    {
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
        private bool _isPatientSelected = true; // Default role

        [ObservableProperty]
        private bool _isDoctorSelected = false;

        [ObservableProperty]
        private bool _isPharmacistSelected = false;

        [ObservableProperty]
        private string _errorMessage = string.Empty;

        [ObservableProperty]
        private bool _hasError = false;

        // Commands
        [RelayCommand]
        private async Task SignUp()
        {
            // Clear previous error
            HasError = false;
            ErrorMessage = string.Empty;

            // Validation
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                // Determine selected role
                UserRole selectedRole = UserRole.Patient;
                if (IsDoctorSelected)
                    selectedRole = UserRole.Doctor;
                else if (IsPharmacistSelected)
                    selectedRole = UserRole.Pharmacist;

                // Create new user model
                var newUser = new UserModel
                {
                    FirstName = FirstName.Trim(),
                    LastName = LastName.Trim(),
                    Username = Username.Trim(),
                    Email = Email.Trim(),
                    PhoneNumber = PhoneNumber.Trim(),
                    PasswordHash = Password, // Note: In production, hash this password!
                    Role = selectedRole,
                    IsActive = true
                };

                // TODO: Add database save logic here
                // Example: await _userService.CreateUserAsync(newUser);

                // Show success message
                MessageBox.Show(
                    $"Registration successful!\n\n" +
                    $"Name: {FirstName} {LastName}\n" +
                    $"Username: {Username}\n" +
                    $"Email: {Email}\n" +
                    $"Role: {selectedRole}\n\n" +
                    $"You can now log in with your credentials.",
                    "Success",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                );

                // Navigate to login (you'll need to implement this)
                // Example: NavigateToLogin();
            }
            catch (Exception ex)
            {
                HasError = true;
                ErrorMessage = $"Registration failed: {ex.Message}";
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

        // Validation Methods
        private bool ValidateInput()
        {
            // Check if all fields are filled
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

            // Validate email format
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

            // Validate phone number format (basic validation)
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

            // Validate password strength
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

            // Check if passwords match
            if (Password != ConfirmPassword)
            {
                ShowError("Passwords do not match.");
                return false;
            }

            // Check if a role is selected
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
            // Basic phone validation - accepts digits, spaces, +, -, (, )
            var phoneRegex = new Regex(@"^[\d\s\+\-\(\)]+$");
            return phoneRegex.IsMatch(phone) && phone.Replace(" ", "").Length >= 10;
        }

        private bool IsValidPassword(string password)
        {
            // Password must be at least 8 characters and contain:
            // - At least one letter
            // - At least one digit
            // - At least one special character
            var passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$");
            return passwordRegex.IsMatch(password);
        }

        private void ShowError(string message)
        {
            HasError = true;
            ErrorMessage = message;
        }

        // Navigation helper (you'll need to implement this based on your navigation strategy)
        public void NavigateToLogin(Window currentWindow)
        {
            var loginWindow = new LoginWindow(new LoginWindowViewModel());
            loginWindow.Show();
            currentWindow.Close();
        }
    }
}