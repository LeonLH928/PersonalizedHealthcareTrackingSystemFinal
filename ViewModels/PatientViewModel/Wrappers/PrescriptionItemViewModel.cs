using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Text.Json.Nodes;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel.Wrappers;
public partial class PrescriptionItemViewModel : ObservableObject
{
    public PrescriptionItemViewModel(PrescriptionItemModel item, string when)
    {
        PrescriptionItem = item;
        When = when;
        if (When == "as_needed")
            IsTaken = true;
    }
    [ObservableProperty]
    private PrescriptionItemModel prescriptionItem = null!;
    [ObservableProperty]
    private string when = "";
    [ObservableProperty]
    private bool isTaken = false;
}
