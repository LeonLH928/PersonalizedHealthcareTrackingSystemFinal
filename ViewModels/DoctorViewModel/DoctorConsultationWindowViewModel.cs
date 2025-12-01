using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;
public partial class DoctorConsultationWindowViewModel : ObservableObject
{
    [RelayCommand]
    public void CloseWindowButton()
    {
        Application.Current.Windows.OfType<DoctorConsultationWindow>().FirstOrDefault()?.Close();
    }
}
