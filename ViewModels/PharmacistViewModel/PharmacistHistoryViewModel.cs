using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.ServiceImpls;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;

public partial class PharmacistHistoryViewModel : ObservableObject
{
    private readonly IPrescriptionService _prescriptionService;

    public PharmacistHistoryViewModel(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;

        _ = LoadDataAsync();
    }

    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionHistory = [];
    [ObservableProperty]
    private string searchText = "";
    [ObservableProperty]
    private DateTime? fromDate = null!;
    [ObservableProperty]
    private DateTime? toDate = null!;
    [ObservableProperty]
    private bool isLoading = false;
    
    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(PaginationSummary))]
    [NotifyPropertyChangedFor(nameof(CanGoNext))]
    [NotifyPropertyChangedFor(nameof(CanGoPrevious))]
    private int currentPage = 1;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(TotalPages))]
    private int pageSize = 10;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(PaginationSummary))]
    private int totalRecords = 0;

    public int TotalPages => TotalRecords == 0 ? 1 : (int)Math.Ceiling((double)TotalRecords / PageSize);

    public bool CanGoNext => CurrentPage < TotalPages;
    public bool CanGoPrevious => CurrentPage > 1;
    public string PaginationSummary
    {
        get
        {
            if (TotalRecords == 0) return "No records found";
            int start = ((CurrentPage - 1) * PageSize) + 1;
            int end = Math.Min(CurrentPage * PageSize, TotalRecords);
            return $"Showing {start}-{end} of {TotalRecords} records";
        }
    }
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        SearchText = "";
        FromDate = ToDate = null!;
        try
        {
            var data = await _prescriptionService.GetAllCompletedPrescriptionsAsync();
            ApplyFiltersAndPagination(data);
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
    public async Task ReloadButton()
    {
        await LoadDataAsync();
    }
    partial void OnFromDateChanged(DateTime? value)
    {
        _ = UpdatePrescriptions();
    }
    partial void OnToDateChanged(DateTime? value)
    {
        _ = UpdatePrescriptions();
    }
    partial void OnSearchTextChanged(string value) => _ = UpdatePrescriptions();
    [RelayCommand]
    public async Task Search(string? query)
    {
        SearchText = query ?? "";

        if (SearchText.IsNullOrEmpty())
        {
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        IsLoading = true;
        try
        {
            await UpdatePrescriptions();
        }
        finally
        {
            IsLoading = false;
        }
    }
    [RelayCommand]
    public void NextPage()
    {
        if (CanGoNext)
        {
            CurrentPage++;
            UpdateDisplayedSlice();
        }
    }

    [RelayCommand]
    public void PreviousPage()
    {
        if (CanGoPrevious)
        {
            CurrentPage--;
            UpdateDisplayedSlice();
        }
    }

    public async Task UpdatePrescriptions()
    {
        IsLoading = true;
        try
        {
            IEnumerable<PrescriptionModel> result = [];

            if (!string.IsNullOrEmpty(SearchText))
                result = await _prescriptionService.SearchByTextAsync(SearchText);
            else
            {
                var all = await _prescriptionService.GetAllPrescriptionsAsync();
                result = all.Where(p => p.Status == Models.PrescriptionStatus.Completed);
            }

            if (FromDate != null)
                result = result.Where(p => p.DispensedAt >= FromDate.Value);

            if (ToDate != null)
                result = result.Where(p => p.DispensedAt < ToDate.Value.AddDays(1));

            ApplyFiltersAndPagination(result);
        }
        finally
        {
            IsLoading = false;
        }
    }
    private List<PrescriptionModel> _allFilteredList = [];
    private void ApplyFiltersAndPagination(IEnumerable<PrescriptionModel> rawData)
    {
        _allFilteredList = rawData.OrderByDescending(x => x.DispensedAt).ToList();

        TotalRecords = _allFilteredList.Count;
        CurrentPage = 1;

        UpdateDisplayedSlice();
    }

    private void UpdateDisplayedSlice()
    {
        var slice = _allFilteredList
                    .Skip((CurrentPage - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();

        PrescriptionHistory = new ObservableCollection<PrescriptionModel>(slice);

        OnPropertyChanged(nameof(PaginationSummary));
        OnPropertyChanged(nameof(CanGoNext));
        OnPropertyChanged(nameof(CanGoPrevious));
    }
}
