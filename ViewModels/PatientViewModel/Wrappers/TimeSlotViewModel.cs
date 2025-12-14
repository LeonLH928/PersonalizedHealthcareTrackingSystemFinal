using CommunityToolkit.Mvvm.ComponentModel;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel.Wrappers;
public partial class TimeSlotViewModel : ObservableObject
{
    public TimeSlotViewModel(TimeOnly startSlot)
    {
        StartSlot = startSlot;
    }
    public TimeSlotViewModel(TimeOnly startSlot, bool isAvailable)
    {
        StartSlot = startSlot;
        IsAvailable = isAvailable;
    }
    [ObservableProperty]
    private TimeOnly? startSlot;
    [ObservableProperty]
    private bool isAvailable;
}