using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.PatientView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
public partial class PatientHomePageViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppointmentService _appointmentService;
    private readonly ICurrentUserStoreService _currentUserStoreService;
    private readonly IDoctorService _doctorService;
    private readonly IPatientService _patientService;
    private readonly IClinicalExaminationService _clinicalExamination;
    private readonly IMedicationAdherenceService _medicationAdherenceService;
    public PatientHomePageViewModel(IServiceProvider serviceProvider,
                                    IAppointmentService appointmentService,
                                    ICurrentUserStoreService currentUserStoreService,
                                    IDoctorService doctorService,
                                    IPatientService patientService,
                                    IClinicalExaminationService clinicalExamination,
                                    IMedicationAdherenceService medicationAdherenceService)
    {
        _serviceProvider = serviceProvider;
        _appointmentService = appointmentService;
        _currentUserStoreService = currentUserStoreService;
        _doctorService = doctorService;
        _patientService = patientService;
        _clinicalExamination = clinicalExamination;
        _medicationAdherenceService = medicationAdherenceService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private UserModel currentUser = null!;
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private AppointmentModel mostUpcomingAppointment = null!;
    [ObservableProperty]
    private ClinicalExaminationModel recentExam = null!;
    [ObservableProperty]
    private DoctorModel doctor = null!;
    [ObservableProperty]
    private ObservableCollection<MedicationAdherenceModel> pendingMedicationAdherences = [];
    [ObservableProperty]
    private ObservableCollection<MedicationAdherenceModel> missedMedicationAdherences = [];
    [ObservableProperty]
    private bool isPendingEmpty = false; 
    [ObservableProperty]
    private bool isMissedEmpty = false;
    [RelayCommand]
    public async Task LoadDataAsync()
    {
        IsLoading = true;
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
            PendingMedicationAdherences = [.. await _medicationAdherenceService.GetPendingAdherencesByPatientID(Patient.PatientID)];
            MissedMedicationAdherences = [.. await _medicationAdherenceService.GetMissedAdherencesByPatientID(Patient.PatientID)];
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoading = false;
        }
    }
    partial void OnPendingMedicationAdherencesChanged(ObservableCollection<MedicationAdherenceModel> value)
    {
        IsPendingEmpty = PendingMedicationAdherences.Count == 0;
    }
    partial void OnMissedMedicationAdherencesChanged(ObservableCollection<MedicationAdherenceModel> value)
    {
        IsMissedEmpty = MissedMedicationAdherences.Count == 0;
    }
    [RelayCommand]
    public void BookingButton()
    {
        WeakReferenceMessenger.Default.Send(new PageTypeMessage(typeof(PatientBookingPage)));
    }
    [RelayCommand]
    public async Task TakeMedicineButton(MedicationAdherenceModel adherence)
    {
        try
        {
            adherence.Status = Models.AdherenceStatus.Taken;
            adherence.TakenDateTime = DateTime.UtcNow;
            await _medicationAdherenceService.UpsertAdherence(adherence);
            MessageBox.Show($"Update successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            await LoadDataAsync();
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
