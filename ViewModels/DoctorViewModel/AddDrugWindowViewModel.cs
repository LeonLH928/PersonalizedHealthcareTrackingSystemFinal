using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.IdentityModel.Tokens;
using PersonalizedHealthcareTrackingSystemFinal.Messages;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class AddDrugWindowViewModel : ObservableObject
{
    private readonly IMedicationService _medicationService;
    public AddDrugWindowViewModel(IMedicationService medicationService)
    {
        _medicationService = medicationService;

        SelectedMedications.CollectionChanged += (_, _) =>
        {
            HasMedications = SelectedMedications.Count > 0;
        };


        _ = LoadDataAsync();
    }
    [ObservableProperty]
    public bool isSelected;
    [ObservableProperty]
    public bool hasMedications;
    [ObservableProperty]
    private ObservableCollection<MedicationModel> selectedMedications = [];
    [ObservableProperty]
    private bool isBusy = true;
    [ObservableProperty]
    private ObservableCollection<MedicationModel> medications = [];
    [ObservableProperty]
    private string searchText = "";
    [ObservableProperty]
    private MedicationModel selectedMedication = null!;
    public async Task LoadDataAsync()
    {
        var medications = await _medicationService.GetAllMedications();
        Medications = [.. medications];
    }
    partial void OnSelectedMedicationChanged(MedicationModel value)
    {
        IsSelected = SelectedMedication != null;
    }
    [RelayCommand]
    public void CloseWindowButton()
    {
        Application.Current.Windows.OfType<AddDrugWindow>().FirstOrDefault()?.Close();
    }
    [RelayCommand]
    public async Task Search()
    {
        if (SearchText.IsNullOrEmpty())
            MessageBox.Show("Please enter text!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

        IsBusy = true;
        try
        {
            var medications = await _medicationService.SearchByText(SearchText);
            Medications = [.. medications];
        }
        finally
        {
            IsBusy = false;
        }
    }
    [RelayCommand]
    public async Task DeleteMedication(MedicationModel SelectedMedication)
    {
        if (SelectedMedication != null && SelectedMedications.Contains(SelectedMedication))
        {
            SelectedMedications.Remove(SelectedMedication);
        }
    }
    [RelayCommand]
    public void CancelButton()
    {
        SelectedMedication = null!;
    }
    [RelayCommand]
    public void SelectButton()
    {
        if (SelectedMedications.Contains(SelectedMedication))
        {
            MessageBox.Show("You already add the medication!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        SelectedMedications.Add(SelectedMedication);
        MessageBox.Show("Add medication successfully!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
    }
    [RelayCommand]
    public void AddDrugButton()
    {
        WeakReferenceMessenger.Default.Send(new SelectedMedicationIDsMessage(SelectedMedications.Select(m => m.MedicationID).ToList()));
        CloseWindowButton();
    }
}
