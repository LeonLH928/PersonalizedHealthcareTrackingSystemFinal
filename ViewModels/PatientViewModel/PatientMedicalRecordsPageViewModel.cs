using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore.Painting;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel.Wrappers;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
public partial class PatientMedicalRecordsPageViewModel : ObservableObject
{
    private readonly IClinicalExaminationService _clinicalExaminationService;
    private readonly ICurrentUserStoreService _currentUserService;
    private readonly IPatientService _patientService;
    private readonly IMedicalRecordService _medicalRecordService;
    private readonly IPrescriptionService _prescriptionService;
    private readonly IPrescriptionItemService _prescriptionItemService;
    public PatientMedicalRecordsPageViewModel(IClinicalExaminationService clinicalExaminationService,
                                              ICurrentUserStoreService currentUserService,
                                              IPatientService patientService,
                                              IMedicalRecordService medicalRecordService,
                                              IPrescriptionService prescriptionService,
                                              IPrescriptionItemService prescriptionItemService)
    {
        _clinicalExaminationService = clinicalExaminationService;
        _currentUserService = currentUserService;
        _patientService = patientService;
        _medicalRecordService = medicalRecordService;
        _prescriptionService = prescriptionService;
        _prescriptionItemService = prescriptionItemService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private ClinicalExaminationModel nearestExam = null!;
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private ObservableCollection<string> allergies = [];
    [ObservableProperty]
    private ObservableCollection<MedicalRecordViewModel> records = [];
    [ObservableProperty]
    private string searchText = "";
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            var CurrentUser = _currentUserService.GetCurrentUser();
            var Patient = await _patientService.GetPatientByUserIDAsync(CurrentUser!.UserID);
            NearestExam = (await _clinicalExaminationService.GetLatestClinicalExaminationByPatientIDAsync(Patient!.PatientID))!;
            var AllExams = await _clinicalExaminationService.GetClinicalExaminationsByPatientIDAsync(Patient.PatientID);
            Allergies = [.. AllExams.Select(e => e.Allergies)
                                    .Where(e => !e.IsNullOrEmpty())];
            var records = await _medicalRecordService.GetAllMedicalRecordsByPatientIDAsync(Patient.PatientID);
            Records = [.. records.Select(r => new MedicalRecordViewModel(r, _clinicalExaminationService, _prescriptionService, _prescriptionItemService))];
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoading = false;
        }
    }
    [RelayCommand]
    public async Task Search()
    {
        if (SearchText.IsNullOrEmpty())
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        IsLoading = true;
        try
        {
            var CurrentUser = _currentUserService.GetCurrentUser();
            var Patient = await _patientService.GetPatientByUserIDAsync(CurrentUser!.UserID);
            var records = (await _medicalRecordService.SearchByTextAsync(SearchText)).Where(r => r.Appointment.PatientID == Patient!.PatientID);
            Records = [.. records.Select(r => new MedicalRecordViewModel(r, _clinicalExaminationService, _prescriptionService, _prescriptionItemService))];
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoading = false;
        }
    }
    [RelayCommand]
    public async Task ReloadButton()
    {
        NearestExam = null!;
        Allergies = [];
        Records = [];
        await LoadDataAsync();
    }
}
