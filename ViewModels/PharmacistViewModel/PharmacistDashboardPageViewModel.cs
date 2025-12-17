using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using PersonalizedHealthcareTrackingSystemFinal.Interfaces;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.PharmacistView;
using System.Collections.ObjectModel;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;
public partial class PharmacistDashboardPageViewModel : ObservableObject
{
    private readonly IPrescriptionService _prescriptionService;
    private readonly IMedicationService _medicationService;
    private readonly ICurrentUserStoreService _currentUserService;
    public PharmacistDashboardPageViewModel(IPrescriptionService prescriptionService,
                                            IMedicationService medicationService,
                                            ICurrentUserStoreService currentUserService)
    {
        _prescriptionService = prescriptionService;
        _medicationService = medicationService;
        _currentUserService = currentUserService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private UserModel currentUser = null!;
    [ObservableProperty]
    private int pendingTotal;
    [ObservableProperty]
    private bool isLoading;
    [ObservableProperty]
    private int dispensingTotal;
    [ObservableProperty]
    private int completedTotal;
    [ObservableProperty]
    private int lowStockTotal;
    [ObservableProperty]
    private ObservableCollection<MedicationModel> lowStockMedications = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> allPrescriptions = [];
    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> latestPrescriptions = [];
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            CurrentUser = _currentUserService.GetCurrentUser()!;

            AllPrescriptions = [.. 
                await _prescriptionService.GetAllPrescriptionsAsync()];
            PendingTotal = AllPrescriptions
                .Where(p => p.Status == Models.PrescriptionStatus.Pending)
                .Count();
            DispensingTotal = AllPrescriptions
                .Where(p => p.Status == Models.PrescriptionStatus.Dispensed)
                .Count();
            CompletedTotal = AllPrescriptions
                .Where(p => p.Status == Models.PrescriptionStatus.Completed)
                .Count();
            LowStockMedications = [.. 
                await _medicationService.GetAllLowStockMedications()];
            LowStockTotal = LowStockMedications.Count();
            LatestPrescriptions = [.. AllPrescriptions.OrderByDescending(p => p.PrescriptionDateTime)
                                                      .Take(10)];
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
    public void ViewAllButton()
    {
        WeakReferenceMessenger.Default.Send(new PageTypeMessage(typeof(PharmacistQueuePage)));
    }
    [RelayCommand]
    public void GoToInventoryManagementButton()
    {
        WeakReferenceMessenger.Default.Send(new PageTypeMessage(typeof(InventoryManagementPage)));
    }
}
