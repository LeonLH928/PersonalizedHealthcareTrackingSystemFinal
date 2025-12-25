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
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class DoctorWaitingListPageViewModel : ObservableObject
{
    private readonly IAppointmentService _appointmentService;
    private readonly ICurrentUserStoreService _currentUserService;
    private readonly IDoctorService _doctorService;
    private readonly IServiceProvider _serviceProvider;
    private DoctorModel _doctor = null!;
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
    private ObservableCollection<AppointmentModel> happeningAppointments = null!;
    [ObservableProperty]
    private ObservableCollection<AppointmentModel> upcomingAppointments = [];
    [ObservableProperty]
    private int upcomingNumber;
    [ObservableProperty]
    private int happeningNumber;
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
    private string selectedStatus = "All Status";
    [ObservableProperty]
    private string selectedSort = "No sort";
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            var CurrentUser = _currentUserService.GetCurrentUser();
            _doctor = (await _doctorService.GetDoctorByUserIDAsync(CurrentUser!.UserID))!;
            Appointments = [];
            SelectedStatus = "All Status";
            SelectedSort = "No sort";

            var happeningTask = _appointmentService.GetHappeningAppointmentByDoctorIDAsync(_doctor!.DoctorID);
            var upcomingTask = _appointmentService.GetUpcomingAppointmentsByDoctorIDAsync(_doctor!.DoctorID);
            var completedTask = _appointmentService.GetCompletedAppointmentsByDoctorIDAsync(_doctor!.DoctorID);
            var cancelledTask = _appointmentService.GetCancelledAppointmentsByDoctorIDAsync(_doctor!.DoctorID);
            var notShowUpTask = _appointmentService.GetNotShowUpAppointmentsByDoctorIDAsync(_doctor!.DoctorID);
            await Task.WhenAll(happeningTask, upcomingTask, completedTask, cancelledTask, notShowUpTask);

            HappeningAppointments = [.. happeningTask.Result];
            UpcomingAppointments = [.. upcomingTask.Result];
            CompletedAppointments = [.. completedTask.Result];
            CancelledAppointments = [.. cancelledTask.Result];
            NotShowUpAppointments = [.. notShowUpTask.Result];

            UpcomingNumber = UpcomingAppointments.Count;
            HappeningNumber = HappeningAppointments.Count;
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
        await LoadDataAsync();
    }

    [RelayCommand]
    public async Task Search(string? query)
    {
        SearchText = query ?? "";

        if (SearchText.IsNullOrEmpty())
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        IsBusy = true;
        try
        {
            await RefreshViewAsync();
        }
        finally
        {
            IsBusy = false;
        }
    }

    partial void OnSelectedStatusChanged(string value) => _ = RefreshViewAsync();
    partial void OnSelectedSortChanged(string value) => _ = RefreshViewAsync();
    partial void OnSearchTextChanged(string value) => _ = RefreshViewAsync();  

    private async Task RefreshViewAsync()
    {
        IsBusy = true;
        try
        {
            IEnumerable<AppointmentModel> query = [];
            if (!SearchText.IsNullOrEmpty())
                query = await _appointmentService.SearchByTextAsync(SearchText);

            IEnumerable<AppointmentModel> result = [];

            switch (SelectedStatus)
            {
                case "All Status":
                    await LoadDataAsync();
                    return;
                case "Happening":
                    result = await _appointmentService.GetHappeningAppointmentByDoctorIDAsync(_doctor.DoctorID);
                    break;
                case "Scheduled":
                    result = await _appointmentService.GetUpcomingAppointmentsByDoctorIDAsync(_doctor.DoctorID);
                    break;
                case "Completed":
                    result = await _appointmentService.GetCompletedAppointmentsByDoctorIDAsync(_doctor.DoctorID);
                    break;
                case "Cancelled":
                    result = await _appointmentService.GetCancelledAppointmentsByDoctorIDAsync(_doctor.DoctorID);
                    break;
                case "Not show up":
                    result = await _appointmentService.GetNotShowUpAppointmentsByDoctorIDAsync(_doctor.DoctorID);
                    break;
            }

            IEnumerable<string> listIDs = result.Select(a => a.AppointmentID);

            if (query.IsNullOrEmpty())
                query = result;
            else
                query = query.Where(a => listIDs.Contains(a.AppointmentID));

            switch (SelectedSort)
            {
                case "Sort: Latest":
                    query = query.OrderByDescending(a => a.AppointmentDateTime);
                    break;
                case "Sort: Name A-Z":
                    query = query.OrderBy(a => a.Patient.User.FirstName);
                    break;
            }

            Appointments = new ObservableCollection<AppointmentModel>(query);
        }
        finally
        {
            IsBusy = false;
        }
    }
}

