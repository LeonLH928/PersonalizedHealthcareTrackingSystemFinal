using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class DoctorMainWindowViewModel : ObservableObject
{
    private readonly ICurrentUserStoreService _currentUserService;

    public DoctorMainWindowViewModel(ICurrentUserStoreService currentUserService)
    {
        _currentUserService = currentUserService;
        _ = LoadDataAsync();
    }

    [ObservableProperty]
    private string _doctorName = "";
    [ObservableProperty]
    private string _doctorEmail = "";

    public async Task LoadDataAsync()
    {
        var currentUser = _currentUserService.GetCurrentUser();
        if (currentUser != null)
        {
            DoctorName = $"{currentUser.FirstName} {currentUser.LastName}";
            DoctorEmail = currentUser.Email;
        }
    }
}
