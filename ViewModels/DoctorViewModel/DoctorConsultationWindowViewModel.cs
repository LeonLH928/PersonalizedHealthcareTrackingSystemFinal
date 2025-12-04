using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;
public partial class DoctorConsultationWindowViewModel : ObservableObject, IRecipient<SelectedAppointmentIDMessage>
{
    private string SelectedAppointmentIDMessage = "";
    private readonly IClinicalExaminationService _clinicalExaminationService;
    private readonly IPatientService _patientService;
    private readonly IUserService _userService;
    private readonly IAppointmentService _appointmentService;
    private readonly IMedicalRecordService _medicalRecordService;
    private readonly IMedicationService _medicationService;
    private readonly IMedicationInteractionService _medicationInteractionService;
    public DoctorConsultationWindowViewModel(IClinicalExaminationService clinicalExaminationService,
                                             IPatientService patientService,
                                             IUserService userService,
                                             IAppointmentService appointmentService,
                                             IMedicalRecordService medicalRecordService,
                                             IMedicationService medicationService,
                                             IMedicationInteractionService medicationInteractionService)
    {
        _clinicalExaminationService = clinicalExaminationService;
        _patientService = patientService;
        _userService = userService;
        _appointmentService = appointmentService;
        _medicalRecordService = medicalRecordService;
        _medicationService = medicationService;
        _medicationInteractionService = medicationInteractionService;
        WeakReferenceMessenger.Default.Register<SelectedAppointmentIDMessage>(this);
    }
    [ObservableProperty]
    private bool isLoading = true;
    [ObservableProperty]
    private bool isBusy = true;
    [ObservableProperty]
    private string fullName = "";
    [ObservableProperty]
    private string patientID = "";
    [ObservableProperty]
    private string chiefComplaint = "";
    [ObservableProperty]
    private ObservableCollection<MedicalRecordModel> medicalRecords = [];
    [ObservableProperty]
    private ObservableCollection<ClinicalExaminationModel> clinicalExaminations = [];
    [ObservableProperty]
    private ClinicalExaminationModel latestClinicalExamination = null!;
    [ObservableProperty]
    private AppointmentModel latestAppointment = null!;
    [ObservableProperty]
    private string gender = "";
    [ObservableProperty]
    private int age;
    [ObservableProperty]
    private string bloodType = "";
    [ObservableProperty]
    private string searchText = "";
    [ObservableProperty]
    private ObservableCollection<MedicationModel> medications = [];
    [ObservableProperty]
    private ObservableCollection<MedicationInteractionModel> medicationInteractions = [];
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            LatestAppointment = await _appointmentService.GetAppointmentByIDAsync(SelectedAppointmentIDMessage);
            
            var Patient = await _patientService.GetPatientByIDAsync(LatestAppointment.PatientID);
            var User = await _userService.GetUserByIDAsync(Patient.UserID);
            var Records = await _medicalRecordService.GetAllMedicalRecordsByPatientIDAsync(Patient.PatientID);
            var Examinations = await _clinicalExaminationService.GetClinicalExaminationsByPatientID(Patient.PatientID);

            LatestClinicalExamination = await _clinicalExaminationService.GetLatestClinicalExaminationByPatientID(Patient.PatientID);
            ClinicalExaminations = [.. Examinations];
            MedicalRecords = [.. Records];
            FullName = User.FirstName + " " + User.LastName;
            PatientID = Patient.PatientID;
            ChiefComplaint = LatestAppointment.ChiefComplaint;
            Gender = Patient.Gender.ToString();
            Age = DateTime.Now.Year - Patient.DateOfBirth.Year;
            BloodType = Patient.BloodType;
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            IsLoading = false;
        }
        finally
        {
            IsLoading = false;
        }
    }
    [RelayCommand]
    public void CloseWindowButton()
    {
        Application.Current.Windows.OfType<DoctorConsultationWindow>().FirstOrDefault()?.Close();
    }
    public void Receive(SelectedAppointmentIDMessage Message)
    {
        SelectedAppointmentIDMessage = Message.Value;
        _ = LoadDataAsync();
    }
    [RelayCommand]
    public async Task Search()
    {
        if (SearchText.IsNullOrEmpty())
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        IsBusy = true;
        try
        {   
            var medications = await _medicationService.SearchByText(SearchText);
            Medications = [.. Medications.Concat(medications)];
            await LoadInteractions();
        }
        finally
        {
            IsBusy = false;
        }
    }
    [RelayCommand]
    public async Task DeleteMedication(MedicationModel SelectedMedication)
    {
        if (SelectedMedication != null && Medications.Contains(SelectedMedication))
        {
            Medications.Remove(SelectedMedication);
            await LoadInteractions();
        }
    }
    public async Task LoadInteractions()
    {
        try
        {
            var MedicationIDs = Medications.Select(m => m.MedicationID).ToList();
            var interactions = await _medicationInteractionService.GetAllMedicationInteractionsByMedicationIDs(MedicationIDs);
            MedicationInteractions = [.. interactions];
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
