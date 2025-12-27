using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Collections.ObjectModel;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel.Wrappers;
public partial class MedicalRecordViewModel : ObservableObject
{
    private readonly IClinicalExaminationService _clinicalExaminationService;
    private readonly IPrescriptionService _prescriptionService;
    private readonly IPrescriptionItemService _prescriptionItemService;
    public MedicalRecordViewModel(MedicalRecordModel record,
                                  IClinicalExaminationService clinicalExaminationService,
                                  IPrescriptionService prescriptionService,
                                  IPrescriptionItemService prescriptionItemService)
    {
        Record = record;
        _clinicalExaminationService = clinicalExaminationService;
        _prescriptionService = prescriptionService;
        _prescriptionItemService = prescriptionItemService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private MedicalRecordModel record = null!;
    [ObservableProperty]
    private ClinicalExaminationModel exam = null!;
    [ObservableProperty]
    private PrescriptionModel prescription = null!;
    [ObservableProperty]
    private ObservableCollection<PrescriptionItemModel> items = [];

    public async Task LoadDataAsync()
    {
        var exam = _clinicalExaminationService.GetClinicalExaminationByMedicalRecordIDAsync(Record.RecordID);
        var prescription = _prescriptionService.GetPrescriptionByMedicalRecordIDAsync(Record.RecordID);
        await Task.WhenAll(exam, prescription);
        Exam = (await exam)!;
        Prescription = await prescription;
        Items = [.. await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionIDAsync(Prescription.PrescriptionID)];
    }
}
