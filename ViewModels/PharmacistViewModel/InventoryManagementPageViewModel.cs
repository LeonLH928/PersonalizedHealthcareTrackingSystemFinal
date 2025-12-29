using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Windows;

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
    [ObservableProperty]
    private string selectedCategory = "All Categories";
    [ObservableProperty]
    private string selectedStatus = "Status: All";
    [ObservableProperty]
    private bool isLoading = false; 
    [ObservableProperty]
    private bool isBusy = false;
    [ObservableProperty]
    private string searchText = "";
    [ObservableProperty]
    private string selectedOption = "";
    [ObservableProperty]
    private string changeQuantity = "";
    [ObservableProperty]
    private string reason = "";
    [ObservableProperty]
    private string relatedDoc = "";
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        ChangeQuantity = Reason = RelatedDoc = SelectedOption = "";
        try
        {
            SelectedCategory = "All Categories";
            SelectedStatus = "Status: All";
            Medications = [.. await _medicationService.GetAllMedicationsAsync()];
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
    public void AdjustButton(MedicationModel medication)
    {
        SelectedMedication = medication;
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

    [RelayCommand]
    public async Task SaveAdjustmentButton()
    {
        if (SelectedOption.IsNullOrEmpty())
        {
            MessageBox.Show("Please choose an option!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        if (ChangeQuantity.IsNullOrEmpty())
        {
            MessageBox.Show("Please enter a change!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        if (SelectedOption == "+ Add Stock")
            SelectedMedication.StockTotalQuantity += int.Parse(ChangeQuantity);
        else if (SelectedMedication.StockTotalQuantity - int.Parse(ChangeQuantity) >= 0)
        {
            SelectedMedication.StockTotalQuantity -= int.Parse(ChangeQuantity);
        }
        else
        {
            MessageBox.Show("Cannot substract!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        await _medicationService.UpsertMedication(SelectedMedication);
        MessageBox.Show("Update successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
        await LoadDataAsync();
    }
}
