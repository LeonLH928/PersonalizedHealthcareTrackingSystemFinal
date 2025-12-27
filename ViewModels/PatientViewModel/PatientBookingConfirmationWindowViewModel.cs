using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using PersonalizedHealthcareTrackingSystemFinal.Views.PatientView;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
public partial class PatientBookingConfirmationWindowViewModel : ObservableObject, 
                                                                 IRecipient<ConfirmationBookingMessage>
{
    private readonly IAppointmentService _appointmentService;
    private string doctorFullnameMessage = "";
    private string selectedDoctorIDMessage = "";
    private string patientIDMessage = "";
    private DateTime selectedDateMessage = DateTime.Now;
    private TimeOnly selectedSlotMessage;
    private PatientBookingPageViewModel patientBookingPageViewModel = null!;
    public PatientBookingConfirmationWindowViewModel(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;

        WeakReferenceMessenger.Default.Register<ConfirmationBookingMessage>(this);
    }
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private string doctorFullName = "";
    [ObservableProperty]
    private DateTime selectedDate = DateTime.Now; 
    [ObservableProperty]
    private string selectedSlot = "";
    [ObservableProperty]
    private string chiefComplaint = "";
    [ObservableProperty]
    private string note = "";
    [RelayCommand]
    public async Task LoadDataAsync()
    {
        IsLoading = true; 
        try
        {
            DoctorFullName = doctorFullnameMessage;
            SelectedDate = selectedDateMessage;
            SelectedSlot = $"{selectedSlotMessage} - {selectedSlotMessage.AddMinutes(15)}";
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
    public void Receive(ConfirmationBookingMessage message)
    {
        (selectedSlotMessage, doctorFullnameMessage, selectedDoctorIDMessage, patientIDMessage, selectedDateMessage, patientBookingPageViewModel) = message.Value;
        _ = LoadDataAsync();
    }
    [RelayCommand]
    public async Task ConfirmAppointment()
    {
        try
        {
            if (ChiefComplaint.IsNullOrEmpty())
            {
                MessageBox.Show($"Please provide your reason!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            DateTime TargetDateTime = new(DateOnly.FromDateTime(SelectedDate), selectedSlotMessage);

            AppointmentModel NewAppointment = new()
            {
                AppointmentID = Guid.NewGuid().ToString(),
                AppointmentDateTime = TargetDateTime,
                ChiefComplaint = ChiefComplaint,
                Location = "Get to Medicare to receive room's number",
                Status = Models.StatusAppointment.Scheduled,
                Note = Note,
                Priority=Models.Priority.Routine,
                VisitNumber=1,
                PatientID = patientIDMessage,
                DoctorID = selectedDoctorIDMessage
            };

            await _appointmentService.AddAppointmentAsync(NewAppointment);

            MessageBox.Show(
                $"Book successfully!\nTime: {SelectedSlot}",
                "Thành công",
                MessageBoxButton.OK,
                MessageBoxImage.Information
            );

            await patientBookingPageViewModel.UpdateSlots();
            CloseWindowButton();
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to submit: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
    [RelayCommand]
    public void CloseWindowButton()
    {
        Application.Current.Windows.OfType<PatientBookingConfirmationWindow>().FirstOrDefault()?.Close();
    }

}
