using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
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
    private ClinicalExaminationModel selectedClinicalExamination = null!;
    [ObservableProperty]
    private ObservableCollection<ClinicalExaminationModel> selectedAllClinicalExaminations = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionItemModel> selectedAllPrescriptionItems = [];
    public async Task LoadDataAsync()
    {
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
    }
    partial void OnSelectedPendingPrescriptionChanged(PrescriptionModel value)
    {
        IsPendingSelected = SelectedPendingPrescription != null;
        if (SelectedPendingPrescription != null)
        {
            _ = UpdateSelectedClinicalExaminations(SelectedPendingPrescription.RecordID);
            _ = UpdateSelectedItems(SelectedPendingPrescription.PrescriptionID);
        }
    }
    public async Task UpdateSelectedClinicalExaminations(string RecordID)
    {
        SelectedClinicalExamination = (await _clinicalExaminationService.GetClinicalExaminationByMedicalRecordIDAsync(RecordID))!;
        SelectedAllClinicalExaminations = [.. await _clinicalExaminationService.GetClinicalExaminationsByPatientID(
                                                    SelectedPendingPrescription.MedicalRecord.Appointment.PatientID)];
    }
    public async Task UpdateSelectedItems(string PrescriptionID)
    {
        SelectedAllPrescriptionItems = [.. await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionID(PrescriptionID)];
    }
}
