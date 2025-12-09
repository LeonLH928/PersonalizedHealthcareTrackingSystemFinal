using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel.Wrappers;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
    private bool isLoadingBar = false;
    [ObservableProperty]
    private bool isLoadingContent = false;
    [ObservableProperty]
    private int numberPending;
    [ObservableProperty]
    private int numberDispensing;
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionsPending = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionsDispensing = [];
    [ObservableProperty]
    private PrescriptionModel selectedPendingPrescription = null!;
    [ObservableProperty]
    private PrescriptionModel selectedDispensingPrescription = null!;
    [ObservableProperty]
    private ClinicalExaminationModel selectedClinicalExamination = null!;
    [ObservableProperty]
    private ObservableCollection<ClinicalExaminationModel> selectedAllClinicalExaminations = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionItemViewModel> selectedAllPrescriptionItems = [];
    public async Task LoadDataAsync()
    {
        SelectedPendingPrescription = SelectedDispensingPrescription = null!;
        PrescriptionsDispensing.Clear();
        PrescriptionsPending.Clear();
        IsLoadingBar = true;
        try
        {
            PrescriptionsPending = [.. await _prescriptionService.GetAllPendingPrescriptionsAsync()];
            NumberPending = PrescriptionsPending.Count();
            PrescriptionsDispensing = [.. await _prescriptionService.GetAllDispensingPrescriptionsAsync()];
            NumberDispensing = PrescriptionsDispensing.Count();
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
            SelectedDispensingPrescription = null!;
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
            SelectedPendingPrescription = null!;
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
        var models = await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionID(PrescriptionID);
        SelectedAllPrescriptionItems = [.. 
            models.Select(item => new PrescriptionItemViewModel(item))];
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
    [RelayCommand]
    public async Task DoneDispensingButton()
    {
        try
        {
            foreach (var item in SelectedAllPrescriptionItems)
                if (!item.IsChecked)
                {
                    MessageBox.Show($"Dispense unsuccesfully: All drugs are not dispensed yet", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            SelectedDispensingPrescription.Status = Models.PrescriptionStatus.Completed;
            await _prescriptionService.AddPrescriptionAsync(SelectedDispensingPrescription);
            MessageBox.Show($"Dispense successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to dispense: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}