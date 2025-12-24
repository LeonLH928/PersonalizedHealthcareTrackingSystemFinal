using PersonalizedHealthcareTrackingSystemFinal.ViewModels.DoctorViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalizedHealthcareTrackingSystemFinal.Views.DoctorView
{
    /// <summary>
    /// Interaction logic for DoctorUpcomingsPage.xaml
    /// </summary>
    public partial class DoctorUpcomingsPage : Page
    {
        public DoctorUpcomingsPage(DoctorWaitingListPageViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
