using CommunityToolkit.Mvvm.ComponentModel;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel.Wrappers;
public partial class MedicationAdherenceViewModel : ObservableObject
{
    public MedicationAdherenceViewModel(MedicationAdherenceModel adherence)
    {
        Adherence = adherence;
        if (Adherence.Status == Models.AdherenceStatus.Taken)
            isMarked = true;
    }
    [ObservableProperty]
    private MedicationAdherenceModel adherence = null!;
    [ObservableProperty]
    private bool isMarked = false;
}
