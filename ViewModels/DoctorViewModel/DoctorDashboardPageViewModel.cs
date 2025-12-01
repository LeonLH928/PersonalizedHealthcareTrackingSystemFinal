using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using Microsoft.Extensions.DependencyInjection;
using PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView;
using System.Collections.ObjectModel;
using System.Windows;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class DoctorDashboardPageViewModel : ObservableObject
{
    private readonly IServiceProvider _serviceProvider;
    public DoctorDashboardPageViewModel (IServiceProvider serviceProvider)
    {
        InitializeChart();
        _serviceProvider = serviceProvider;
    }
    [ObservableProperty]
    private ObservableCollection<ISeries> data = [];
    public void InitializeChart()
    {
        Data = [
            new PieSeries<double>
            {
                Name = "Finished",
                Values = [ 40 ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<double>
            {
                Name = "Upcoming",
                Values = [ 25 ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<double>
            {
                Name = "Not show up",
                Values = [ 15 ],
                MaxRadialColumnWidth = 60
            },
            new PieSeries<double>
            {
                Name = "Cancelled",
                Values = [ 10 ],
                MaxRadialColumnWidth = 60
            }
        ];
    }
    [RelayCommand]
    public void CallToTheClinicButton()
    {
        if (Application.Current.Windows.OfType<DoctorConsultationWindow>().FirstOrDefault() == null)
        {
            var Popup = _serviceProvider.GetRequiredService<DoctorConsultationWindow>();
            Popup.Show();
        }
    }
}
