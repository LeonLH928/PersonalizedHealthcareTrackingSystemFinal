using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Collections.ObjectModel;

namespace PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;

public partial class DoctorDashboardPageViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<ISeries> data = [];
    public DoctorDashboardPageViewModel()
    {
        InitializeChart();
    }
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
}
