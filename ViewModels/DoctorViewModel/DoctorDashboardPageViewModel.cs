using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class DoctorDashboardPageViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IAppointmentService _appointmentService;
    private readonly IPatientService _patientService;
    private readonly IUserService _userService;
    public DoctorDashboardPageViewModel (IServiceProvider serviceProvider, 
                                         IAppointmentService appointmentService,
                                         IPatientService patientService,
                                         IUserService userService)
    {
        InitializeChart();
        _serviceProvider = serviceProvider;
        _appointmentService = appointmentService;
        _patientService = patientService;
        _userService = userService;
        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private int totalAppointments;
    [ObservableProperty]
    private int upcomings;
    [ObservableProperty]
    private int todayFinisheds;
    [ObservableProperty]
    private int overdues;
    [ObservableProperty]
    private int cancelleds;
    [ObservableProperty]
    private int age;
    [ObservableProperty]
    private string gender = "";
    [ObservableProperty]
    private string defaultAvatar = "";
    [ObservableProperty]
    private string priority = "";
    [ObservableProperty]
    private string fullName = "";
    [ObservableProperty]
    private string chiefComplaint = "";
    [ObservableProperty]
    private DateTime appointmentDateTime = DateTime.Now;
    [ObservableProperty]
    private int visitNumber;
    public async Task LoadDataAsync()
    {
        var Appointments = await _appointmentService.GetAllAppointmentsByDoctorIDAsync();
        TotalAppointments = Appointments.Count();
        Upcomings = Appointments.Count(a => a.Status == Models.StatusAppointment.Scheduled);
        TodayFinisheds = Appointments.Count(a => a.Status == Models.StatusAppointment.Completed);
        Overdues = Appointments.Count(a => a.Status == Models.StatusAppointment.No_show);
        Cancelleds = Appointments.Count(a => a.Status == Models.StatusAppointment.Cancelled);
        var NearestUpcoming = await _appointmentService.GetNearestAppointmentByDoctorIDAsync();
        var NearestPatient = await _patientService.GetPatientByIDAsync(NearestUpcoming.PatientID);
        var NearestPatientUser = await _userService.GetUserByIDAsync(NearestPatient.UserID);
        Age = DateTime.Now.Year - NearestPatient.DateOfBirth.Year;
        Gender = NearestPatient.Gender.ToString();
        foreach (var c in NearestPatientUser.FirstName.Split())
            DefaultAvatar += c[0];
        Priority = NearestUpcoming.Status.ToString();
        FullName = NearestPatientUser.FirstName + " " + NearestPatientUser.LastName;
        ChiefComplaint = NearestUpcoming.ChiefComplaint;
        AppointmentDateTime = NearestUpcoming.AppointmentDateTime;
        VisitNumber = NearestUpcoming.VisitNumber;
    }
    #region Doghnut Chart
    [ObservableProperty]
    private ObservableCollection<ISeries> data = [];
    public void InitializeChart()
    {
        Data = [
            new PieSeries<double>
            {
                Name = "Finished",
                Values = [ TodayFinisheds ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<double>
            {
                Name = "Upcoming",
                Values = [ Upcomings ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<double>
            {
                Name = "Not show up",
                Values = [ Overdues ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<double>
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
        }
    }
}
