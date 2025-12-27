using PersonalizedHealthcareTrackingSystemFinal.ViewModels.PatientViewModel;
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

namespace PersonalizedHealthcareTrackingSystemFinal.Views.PatientView
{
    /// <summary>
    /// Interaction logic for PatientMedicalRecordsPage.xaml
    /// </summary>
    public partial class PatientMedicalRecordsPage : Page
    {
        public PatientMedicalRecordsPage(PatientMedicalRecordsPageViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
