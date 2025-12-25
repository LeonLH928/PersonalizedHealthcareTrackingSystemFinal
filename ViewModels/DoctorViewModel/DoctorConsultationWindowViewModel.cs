using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;
public partial class DoctorConsultationWindowViewModel : ObservableObject, 
                                                         IRecipient<SelectedAppointmentIDMessage>,
                                                         IRecipient<SelectedMedicationIDsMessage>
{
    private string SelectedAppointmentIDMessage = "";
    private readonly IServiceProvider _serviceProvider;
    private readonly IClinicalExaminationService _clinicalExaminationService;
    private readonly IPatientService _patientService;
    private readonly IUserService _userService;
    private readonly IAppointmentService _appointmentService;
    private readonly IMedicalRecordService _medicalRecordService;
    private readonly IMedicationInteractionService _medicationInteractionService;
    private readonly IMedicationService _medicationService;
    private readonly IPrescriptionService _prescriptionService;
    private readonly IPrescriptionItemService _prescriptionItemService;
    public DoctorConsultationWindowViewModel(IClinicalExaminationService clinicalExaminationService,
                                             IPatientService patientService,
                                             IUserService userService,
                                             IAppointmentService appointmentService,
                                             IMedicalRecordService medicalRecordService,
                                             IMedicationInteractionService medicationInteractionService,
                                             IServiceProvider serviceProvider,
                                             IMedicationService medicationService,
                                             IPrescriptionService prescriptionService,
                                             IPrescriptionItemService prescriptionItemService)
    {
        _clinicalExaminationService = clinicalExaminationService;
        _patientService = patientService;
        _userService = userService;
        _appointmentService = appointmentService;
        _medicalRecordService = medicalRecordService;
        _medicationInteractionService = medicationInteractionService;
        _serviceProvider = serviceProvider;
        _medicationService = medicationService;
        _prescriptionService = prescriptionService;
        _prescriptionItemService = prescriptionItemService;
        WeakReferenceMessenger.Default.Register<SelectedAppointmentIDMessage>(this);
        WeakReferenceMessenger.Default.Register<SelectedMedicationIDsMessage>(this);
    }
    #region Observable Properties
    [ObservableProperty]
    private bool isLoading = true;
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
    private ClinicalExaminationModel? latestClinicalExamination = null;
    [ObservableProperty]
    private AppointmentModel latestAppointment = null!;
    [ObservableProperty]
    private string gender = "";
    [ObservableProperty]
    private int age;
    [ObservableProperty]
    private string bloodType = "";
    [ObservableProperty]
    private ObservableCollection<MedicationModel> selectedMedications = [];
    [ObservableProperty]
    private ObservableCollection<MedicationInteractionModel> medicationInteractions = [];
    [ObservableProperty]
    private double temperature;
    [ObservableProperty]
    private double height;
    [ObservableProperty]
    private double weight;
    [ObservableProperty]
    private double bMI;
    [ObservableProperty]
    private Models.StatusBMI statusBMI = Models.StatusBMI.NotCalculate;
    [ObservableProperty]
    private double pulse;
    [ObservableProperty]
    private string bloodPressure = "";
    [ObservableProperty]
    private double respiratoryRate;
    [ObservableProperty]
    private double oxygenSaturation;
    [ObservableProperty]
    private string symptoms = "";
    [ObservableProperty]
    private string diagnosis = "";
    [ObservableProperty]
    private string treatmentPlan = "";
    [ObservableProperty]
    private string note = "";
    [ObservableProperty]
    private string familyHistory = "";
    [ObservableProperty]
    private string lifestyleHabits = "";
    [ObservableProperty]
    private DateTime? followUpVisit = null;
    [ObservableProperty]
    private int quantity;
    [ObservableProperty]
    private string dosage = "";
    [ObservableProperty]
    private string frequency = "";
    [ObservableProperty]
    private int duration;
    [ObservableProperty]
    private string instruction = "";
    [ObservableProperty]
    private string indication = "";
    [ObservableProperty]
    private int morning;
    [ObservableProperty]
    private int noon;
    [ObservableProperty]
    private int afternoon;
    [ObservableProperty]
    private int night;
    #endregion
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            LatestAppointment = (await _appointmentService.GetAppointmentByIDAsync(SelectedAppointmentIDMessage))!;
            
            var Patient = await _patientService.GetPatientByIDAsync(LatestAppointment.PatientID);
            var User = await _userService.GetUserByIDAsync(Patient!.UserID);
            var Records = await _medicalRecordService.GetAllMedicalRecordsByPatientIDAsync(Patient.PatientID);
            var Examinations = await _clinicalExaminationService.GetClinicalExaminationsByPatientIDAsync(Patient.PatientID);

            LatestClinicalExamination = await _clinicalExaminationService.GetLatestClinicalExaminationByPatientIDAsync(Patient.PatientID);
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
    partial void OnHeightChanged(double value)
    {
        UpdateBMI();
    }
    partial void OnWeightChanged(double value)
    {
        UpdateBMI();
    }
    private void UpdateBMI()
    {
        if (Height > 0 && Weight > 0)
        {
            BMI = Weight / Math.Pow(Height / 100, 2);
            switch (BMI)
            {
                case < 18.5:
                    StatusBMI = Models.StatusBMI.Underweight;
                    break;
                case >= 18.5 and <= 24.9:
                    StatusBMI = Models.StatusBMI.Normal;
                    break;
                case >= 25 and <= 29.9:
                    StatusBMI = Models.StatusBMI.Overweight;
                    break;
                case >= 30:
                    StatusBMI = Models.StatusBMI.Obese;
                    break;
            }
        }
        else
        {
            BMI = 0;
            StatusBMI = Models.StatusBMI.NotCalculate;
        }
    }
    public void Receive(SelectedAppointmentIDMessage Message)
    {
        SelectedAppointmentIDMessage = Message.Value;
        _ = LoadDataAsync();
    }
    public void Receive(SelectedMedicationIDsMessage Message)
    {
        var MedicationIDs = Message.Value;
        _ = LoadMedications(MedicationIDs);
    }
    public async Task LoadMedications(List<string> MedicationIDs)
    {
        try
        {
            var medications = await _medicationService.GetAllMedicationsByIDsAsync(MedicationIDs);
            SelectedMedications = [.. medications];
            await LoadInteractions();
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot get the medications. Please try again.\n{e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            Debug.Write($"\n{e.Message}\n");
        }
    }
    [RelayCommand]
    public async Task DeleteMedication(MedicationModel SelectedMedication)
    {
        if (SelectedMedication != null && SelectedMedications.Contains(SelectedMedication))
        {
            SelectedMedications.Remove(SelectedMedication);
            await LoadInteractions();
        }
    }
    [RelayCommand]
    public async Task DeleteAll()
    {
        SelectedMedications.Clear();
        await LoadInteractions();
    }
    public async Task LoadInteractions()
    {
        try
        {
            var MedicationIDs = SelectedMedications.Select(m => m.MedicationID).ToList();
            var interactions = await _medicationInteractionService.GetAllMedicationInteractionsByMedicationIDsAsync(MedicationIDs);
            MedicationInteractions = [.. interactions];
        }
        catch (Exception e)
        {
            Debug.Write($"\n{e.Message}\n");
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    [RelayCommand]
    public async Task SubmitButton()
    {
        try
        {

            if (FollowUpVisit == null)
            {
                MessageBox.Show("Please select a follow-up date!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (Diagnosis.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter the diagnosis!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (TreatmentPlan.IsNullOrEmpty())
            {
                MessageBox.Show("Please enter the treatment plan!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            if (((DateTime)FollowUpVisit! - DateTime.Now).TotalSeconds <= 0)
            {
                MessageBox.Show("Please choose a proper follow-up date!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MedicalRecordModel NewMedicalRecord = new()
            {
                RecordID = Guid.NewGuid().ToString(),
                AppointmentID = SelectedAppointmentIDMessage,
                VisitTime = DateTime.Now,
                Diagnosis = Diagnosis,
                TreatmentPlan = TreatmentPlan,
                DoctorNotes = Note,
                NextVisitDate = (DateTime)FollowUpVisit
            };
            await _medicalRecordService.AddMedicalRecordAsync(NewMedicalRecord);

            AppointmentModel NewAppointment = new()
            {
                AppointmentID = Guid.NewGuid().ToString(),
                PatientID = LatestAppointment.PatientID,
                DoctorID = LatestAppointment.DoctorID,
                AppointmentDateTime = (DateTime)FollowUpVisit,
                ChiefComplaint = LatestAppointment.ChiefComplaint,
                Location = LatestAppointment.Location,
                Status = LatestAppointment.Status,
                Note = Note,
                Priority = LatestAppointment.Priority,
                VisitNumber = LatestAppointment.VisitNumber + 1,
            };
            await _appointmentService.AddAppointmentAsync(NewAppointment);

            LatestAppointment.Status = Models.StatusAppointment.Completed;
            await _appointmentService.AddAppointmentAsync(LatestAppointment);

            ClinicalExaminationModel NewClinicalExamination = new()
            {
                ClinicalID = Guid.NewGuid().ToString(),
                RecordID = NewMedicalRecord.RecordID,
                Symptoms = Symptoms,
                Temperature = Temperature,
                Height = Height,
                Weight = Weight,
                Pulse = Pulse,
                BloodPressure = BloodPressure,
                RespiratoryRate = RespiratoryRate,
                OxygenSaturation = OxygenSaturation,
                LifestyleHabits = LifestyleHabits,
                FamilyHistory = FamilyHistory
            };
            await _clinicalExaminationService.AddClinicalExaminationAsync(NewClinicalExamination);

            PrescriptionModel NewPrescription = new()
            {
                PrescriptionID = Guid.NewGuid().ToString(),
                RecordID = NewMedicalRecord.RecordID,
                PrescriptionDateTime = DateTime.UtcNow,
                Status = Models.PrescriptionStatus.Pending,
                PharmacistID = null!,
                VerifiedAt = null!,
                Priority = LatestAppointment.Priority,
                DispensedAt = null!
            };
            await _prescriptionService.AddPrescriptionAsync(NewPrescription);

            foreach (var medication in SelectedMedications)
            {
                PrescriptionItemModel PrescriptionItem = new()
                {
                    ItemID = Guid.NewGuid().ToString(),
                    PrescriptionID = NewPrescription.PrescriptionID,
                    MedicationID = medication.MedicationID,
                    Quantity = Quantity,
                    Dosage = Dosage,
                    Frequency = Frequency,
                    DurationDays = Duration,
                    Instruction = Instruction,
                    Indication = Indication,
                    DoseScheduleJSON = $@"{{ ""morning"": {Morning}, ""noon"": {Noon}, ""afternoon"": {Afternoon}, ""night"": {Night} }}"
                };
                await _prescriptionItemService.AddPrescriptionItemAsync(PrescriptionItem);
            }

            MessageBox.Show("Submit successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            CloseWindowButton();
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    [RelayCommand]
    public void AddDrugButton()
    {
        if (Application.Current.Windows.OfType<AddDrugWindow>().FirstOrDefault() == null)
        {
            var AddDrugPopUp = _serviceProvider.GetRequiredService<AddDrugWindow>();
            AddDrugPopUp.Show();
        }
    }
}
