using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel;

public partial class PharmacistCancelledViewModel : ObservableObject
{
    private readonly IPrescriptionService _prescriptionService;
    public PharmacistCancelledViewModel(IPrescriptionService prescriptionService)
    {
        _prescriptionService = prescriptionService;

        _ = LoadDataAsync();
    }

    [ObservableProperty]
    private ObservableCollection<PrescriptionModel> prescriptionCancelled = [];

    public async Task LoadDataAsync()
    {
        try
        {
            PrescriptionCancelled = [.. await _prescriptionService.GetAllCancelledPrescriptionsAsync()];
        }
        catch (Exception e)
        {
            MessageBox.Show($"An error occured: {e.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
