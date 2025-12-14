using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalizedHealthcareTrackingSystemFinal.Services;
using PersonalizedHealthcareTrackingSystemFinal.SupabaseModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel.Wrappers;
public partial class DoctorViewModel : ObservableObject
{
    public DoctorViewModel(DoctorModel doctor)
    {
        Doctor = doctor;
    }
    [ObservableProperty]
    private DoctorModel doctor = null!;
    [ObservableProperty]
    private DoctorScheduleModel schedule = null!;
}
