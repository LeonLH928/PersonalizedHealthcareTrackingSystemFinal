using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class DoctorWaitingListPageViewModel : ObservableObject
{
    private readonly IAppointmentService _appointmentService;
    private readonly ICurrentUserStoreService _currentUserService;
    private readonly IDoctorService _doctorService;
    private readonly IServiceProvider _serviceProvider;
    public DoctorWaitingListPageViewModel(IAppointmentService appointmentService,
                                          ICurrentUserStoreService currentUserService,
                                          IDoctorService doctorService,
                                          IServiceProvider serviceProvider)
    {
        _appointmentService = appointmentService;
        _currentUserService = currentUserService;
        _doctorService = doctorService;
        _serviceProvider = serviceProvider;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private bool isBusy = false;
    [ObservableProperty]
    private bool isSearched = false;
    [ObservableProperty]
    private bool isHappening = false;
    [ObservableProperty]
    private bool isHappeningEmpty = false;
    [ObservableProperty]
    private bool isUpcoming = false;
    [ObservableProperty]
    private bool isUpcomingEmpty = false;
    [ObservableProperty]
    private bool isCompleted = false;
    [ObservableProperty]
    private bool isCompletedEmpty = false;
    [ObservableProperty]
    private bool isCancelled = false;
    [ObservableProperty]
    private bool isCancelledEmpty = false;
    [ObservableProperty]
    private bool isNotShowUp = false;
    [ObservableProperty]
    private bool isNotShowUpEmpty = false;
    [ObservableProperty]
    private ObservableCollection<AppointmentModel> happeningAppointment = null!;
    [ObservableProperty]
    private ObservableCollection<AppointmentModel> upcomingAppointments = [];
    [ObservableProperty]
    private int upcomingNumber;
    [ObservableProperty]
    private ObservableCollection<AppointmentModel> completedAppointments = [];
    [ObservableProperty]
    private ObservableCollection<AppointmentModel> cancelledAppointments = [];
    [ObservableProperty]
    private ObservableCollection<AppointmentModel> notShowUpAppointments = [];
    [ObservableProperty]
    private string searchText = "";
    [ObservableProperty]
    private ObservableCollection<AppointmentModel> appointments = [];
    [ObservableProperty]
    private bool isAppointments = false;
    [ObservableProperty]
    private bool isAppointmentsEmpty = true;
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            var CurrentUser = _currentUserService.GetCurrentUser();
            var Doctor = await (_doctorService.GetDoctorByUserIDAsync(CurrentUser!.UserID))!;

            HappeningAppointment = [.. await _appointmentService.GetHappeningAppointmentByDoctorIDAsync(Doctor!.DoctorID)];
            UpcomingAppointments = [.. await _appointmentService.GetUpcomingAppointmentsByDoctorIDAsync(Doctor!.DoctorID)];
            CompletedAppointments = [.. await _appointmentService.GetCompletedAppointmentsByDoctorIDAsync(Doctor!.DoctorID)];
            CancelledAppointments = [.. await _appointmentService.GetCancelledAppointmentsByDoctorIDAsync(Doctor!.DoctorID)];
            NotShowUpAppointments = [.. await _appointmentService.GetNotShowUpAppointmentsByDoctorIDAsync(Doctor!.DoctorID)];

            IsHappening = HappeningAppointment.Count > 0;
            IsHappeningEmpty = !IsHappening;
            IsUpcoming = UpcomingAppointments.Count > 0;
            IsUpcomingEmpty = !IsUpcoming;
            IsCompleted = CompletedAppointments.Count > 0;
            IsCompletedEmpty = !IsCompleted;
            IsCancelled = CancelledAppointments.Count > 0;
            IsCancelledEmpty = !IsCancelled;
            IsNotShowUp = NotShowUpAppointments.Count > 0;
            IsNotShowUpEmpty = !IsNotShowUp;

            UpcomingNumber = UpcomingAppointments.Count;
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
    public void CallToTheClinicButton(AppointmentModel SelectedAppointment)
    {
        if (Application.Current.Windows.OfType<DoctorConsultationWindow>().FirstOrDefault() == null)
        {
            var Popup = _serviceProvider.GetRequiredService<DoctorConsultationWindow>();
            Popup.Show();
            WeakReferenceMessenger.Default.Send(new SelectedAppointmentIDMessage(SelectedAppointment.AppointmentID));
        }
    }
    [RelayCommand]
    public async Task ReloadButton()
    {
        SearchText = "";
        Appointments.Clear();
        await LoadDataAsync();
    }
    partial void OnSearchTextChanged(string value)
    {
        IsSearched = !SearchText.IsNullOrEmpty();
    }
    [RelayCommand]
    public async Task Search()
    {
        if (SearchText.IsNullOrEmpty())
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        IsBusy = true;
        try
        {
            Appointments.Clear();
            Appointments = [.. await _appointmentService.SearchByText(SearchText)];
        }
        finally
        {
            IsBusy = false;
        }
    }
    partial void OnAppointmentsChanged(ObservableCollection<AppointmentModel> value)
    {
        IsAppointments = Appointments.Count > 0;
        IsAppointmentsEmpty = !IsAppointments;
    }
}
