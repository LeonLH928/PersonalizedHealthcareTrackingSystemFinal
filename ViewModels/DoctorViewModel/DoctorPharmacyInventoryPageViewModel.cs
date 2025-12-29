using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;
public partial class DoctorPharmacyInventoryPageViewModel : ObservableObject
{
    private readonly IMedicationService _medicationService;
    public DoctorPharmacyInventoryPageViewModel(IMedicationService medicationService)
    {
        _medicationService = medicationService;
        
        _ = LoadDataAsync();
    }
    [ObservableProperty]
    private ObservableCollection<MedicationModel> medications = [];
    [ObservableProperty]
    private bool isLoading = false;
    [ObservableProperty]
    private bool isBusy = false;
    [ObservableProperty]
    private int totalItems;
    [ObservableProperty]
    private string searchText = "";
    [ObservableProperty]
    private string selectedCategory = "All Categories";
    [ObservableProperty]
    private string selectedStatus = "Status: All";
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            SelectedCategory = "All Categories";
            SelectedStatus = "Status: All";

            Medications = [.. await _medicationService.GetAllMedicationsAsync()];
            TotalItems = Medications.Count();
        }
        catch (Exception e)
        {
            MessageBox.Show($"Cannot load drugs: {e.Message}!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            IsLoading = false;
        }
    }
    [RelayCommand]
    public async Task Search(string? query)
    {
        SearchText = query ?? "";

        if (SearchText.IsNullOrEmpty())
        {
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

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
    partial void OnSelectedCategoryChanged(string value) => _ = RefreshViewAsync();
    partial void OnSearchTextChanged(string value) => _ = RefreshViewAsync();
    [RelayCommand]
    public async Task ReloadButton()
    {
        SearchText = "";
        await LoadDataAsync();
    }

    private async Task RefreshViewAsync()
    {
        IsBusy = true;
        try
        {
            IEnumerable<MedicationModel> result = [];

            if (!SearchText.IsNullOrEmpty())
                result = await _medicationService.SearchByTextAsync(SearchText);
            else
                result = await _medicationService.GetAllMedicationsAsync();

            switch (SelectedStatus)
            {
                case "✅ Available":
                    result = result.Where(m => m.StockTotalQuantity > 20);
                    break;
                case "⚠️ Low Stock":
                    result = result.Where(m => m.StockTotalQuantity <= 20 && m.StockTotalQuantity > 0);
                    break;
                case "🚫 Out of Stock":
                    result = result.Where(m => m.StockTotalQuantity == 0);
                    break;
            }

            switch (SelectedCategory)
            {
                case "Antibiotics":
                    result = result.Where(m => m.Category == Models.MedicationCategory.Antibiotic);
                    break;
                case "Painkillers":
                    result = result.Where(m => m.Category == Models.MedicationCategory.PainReliever);
                    break;
                case "Chronic Condition":
                    result = result.Where(m => m.Category == Models.MedicationCategory.ChronicCondition);
                    break;
                case "Supplement":
                    result = result.Where(m => m.Category == Models.MedicationCategory.Supplement);
                    break;
                case "Respiratory":
                    result = result.Where(m => m.Category == Models.MedicationCategory.Respiratory);
                    break;
                case "Mental Health":
                    result = result.Where(m => m.Category == Models.MedicationCategory.MentalHealth);
                    break;
                case "Allergy":
                    result = result.Where(m => m.Category == Models.MedicationCategory.Allergy);
                    break;
                case "Other":
                    result = result.Where(m => m.Category == Models.MedicationCategory.Other);
                    break;
            }

            Medications = [.. result];
        }
        finally
        {
            IsBusy = false;
        }
    }
}
