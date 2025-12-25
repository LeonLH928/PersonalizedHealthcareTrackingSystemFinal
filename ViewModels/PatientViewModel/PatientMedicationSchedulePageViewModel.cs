using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Extensions;
using LiveChartsCore.SkiaSharpView.Painting;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using SkiaSharp;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
public class CalendarDay
{
    public string DayName { get; set; } = "";
    public string DayNumber { get; set; } = "";
    public DateTime Date { get; set; }
    public bool IsToday { get; set; }
    public bool IsPast { get; set; }
}

public partial class PatientMedicationSchedulePageViewModel : ObservableObject
{
    private readonly IPrescriptionService _prescriptionService;
    private readonly IPrescriptionItemService _prescriptionItemService;
    private readonly IPatientService _patientService;
    private readonly IMedicationAdherenceService _medicationAdherenceService;
    private readonly ICurrentUserStoreService _currentUser;
    private Dictionary<string, TimeOnly> timeMapping;

    public PatientMedicationSchedulePageViewModel(IPrescriptionService prescriptionService,
                                                  IPrescriptionItemService prescriptionItemService,
                                                  IMedicationAdherenceService medicationAdherenceService,
                                                  ICurrentUserStoreService currentUser,
                                                  IPatientService patientService)
    {
        _prescriptionService = prescriptionService;
        _prescriptionItemService = prescriptionItemService;
        _medicationAdherenceService = medicationAdherenceService;
        _currentUser = currentUser;
        _patientService = patientService;

        timeMapping = new()
        {
            { "morning", new TimeOnly(8, 0, 0) },
            { "afternoon", new TimeOnly(13, 0, 0) },
            { "evening", new TimeOnly(18, 0, 0) },
            { "night", new TimeOnly(21, 0, 0) }
        };

        _ = LoadAndCreateAsync();
        LoadCurrentWeek();
    }
    [ObservableProperty]
    private ObservableCollection<ISeries> series = [];
    [ObservableProperty]
    private PrescriptionModel? latestPrescription = null!;
    [ObservableProperty]
    private ObservableCollection<MedicationAdherenceModel> morningAdherences = [];
    [ObservableProperty]
    private ObservableCollection<MedicationAdherenceModel> afternoonAdherences = [];
    [ObservableProperty]
    private ObservableCollection<MedicationAdherenceModel> eveningAdherences = [];
    [ObservableProperty]
    private ObservableCollection<MedicationAdherenceModel> nightAdherences = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionItemModel> asNeededAdherences = [];
    [ObservableProperty]
    private int maxDoses;
    [ObservableProperty]
    private int completedDoses;
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private ObservableCollection<CalendarDay> currentWeek = [];
    [ObservableProperty]
    private string currentMonthYear = "";
    [ObservableProperty]
    private TimeOnly nextDose;
    public async Task LoadAndCreateAsync()
    {
        await CreateAdherencesAsync();
        await LoadDataAsync();
    }
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            var currentUser = _currentUser.GetCurrentUser();
            var Patient = await _patientService.GetPatientByUserIDAsync(currentUser!.UserID);
            LatestPrescription = await _prescriptionService.GetLatestPrescriptionByPatientIDAsync(Patient!.PatientID);
            if (LatestPrescription != null)
            {
                var LatestPrescriptionItems = await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionID(LatestPrescription.PrescriptionID);
                var LatestAdherences = await _medicationAdherenceService.GetTodayAdherencesByPatientIDAsync(Patient.PatientID);

                AsNeededAdherences = [.. await _prescriptionItemService.FilterAsNeeded(LatestPrescriptionItems.ToList())];

                MorningAdherences = [.. LatestAdherences.Where(a => a.ScheduledDateTime.Hour == timeMapping.GetValueOrDefault("morning").Hour)];
                AfternoonAdherences = [.. LatestAdherences.Where(a => a.ScheduledDateTime.Hour == timeMapping.GetValueOrDefault("afternoon").Hour)];
                EveningAdherences = [.. LatestAdherences.Where(a => a.ScheduledDateTime.Hour == timeMapping.GetValueOrDefault("evening").Hour)];
                NightAdherences = [.. LatestAdherences.Where(a => a.ScheduledDateTime.Hour == timeMapping.GetValueOrDefault("night").Hour)];

                MaxDoses = LatestAdherences.Count();
                CompletedDoses = LatestAdherences.Where(a => a.Status == Models.AdherenceStatus.Taken).Count();

                if (timeMapping.GetValueOrDefault("afternoon").Hour > DateTime.Now.Hour)
                    NextDose = timeMapping.GetValueOrDefault("morning");
                else if (timeMapping.GetValueOrDefault("evening").Hour > DateTime.Now.Hour)
                    NextDose = timeMapping.GetValueOrDefault("afternoon");
                else if (timeMapping.GetValueOrDefault("night").Hour > DateTime.Now.Hour)
                    NextDose = timeMapping.GetValueOrDefault("evening");
                else
                    NextDose = timeMapping.GetValueOrDefault("night");

                Series = [.. new ISeries[]
                {
                    new PieSeries<double>
                    {
                        Values = new double[] { CompletedDoses },
                        Fill = new SolidColorPaint(SKColor.Parse("#0090D8")),
                        InnerRadius = 50,
                        MaxRadialColumnWidth = 20,
                        HoverPushout = 0,
                        Stroke = null
                    },

                    new PieSeries<double>
                    {
                        Values = new double[] { MaxDoses - CompletedDoses },
                        Fill = new SolidColorPaint(SKColor.Parse("#EAEAEA")),
                        InnerRadius = 50,
                        MaxRadialColumnWidth = 20,
                        HoverPushout = 0,
                        Stroke = null
                    }
                }];
            }
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
    private void LoadCurrentWeek()
    {
        DateTime today = DateTime.Now;
        CurrentMonthYear = today.ToString("MMMM yyyy");

        int delta = DayOfWeek.Monday - today.DayOfWeek;
        if (delta > 0) delta -= 7;
        DateTime monday = today.AddDays(delta);

        for (int i = 0; i < 7; i++)
        {
            DateTime currentDay = monday.AddDays(i);

            CurrentWeek.Add(new CalendarDay
            {
                DayName = currentDay.ToString("ddd").Substring(0, 1),
                DayNumber = currentDay.Day.ToString(),
                Date = currentDay,
                IsToday = currentDay.Date == today.Date,
                IsPast = currentDay.Date < today.Date
            });
        }
    }

    public async Task CreateAdherencesAsync()
    {
        IsLoading = true;
        try
        {
            var currentUser = _currentUser.GetCurrentUser();
            var Patient = await _patientService.GetPatientByUserIDAsync(currentUser!.UserID);
            if ((await _medicationAdherenceService.GetTodayAdherencesByPatientIDAsync(Patient!.PatientID))
                                                  .Count() == 0)
            {
                LatestPrescription = await _prescriptionService.GetLatestPrescriptionByPatientIDAsync(Patient!.PatientID);
                if (LatestPrescription != null)
                {
                    var LatestPrescriptionItems = await _prescriptionItemService.GetAllPrescriptionItemsByPrescriptionID(LatestPrescription.PrescriptionID);
                    var LatestAdherences = await _medicationAdherenceService.CreateMedicationAdherenceBatchAsync(LatestPrescriptionItems);
                    foreach (var adherence in LatestAdherences)
                        await _medicationAdherenceService.UpsertAdherence(adherence);
                }
            }
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
    public async Task TakeMedicineButton(MedicationAdherenceModel adherence)
    {
        try
        {
            adherence.Status = Models.AdherenceStatus.Taken;
            adherence.TakenDateTime = DateTime.UtcNow;
            await _medicationAdherenceService.UpsertAdherence(adherence);
            MessageBox.Show($"Update successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            await LoadDataAsync();
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot load data: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
