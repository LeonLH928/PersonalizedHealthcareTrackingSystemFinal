using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.Views;
using Supabase.Gotrue;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels;
public partial class ForgetPasswordWindowViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IUserService _userService;
    public ForgetPasswordWindowViewModel(IServiceProvider serviceProvider,
                                         IUserService userService)
    {
        _serviceProvider = serviceProvider; 
        _userService = userService;
    }
    [ObservableProperty]
    private string input = "";
    [RelayCommand]
    public void BackToLogInButton()
    {
        if (Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault() == null)
        {
            var Popup = _serviceProvider.GetRequiredService<LoginWindow>();
            Popup.Show();
            Application.Current.Windows.OfType<ForgetPasswordWindow>().FirstOrDefault()?.Close();
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
    [RelayCommand]
    private async Task SearchUserButton()
    {
        var Users = await _userService.GetAllUsers();
        foreach (var user in Users)
            if (Input.Equals(user.Email) || Input.Equals(user.Username))
            {
                MessageBox.Show($"Here's your password: {user.PasswordHash}", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        MessageBox.Show($"Such users don't exist!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
    }
}
