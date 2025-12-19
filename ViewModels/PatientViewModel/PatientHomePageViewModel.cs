using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
public partial class PatientHomePageViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppointmentService _appointmentService;
    private readonly IUserService _userService;
    private readonly ICurrentUserStoreService _currentUserStoreService;
    private readonly IDoctorService _doctorService;
    private readonly IPatientService _patientService;
    private readonly IClinicalExaminationService _clinicalExamination;
    public PatientHomePageViewModel(IServiceProvider serviceProvider,
                                        IAppointmentService appointmentService,
                                        IUserService userService,
                                        ICurrentUserStoreService currentUserStoreService,
                                        IDoctorService doctorService,
                                        IPatientService patientService,
                                        IClinicalExaminationService clinicalExamination)
    {
        _serviceProvider = serviceProvider;
        _appointmentService = appointmentService;
        _userService = userService;
        _currentUserStoreService = currentUserStoreService;
        _doctorService = doctorService;
        _patientService = patientService;
        _clinicalExamination = clinicalExamination;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private UserModel currentUser = null!;
    [ObservableProperty]
    private AppointmentModel mostUpcomingAppointment = null!;
    [ObservableProperty]
    private ClinicalExaminationModel recentExam = null!;
    [ObservableProperty]
    private DoctorModel doctor = null!;
    [RelayCommand]
    public async Task LoadDataAsync()
    {
        try
        {
            CurrentUser = _currentUserStoreService.GetCurrentUser()!;
            var Patient = await _patientService.GetPatientByUserIDAsync(CurrentUser.UserID);
            if (Patient == null)
            {
                MessageBox.Show("This is not allowed, you know that?", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            MostUpcomingAppointment = (await _appointmentService.GetNearestAppointmentByPatientIDAsync(Patient.PatientID))!;
            Doctor = (await _doctorService.GetDoctorByUserIDAsync(MostUpcomingAppointment.Doctor.UserID))!;
            RecentExam = (await _clinicalExamination.GetLatestClinicalExaminationByPatientID(Patient.PatientID))!;
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    [RelayCommand]
    public void BookingButton()
    {

    }
}
