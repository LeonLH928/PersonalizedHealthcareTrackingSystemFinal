using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;
public partial class InventoryManagementPageViewModel : ObservableObject
{
    private readonly IMedicationService _medicationService;
    public InventoryManagementPageViewModel(IMedicationService medicationService)
    {
        _medicationService = medicationService;

        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private ObservableCollection<MedicationModel> medications = [];
    [ObservableProperty]
    private MedicationModel selectedMedication = null!;
    public async Task LoadDataAsync()
    {
        Medications = [.. await _medicationService.GetAllMedications()];
    }
    [RelayCommand]
    public void AdjustButton(MedicationModel medication)
    {
        SelectedMedication = medication;
    }
}
