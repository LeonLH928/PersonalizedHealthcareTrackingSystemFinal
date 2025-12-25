using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;

public partial class PharmacistMainWindowViewModel : ObservableObject
{
    private readonly ICurrentUserStoreService _currentUserService;

    public PharmacistMainWindowViewModel(ICurrentUserStoreService currentUserService)
    {
        _currentUserService = currentUserService;

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
}
