using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.PatientView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
public partial class PatientBookingPageViewModel : ObservableObject
{
    private readonly IDoctorService _doctorService;
    private readonly IDoctorScheduleService _doctorScheduleService;
    private readonly IPatientService _patientService;
    private readonly ICurrentUserStoreService _currentUserStoreService;
    private readonly IServiceProvider _serviceProvider;
    private PatientModel CurrentUser = null!;
    public PatientBookingPageViewModel(IDoctorService doctorService,
                                       IDoctorScheduleService doctorScheduleService,
                                       IServiceProvider serviceProvider,
                                       IPatientService patientService,
                                       ICurrentUserStoreService currentUserStoreService)
    {
        _doctorService = doctorService;
        _doctorScheduleService = doctorScheduleService;
        _serviceProvider = serviceProvider;
        _patientService = patientService;
        _currentUserStoreService = currentUserStoreService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private bool isDoctorSelected = false;
    [ObservableProperty]
    private bool isDateSelected = false;
    [ObservableProperty]
    private bool isDateNotSelected = true;
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private bool isSunday = false;
    [ObservableProperty]
    private bool isBusy = false;
    [ObservableProperty]
    private bool isLoadingDoctor = false;
    [ObservableProperty]
    private bool isLoadingBar = false;
    [ObservableProperty]
    private ObservableCollection<Wrappers.DoctorViewModel> doctors = [];
    [ObservableProperty]
    private Wrappers.DoctorViewModel selectedDoctor = null!;
    [ObservableProperty]
    private DateTime? selectedDate = null!;
    [ObservableProperty]
    private ObservableCollection<Wrappers.TimeSlotViewModel> morningSlots = []; 
    [ObservableProperty]
    private ObservableCollection<Wrappers.TimeSlotViewModel> afternoonSlots = [];
    [ObservableProperty]
    private string searchText = "";
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        Doctors.Clear();
        SelectedDoctor = null!;
        try
        {
            CurrentUser = (await _patientService.GetPatientByUserIDAsync(
                                 _currentUserStoreService.GetCurrentUser()!.UserID))!;
            var doctors = (await _doctorService.GetAllDoctorsAsync());
            Doctors = [.. 
                doctors.Select(d => new Wrappers.DoctorViewModel(d))];
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
    [RelayCommand]
    public async Task ReloadButton()
    {
        IsLoadingBar = true;
        try
        {
            Doctors.Clear();
            SearchText = "";
            var doctors = (await _doctorService.GetAllDoctorsAsync());
            Doctors = [..
                doctors.Select(d => new Wrappers.DoctorViewModel(d))];
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoadingBar = false; 
        }
    }
    [RelayCommand]
    public async Task Search()
    {
        if (SearchText.IsNullOrEmpty())
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        IsBusy = true;
        try
        {
            var doctors = await _doctorService.SearchByTextAsync(SearchText);
            Doctors = [.. doctors.Select(d => new Wrappers.DoctorViewModel(d))];
        }
        finally
        {
            IsBusy = false;
        }
    }
    partial void OnSelectedDoctorChanged(Wrappers.DoctorViewModel value)
    {
        IsDoctorSelected = SelectedDoctor != null;
        if (IsDoctorSelected)
        {
            _ = UpdateOnSelectedDoctorChanged();
        }
    }
    partial void OnSelectedDateChanged(DateTime? value)
    {
        IsDateSelected = SelectedDate != null;
        IsDateNotSelected = !IsDateSelected;
        IsSunday = SelectedDate == null ? DateTime.Now.DayOfWeek == DayOfWeek.Sunday :
                                          SelectedDate.Value.DayOfWeek == DayOfWeek.Sunday;                               
        if (IsDateSelected)
            _ = UpdateSchedule();
    }
    public async Task UpdateOnSelectedDoctorChanged()
    {
        SelectedDate = null;
        IsSunday = DateTime.Now.DayOfWeek == DayOfWeek.Sunday;
        try
        {
            await UpdateSchedule();
            await UpdateSlots();
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoadingDoctor = false;
        }
    }
    public async Task UpdateSchedule()
    {
        IsLoadingDoctor = true;
        try
        {
            var schedule = (await _doctorScheduleService.GetLatestScheduleByDoctorIDAsync(SelectedDoctor.Doctor.DoctorID));
            SelectedDoctor.Schedule = schedule!;
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoadingDoctor = false;
        }
    }
    public async Task UpdateSlots()
    {
        IsLoadingDoctor = true;
        try
        {
            MorningSlots.Clear();
            AfternoonSlots.Clear();

            DateTime targetDate = SelectedDate ?? DateTime.UtcNow;

            var (schedule, bookedAppointments) = await _doctorScheduleService
                    .GetScheduleAndAppointmentsAsync(SelectedDoctor.Doctor.DoctorID, targetDate);

            bool CheckAvailability(TimeOnly slotStart)
            {
                if (schedule == null) return false;

                var slotEnd = slotStart.AddMinutes(15);

                bool isWorking = TimeOnly.FromDateTime(schedule.StartTime).AddHours(-7) <= slotStart
                              && TimeOnly.FromDateTime(schedule.EndTime).AddHours(-7) >= slotEnd;

                bool isBooked = bookedAppointments.Any(a =>
                    TimeOnly.FromDateTime(a.AppointmentDateTime) < slotEnd &&
                    TimeOnly.FromDateTime(a.AppointmentDateTime) >= slotStart);

                return isWorking && !isBooked;
            }

            var morningTime = new TimeOnly(7, 0);
            while (morningTime <= new TimeOnly(10, 45))
            {
                bool isAvailable = CheckAvailability(morningTime);
                MorningSlots.Add(new Wrappers.TimeSlotViewModel(morningTime, isAvailable));
                morningTime = morningTime.AddMinutes(15);
            }

            var afternoonTime = new TimeOnly(13, 0);
            while (afternoonTime <= new TimeOnly(16, 45))
            {
                bool isAvailable = CheckAvailability(afternoonTime);
                AfternoonSlots.Add(new Wrappers.TimeSlotViewModel(afternoonTime, isAvailable));
                afternoonTime = afternoonTime.AddMinutes(15);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show($"Unable to load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoadingDoctor = false;
        }
    }
    [RelayCommand]
    public async Task LeftButton()
    {
        if (SelectedDate == null)
        {
            SelectedDate = DateTime.Now.AddDays(-1);
            return;
        }
        SelectedDate = ((DateTime)SelectedDate).AddDays(-1);
        await UpdateSlots();
    }
    [RelayCommand]
    public async Task RightButton()
    {
        if (SelectedDate == null)
        {
            SelectedDate = DateTime.Now.AddDays(1);
            return;
        }
        SelectedDate = SelectedDate.Value.AddDays(1);
        await UpdateSlots();
    }
    [RelayCommand]
    public async Task SelectTimeButton(Wrappers.TimeSlotViewModel TimeSlot)
    {
        if (Application.Current.Windows.OfType<PatientBookingConfirmationWindow>().FirstOrDefault() == null)
        {
            var confirmationPopup = _serviceProvider.GetRequiredService<PatientBookingConfirmationWindow>();
            confirmationPopup.Show();
            DateTime targetDate = SelectedDate ?? DateTime.Now;
            WeakReferenceMessenger.Default.Send(new ConfirmationBookingMessage((
                    TimeSlot.StartSlot!.Value,
                    $"{SelectedDoctor.Doctor.User.FirstName} {SelectedDoctor.Doctor.User.LastName}",
                    SelectedDoctor.Doctor.DoctorID,
                    CurrentUser.PatientID,
                    targetDate,
                    this
                )));
        }
    }
}
