using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.Services;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;

public partial class PatientMainWindowViewModel : ObservableObject
{
    private readonly ICurrentUserStoreService _currentUserService;

    public PatientMainWindowViewModel(ICurrentUserStoreService currentUserService)
    {
        _currentUserService = currentUserService;
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
}
