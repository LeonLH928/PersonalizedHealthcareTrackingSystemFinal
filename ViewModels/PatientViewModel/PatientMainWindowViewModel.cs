using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;

public partial class PatientMainWindowViewModel : ObservableObject
{
    private readonly ICurrentUserStoreService _currentUserService;
    private readonly IServiceProvider _serviceProvider;

    public PatientMainWindowViewModel(ICurrentUserStoreService currentUserService, IServiceProvider serviceProvider)
    {
        _currentUserService = currentUserService;
        _serviceProvider = serviceProvider;
        _ = LoadDataAsync();
    }

    [ObservableProperty]
    private string _patientName = "";
    [ObservableProperty]
    private string _patientEmail = "";

    public async Task LoadDataAsync()
    {
        var currentUser = _currentUserService.GetCurrentUser();
        if (currentUser != null)
        {
            PatientName = $"{currentUser.FirstName} {currentUser.LastName}";
            PatientEmail = currentUser.Email;
        }
    }

    [RelayCommand]
    void SignOut(Window currentWindow)
    {
        var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?",
                                     "Xác nhận đăng xuất",
                                     MessageBoxButton.YesNo,
                                     MessageBoxImage.Question);

        if (result == MessageBoxResult.Yes)
        {
            try
            {
                var loginWindow = _serviceProvider.GetRequiredService<Views.LoginWindow>();
                loginWindow.Show();

                if (currentWindow != null)
                {
                    currentWindow.Close();
                }
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
