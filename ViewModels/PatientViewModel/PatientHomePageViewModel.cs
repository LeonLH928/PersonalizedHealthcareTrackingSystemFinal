using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using LiveChartsCore.Kernel;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.PatientView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
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
    private readonly IPrescriptionItemService _prescriptionItemService;
    private readonly IPrescriptionService _prescriptionService;
    private readonly ICurrentUserStoreService _currentUserService;
    private readonly IMedicalRecordService _medicalRecordService;
    public PatientHomePageViewModel(IServiceProvider serviceProvider,
                                    IAppointmentService appointmentService,
                                    ICurrentUserStoreService currentUserStoreService,
                                    IDoctorService doctorService,
                                    IPatientService patientService,
                                    IClinicalExaminationService clinicalExamination,
                                    IMedicationAdherenceService medicationAdherenceService,
                                    IPrescriptionItemService prescriptionItemService,
                                    IPrescriptionService prescriptionService,
                                    ICurrentUserStoreService currentUserService,
                                    IMedicalRecordService medicalRecordService)
    {
        _serviceProvider = serviceProvider;
        _appointmentService = appointmentService;
        _currentUserStoreService = currentUserStoreService;
        _doctorService = doctorService;
        _patientService = patientService;
        _clinicalExamination = clinicalExamination;
        _medicationAdherenceService = medicationAdherenceService;
        _prescriptionItemService = prescriptionItemService;
        _prescriptionService = prescriptionService;
        _currentUserService = currentUserService;
        _medicalRecordService = medicalRecordService;
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
    [ObservableProperty]
    private ObservableCollection<MedicalRecordModel> recentRecords = [];
    public async Task InitializeAsync()
    {
        await CreateAdherencesAsync();
        await LoadDataAsync();
    }
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
            RecentExam = (await _clinicalExamination.GetLatestClinicalExaminationByPatientIDAsync(Patient.PatientID))!;
            var LatestPrescription = await _prescriptionService.GetLatestPrescriptionByPatientIDAsync(Patient!.PatientID);
            if (LatestPrescription != null)
            {
                var LatestPrescriptionItems = await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionIDAsync(LatestPrescription.PrescriptionID);
                var LatestAdherences = await _medicationAdherenceService.GetTodayAdherencesByPatientIDAsync(Patient.PatientID);
                Debug.Write($"\nIn LatestAdherences was {LatestAdherences.Count()}\n");
                PendingMedicationAdherences = [.. LatestAdherences.Where(a => a.Status == Models.AdherenceStatus.Pending)];
                MissedMedicationAdherences = [.. LatestAdherences.Where(a => a.Status == Models.AdherenceStatus.Missed)];
            }
            RecentRecords = [.. (await _medicalRecordService.GetAllMedicalRecordsByPatientIDAsync(Patient.PatientID))
                                .OrderByDescending(r => r.Appointment.AppointmentDateTime)
                                .Take(3)];
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
            await _medicationAdherenceService.UpsertAdherenceAsync(adherence);
            MessageBox.Show($"Update successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            await LoadDataAsync();
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public async Task CreateAdherencesAsync()
    {
        IsLoading = true;
        try
        {
            var currentUser = _currentUserService.GetCurrentUser();
            var Patient = await _patientService.GetPatientByUserIDAsync(currentUser!.UserID);
            if ((await _medicationAdherenceService.GetTodayAdherencesByPatientIDAsync(Patient!.PatientID))
                                                  .Count() == 0)
            {
                var LatestPrescription = await _prescriptionService.GetLatestPrescriptionByPatientIDAsync(Patient!.PatientID);
                if (LatestPrescription != null)
                {
                    var LatestPrescriptionItems = await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionIDAsync(LatestPrescription.PrescriptionID);
                    var LatestAdherences = await _medicationAdherenceService.CreateMedicationAdherenceBatchAsync(LatestPrescriptionItems);
                    Debug.Write($"\nIn create adherences was {LatestAdherences.Count}\n");
                    foreach (var adherence in LatestAdherences)
                        await _medicationAdherenceService.UpsertAdherenceAsync(adherence);
                }
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoading = false;
        }
    }
    [RelayCommand]
    public void SeeAllButton()
    {
        WeakReferenceMessenger.Default.Send(new PageTypeMessage(typeof(PatientMedicationSchedulePage)));
    }
    [RelayCommand]
    public void SeeAllRecordsButton()
    {
        WeakReferenceMessenger.Default.Send(new PageTypeMessage(typeof(PatientMedicalRecordsPage)));
    }
}
