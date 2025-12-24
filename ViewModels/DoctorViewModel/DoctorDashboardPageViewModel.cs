using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class DoctorDashboardPageViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppointmentService _appointmentService;
    private readonly IPatientService _patientService;
    private readonly IUserService _userService;
    private readonly ICurrentUserStoreService _currentUserStoreService;
    private readonly IDoctorService _doctorService;
    public DoctorDashboardPageViewModel(IServiceProvider serviceProvider, 
                                        IAppointmentService appointmentService,
                                        IPatientService patientService,
                                        IUserService userService, 
                                        ICurrentUserStoreService currentUserStoreService,
                                        IDoctorService doctorService)
    {
        _serviceProvider = serviceProvider;
        _appointmentService = appointmentService;
        _patientService = patientService;
        _userService = userService;
        _currentUserStoreService = currentUserStoreService;
        _doctorService = doctorService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private bool isLoading = true;
    [ObservableProperty]
    private AppointmentModel? nearestUpcoming = null;
    [ObservableProperty]
    private int totalAppointments;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Data))]
    private int upcomings;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Data))]
    private int todayFinisheds;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Data))]
    private int overdues;
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Data))]
    private int cancelleds;
    [ObservableProperty]
    private string gender = "";
    [ObservableProperty]
    private string defaultAvatar = "";
    [ObservableProperty]
    private string priority = "";
    [ObservableProperty]
    private int age;
    [ObservableProperty]
    private string fullName = "";
    [ObservableProperty]
    private string chiefComplaint = "";
    [ObservableProperty]
    private DateTime appointmentDateTime = DateTime.Now;
    [ObservableProperty]
    private double progress;
    [ObservableProperty]
    private int visitNumber;
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            var CurrentUser = _currentUserStoreService.GetCurrentUser();
            var Doctor = await  _doctorService.GetDoctorByUserIDAsync(CurrentUser!.UserID);
            var Appointments = await _appointmentService.GetAllAppointmentsByDoctorIDAsync(Doctor!.DoctorID);
            NearestUpcoming = await _appointmentService.GetNearestAppointmentByDoctorIDAsync(Doctor.DoctorID);
            var NearestPatient = await _patientService.GetPatientByIDAsync(NearestUpcoming!.PatientID);
            var NearestPatientUser = await _userService.GetUserByIDAsync(NearestPatient!.UserID);

            TotalAppointments = Appointments.Count();
            Upcomings = Appointments.Count(a => a.Status == Models.StatusAppointment.Scheduled);
            TodayFinisheds = Appointments.Count(a => a.Status == Models.StatusAppointment.Completed);
            Overdues = Appointments.Count(a => a.Status == Models.StatusAppointment.No_show);
            Cancelleds = Appointments.Count(a => a.Status == Models.StatusAppointment.Cancelled);
            Gender = NearestPatient.Gender.ToString();
            foreach (var c in NearestPatientUser.FirstName.Split())
                DefaultAvatar += c[0];
            Priority = NearestUpcoming.Status.ToString();
            Age = NearestPatient.Age;
            FullName = NearestPatientUser.FirstName + " " + NearestPatientUser.LastName;
            ChiefComplaint = NearestUpcoming.ChiefComplaint;
            AppointmentDateTime = NearestUpcoming.AppointmentDateTime;
            VisitNumber = NearestUpcoming.VisitNumber;
            Progress = 100 * TodayFinisheds / TotalAppointments;
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
    #region Doghnut Chart
    [ObservableProperty]
    private ObservableCollection<ISeries> data = [];
    public void InitializeChart()
    {
        Progress = 100 * TodayFinisheds / TotalAppointments;
        Data = [
            new PieSeries<int>
            {
                Name = "Finished",
                Values = [ TodayFinisheds ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<int>
            {
                Name = "Upcoming",
                Values = [ Upcomings ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<int>
            {
                Name = "Not show up",
                Values = [ Overdues ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<int>
            {
                Name = "Cancelled",
                Values = [ Cancelleds ],
                MaxRadialColumnWidth = 60
            }
        ];
    }
    #endregion

    [RelayCommand]
    public void CallToTheClinicButton()
    {
        if (Application.Current.Windows.OfType<DoctorConsultationWindow>().FirstOrDefault() == null)
        {
            var Popup = _serviceProvider.GetRequiredService<DoctorConsultationWindow>();
            Popup.Show();
            WeakReferenceMessenger.Default.Send(new SelectedAppointmentIDMessage(NearestUpcoming.AppointmentID));
        }
    }
    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        if (e.PropertyName == nameof(TodayFinisheds) ||
            e.PropertyName == nameof(Upcomings) ||
            e.PropertyName == nameof(Overdues) ||
            e.PropertyName == nameof(Cancelleds))
        {
            InitializeChart();
        }
    }
}
