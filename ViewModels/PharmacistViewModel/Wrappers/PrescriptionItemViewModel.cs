using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PharmacistViewModel.Wrappers;
public partial class PrescriptionItemViewModel : ObservableObject
{
    public PrescriptionItemViewModel(PrescriptionItemModel item)
    {
        Item = item;
    }
    [ObservableProperty]
    private PrescriptionItemModel item = null!;
    [ObservableProperty]
    private bool isChecked = false;
}
