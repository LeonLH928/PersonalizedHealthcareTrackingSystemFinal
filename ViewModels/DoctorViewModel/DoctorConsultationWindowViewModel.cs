using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;
public partial class DoctorConsultationWindowViewModel : ObservableObject, IRecipient<SelectedPatientIDMessage>
{
    private string SelectedPatientIDMessage = "";
    private readonly IClinicalExaminationService _clinicalExaminationService;
    private readonly IPatientService _patientService;
    private readonly IUserService _userService;
    public DoctorConsultationWindowViewModel(IClinicalExaminationService clinicalExaminationService,
                                             IPatientService patientService,
                                             IUserService userService)
    {
        _clinicalExaminationService = clinicalExaminationService;
        _patientService = patientService;
        _userService = userService;
        WeakReferenceMessenger.Default.Register<SelectedPatientIDMessage>(this);
    }
    [ObservableProperty]
    private string fullName = "";
    public async Task LoadDataAsync()
    {
        try
        {
            var Patient = await _patientService.GetPatientByIDAsync(SelectedPatientIDMessage);
            var User = await _userService.GetUserByIDAsync(Patient.UserID);
            FullName = User.FirstName + " " + User.LastName;
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    [RelayCommand]
    public void CloseWindowButton()
    {
        Application.Current.Windows.OfType<DoctorConsultationWindow>().FirstOrDefault()?.Close();
    }
    public void Receive(SelectedPatientIDMessage Message)
    {
        SelectedPatientIDMessage = Message.Value;
        _ = LoadDataAsync();
    }
}
