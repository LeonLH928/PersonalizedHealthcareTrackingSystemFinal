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
    private string selectedCategory = "";
    [ObservableProperty]
    private string selectedStatus = "";
    public async Task LoadDataAsync()
    {
        IsLoading = true;
        try
        {
            Medications = [.. await _medicationService.GetAllMedications()];
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
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        IsBusy = true;
        try
        {
            //await RefreshViewAsync();
        }
        finally
        {
            IsBusy = false;
        }
    }

    //partial void OnSelectedStatusChanged(string value) => _ = RefreshViewAsync();
    //partial void OnSelectedCategoryChanged(string value) => _ = RefreshViewAsync();
    //partial void OnSearchTextChanged(string value) => _ = RefreshViewAsync();

    //private async Task RefreshViewAsync()
    //{
    //    IsBusy = true;
    //    try
    //    {
    //        IEnumerable<AppointmentModel> query = [];
    //        if (!SearchText.IsNullOrEmpty())
    //            query = await _medicationService.SearchByText(SearchText);

    //        IEnumerable<AppointmentModel> result = [];

    //        switch (SelectedStatus)
    //        {
    //            case "All Status":
    //                await LoadDataAsync();
    //                return;
    //            case "Happening":
    //                result = await _appointmentService.GetHappeningAppointmentByDoctorIDAsync(_doctor.DoctorID);
    //                break;
    //            case "Scheduled":
    //                result = await _appointmentService.GetUpcomingAppointmentsByDoctorIDAsync(_doctor.DoctorID);
    //                break;
    //            case "Completed":
    //                result = await _appointmentService.GetCompletedAppointmentsByDoctorIDAsync(_doctor.DoctorID);
    //                break;
    //            case "Cancelled":
    //                result = await _appointmentService.GetCancelledAppointmentsByDoctorIDAsync(_doctor.DoctorID);
    //                break;
    //            case "Not show up":
    //                result = await _appointmentService.GetNotShowUpAppointmentsByDoctorIDAsync(_doctor.DoctorID);
    //                break;
    //        }

    //        IEnumerable<string> listIDs = result.Select(a => a.AppointmentID);

    //        if (query.IsNullOrEmpty())
    //            query = result;
    //        else
    //            query = query.Where(a => listIDs.Contains(a.AppointmentID));

    //        switch (SelectedSort)
    //        {
    //            case "Sort: Latest":
    //                query = query.OrderByDescending(a => a.AppointmentDateTime);
    //                break;
    //            case "Sort: Name A-Z":
    //                query = query.OrderBy(a => a.Patient.User.FirstName);
    //                break;
    //        }

    //        Appointments = new ObservableCollection<AppointmentModel>(query);
    //    }
    //    finally
    //    {
    //        IsBusy = false;
    //    }
    //}

}
