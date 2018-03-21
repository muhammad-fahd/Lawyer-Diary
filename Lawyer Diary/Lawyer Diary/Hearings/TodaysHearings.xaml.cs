using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for TodaysHearings.xaml
    /// </summary>
    public partial class TodaysHearings : UserControl
    {
        List<CaseHearingDate> hearings;
        private Case selectedCase;
        BackgroundWorker worker;

        public TodaysHearings()
        {
           
            InitializeComponent();
            disableOpenCaseButton();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
            
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TodayhearingDataGrid.DataContext = hearings;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            hearings = new CaseHearingDateDA().getTodaysHearingDate();
        }
        private void TodayhearingDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CaseHearingDate hearing = TodayhearingDataGrid.SelectedItem as CaseHearingDate;
            selectedCase = new CaseDA().getCaseByCaseId(hearing.CaseId);
            enableOpenCaseButton();
        }
        private void btnClientSave_Click(object sender, RoutedEventArgs e)
        {
            CaseUpdateRecord obj = new CaseUpdateRecord(selectedCase);
            obj.ShowDialog();
        }
        private void enableOpenCaseButton() { btnClientSave.IsEnabled = true; }
        private void disableOpenCaseButton() { btnClientSave.IsEnabled = false; }
    }
}
