using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel.Wrappers;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.Reactive.Linq;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;
public partial class SeeMedicalRecordWindowViewModel : ObservableObject,
                                                       IRecipient<SelectedPatientIDMessage>
{
    private readonly IPatientService _patientService;
    private readonly IClinicalExaminationService _clinicalExaminationService;
    private readonly IMedicalRecordService _medicalRecordService;
    private readonly IPrescriptionService _prescriptionService;
    private readonly IPrescriptionItemService _prescriptionItemService;
    private string _patientID = "";
    public SeeMedicalRecordWindowViewModel(IPatientService patientService,
                                           IClinicalExaminationService clinicalExaminationService,
                                           IMedicalRecordService medicalRecordService,
                                           IPrescriptionService prescriptionService,
                                           IPrescriptionItemService prescriptionItemService)
    {
        _patientService = patientService;
        _clinicalExaminationService = clinicalExaminationService;
        _medicalRecordService = medicalRecordService;
        _prescriptionService = prescriptionService;
        _prescriptionItemService = prescriptionItemService;
        WeakReferenceMessenger.Default.Register<SelectedPatientIDMessage>(this);
    }
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private ObservableCollection<MedicalRecordViewModel> records = [];
    public void Receive(SelectedPatientIDMessage message)
    {
        _patientID = message.Value;
        _ = LoadDataAsync();
    }
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            var records = await _medicalRecordService.GetAllMedicalRecordsByPatientIDAsync(_patientID);
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
    public void CloseWindowButton()
    {
        Application.Current.Windows.OfType<SeeMedicalRecordWindow>().FirstOrDefault()?.Close();
    }

}
