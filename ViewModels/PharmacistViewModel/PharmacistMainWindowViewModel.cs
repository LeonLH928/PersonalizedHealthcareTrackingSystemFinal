using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;

public partial class PharmacistMainWindowViewModel : ObservableObject
{
    private readonly ICurrentUserStoreService _currentUserService;
    private readonly IServiceProvider _serviceProvider;

    public PharmacistMainWindowViewModel(ICurrentUserStoreService currentUserService, IServiceProvider serviceProvider)
    {
        _currentUserService = currentUserService;
        _serviceProvider = serviceProvider;

        _ = LoadDataAsync();
    }

    [ObservableProperty]
    private string _pharmacistName = "";
    [ObservableProperty]
    private string _pharmacistEmail = "";

    public async Task LoadDataAsync()
    {
        var currentUser = _currentUserService.GetCurrentUser();
        if (currentUser != null)
        {
            PharmacistName = $"{currentUser.FirstName} {currentUser.LastName}";
            PharmacistEmail = currentUser.Email;
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
