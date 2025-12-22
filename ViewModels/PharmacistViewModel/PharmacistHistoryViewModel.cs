using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
    public async Task LoadDataAsync()
    {
        try
        {
            PrescriptionHistory = [.. await _prescriptionService.GetAllCompletedPrescriptionsAsync()];
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}