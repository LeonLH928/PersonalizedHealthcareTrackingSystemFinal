using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Diagnostics;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
public partial class PatientHomePageViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppointmentService _appointmentService;
    private readonly IUserService _userService;
    private readonly ICurrentUserStoreService _currentUserStoreService;
    private readonly IDoctorService _doctorService;
    private readonly IPatientService _patientService;
    public PatientHomePageViewModel(IServiceProvider serviceProvider,
                                        IAppointmentService appointmentService,
                                        IUserService userService,
                                        ICurrentUserStoreService currentUserStoreService,
                                        IDoctorService doctorService,
                                        IPatientService patientService)
    {
        _serviceProvider = serviceProvider;
        _appointmentService = appointmentService;
        _userService = userService;
        _currentUserStoreService = currentUserStoreService;
        _doctorService = doctorService;
        _patientService = patientService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private UserModel currentUser = null!;
    [ObservableProperty]
    private AppointmentModel mostUpcomingAppointment = null!;
    [RelayCommand]
    public async Task LoadDataAsync()
    {
        CurrentUser = _currentUserStoreService.GetCurrentUser()!;
        var Patient = await _patientService.GetPatientByIDAsync();
        MostUpcomingAppointment = _appointmentService.GetNearestAppointmentByPatientIDAsync();
    }
}
