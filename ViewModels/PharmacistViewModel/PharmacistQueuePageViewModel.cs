using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;

public partial class PharmacistQueuePageViewModel : ObservableObject
{
    private readonly IPrescriptionService _prescriptionService;
    private readonly IClinicalExaminationService _clinicalExaminationService;
    private readonly IPrescriptionItemService _prescriptionItemService;
    public PharmacistQueuePageViewModel(IPrescriptionService prescriptionService,
                                        IClinicalExaminationService clinicalExamination,
                                        IPrescriptionItemService prescriptionItemService)
    {
        _prescriptionService = prescriptionService;
        _clinicalExaminationService = clinicalExamination;
        _prescriptionItemService = prescriptionItemService;
        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private bool isPendingSelected = false;
    [ObservableProperty]
    private bool isDispensingSelected = false;
    [ObservableProperty]
    private bool isCompletedSelected = false;
    [ObservableProperty]
    private bool isCancelledSelected = false;
    [ObservableProperty]
    private bool isLoadingBar = false;
    [ObservableProperty]
    private bool isLoadingContent = false;
    [ObservableProperty]
    private int numberPending;
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionsPending = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionsDispensing = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionsCompleted = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionsCancelled = [];
    [ObservableProperty]
    private PrescriptionModel selectedPendingPrescription = null!;
    [ObservableProperty]
    private PrescriptionModel selectedDispensingPrescription = null!;
    [ObservableProperty]
    private PrescriptionModel selectedCompletedPrescription = null!;
    [ObservableProperty]
    private PrescriptionModel selectedCancelledPrescription = null!;
    [ObservableProperty]
    private ClinicalExaminationModel selectedClinicalExamination = null!;
    [ObservableProperty]
    private ObservableCollection<ClinicalExaminationModel> selectedAllClinicalExaminations = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionItemModel> selectedAllPrescriptionItems = [];
    public async Task LoadDataAsync()
    {
        SelectedPendingPrescription = SelectedDispensingPrescription = SelectedCancelledPrescription = SelectedCompletedPrescription = null!;
        PrescriptionsCancelled.Clear();
        PrescriptionsDispensing.Clear();
        PrescriptionsCompleted.Clear();
        PrescriptionsPending.Clear();
        IsLoadingBar = true;
        try
        {
            PrescriptionsPending = [.. await _prescriptionService.GetAllPendingPrescriptionsAsync()];
            NumberPending = PrescriptionsPending.Count();
            PrescriptionsDispensing = [.. await _prescriptionService.GetAllDispensingPrescriptionsAsync()];
            PrescriptionsCompleted = [.. await _prescriptionService.GetAllCompletedPrescriptionsAsync()];
            PrescriptionsCancelled = [.. await _prescriptionService.GetAllCancelledPrescriptionsAsync()];
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoadingBar = false;
        }
    }
    partial void OnSelectedPendingPrescriptionChanged(PrescriptionModel value)
    {
        IsPendingSelected = SelectedPendingPrescription != null;
        if (IsPendingSelected)
        {
            SelectedDispensingPrescription = SelectedCompletedPrescription = SelectedCancelledPrescription = null!;
        }
        try
        {
            if (SelectedPendingPrescription != null)
            {
                _ = UpdateData(SelectedPendingPrescription.RecordID, SelectedPendingPrescription.PrescriptionID);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load the prescription: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    partial void OnSelectedDispensingPrescriptionChanged(PrescriptionModel value)
    {
        IsDispensingSelected = SelectedDispensingPrescription != null;
        if (IsDispensingSelected)
        {
            SelectedPendingPrescription = SelectedCompletedPrescription = SelectedCancelledPrescription = null!;
        }
        try
        {
            if (SelectedDispensingPrescription != null)
            {
                _ = UpdateData(SelectedDispensingPrescription.RecordID, SelectedDispensingPrescription.PrescriptionID);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load the prescription: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    partial void OnSelectedCompletedPrescriptionChanged(PrescriptionModel value)
    {
        IsCompletedSelected = SelectedCompletedPrescription != null;
        if (IsCompletedSelected)
        {
            SelectedPendingPrescription = SelectedDispensingPrescription = SelectedCancelledPrescription = null!;
        }
        try
        {
            if (SelectedCompletedPrescription != null)
            {
                _ = UpdateData(SelectedCompletedPrescription.RecordID, SelectedCompletedPrescription.PrescriptionID);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load the prescription: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    partial void OnSelectedCancelledPrescriptionChanged(PrescriptionModel value)
    {
        IsCancelledSelected = SelectedCancelledPrescription != null;
        if (IsCancelledSelected)
        {
            SelectedDispensingPrescription = SelectedCompletedPrescription = SelectedPendingPrescription = null!;
        }
        try
        {
            if (SelectedCancelledPrescription != null)
            {
                _ = UpdateData(SelectedCancelledPrescription.RecordID, SelectedCancelledPrescription.PrescriptionID);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load the prescription: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    public async Task UpdateData(string RecordID, string PrescriptionID)
    {
        IsLoadingContent = true;
        try
        {
            var task1 = UpdateSelectedClinicalExaminations(RecordID);
            var task2 = UpdateSelectedItems(PrescriptionID);

            await Task.WhenAll(task1, task2);
        }
        finally
        {
            IsLoadingContent = false;
        }
    }
    public async Task UpdateSelectedClinicalExaminations(string RecordID)
    {
        SelectedClinicalExamination = (await _clinicalExaminationService.GetClinicalExaminationByMedicalRecordIDAsync(RecordID))!;
        SelectedAllClinicalExaminations = [.. await _clinicalExaminationService.GetClinicalExaminationsByPatientID(
                                                    SelectedClinicalExamination.MedicalRecord.Appointment.PatientID)];
    }
    public async Task UpdateSelectedItems(string PrescriptionID)
    {
        SelectedAllPrescriptionItems = [.. await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionID(PrescriptionID)];
    }
    [RelayCommand]
    public async Task ReloadButton()
    {
        SelectedPendingPrescription = null!;
        await LoadDataAsync();
    }
    [RelayCommand]
    public async Task VerifyButton()
    {
        try
        {
            SelectedPendingPrescription.Status = Models.PrescriptionStatus.Dispensed;
            await _prescriptionService.AddPrescriptionAsync(SelectedPendingPrescription);
            _ = LoadDataAsync();
            MessageBox.Show("Verify successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to verify: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}