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

namespace Lawyer_Diary.Hearings
{
    /// <summary>
    /// Interaction logic for HearingByDates.xaml
    /// </summary>
    public partial class HearingByDates : UserControl
    {
        Case selectedCase;
        List<CaseHearingDate> caseList;
        BackgroundWorker worker;
        public HearingByDates()
        {
            InitializeComponent();
            disableOpenCaseButton();
        }



        private void btnOpenCase_Click(object sender, RoutedEventArgs e)
        {
            CaseUpdateRecord obj = new CaseUpdateRecord(selectedCase);
            obj.ShowDialog();
        }
        private void completeCasesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            enableOpenCaseButton();
            CaseHearingDate hearing = completeCasesDataGrid.SelectedItem as CaseHearingDate;
            string caseId = hearing.CaseId;
            selectedCase = new CaseDA().getCaseByCaseId(caseId);
        }

        private void dpSelectDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = (DateTime) dpSelectDate.SelectedDate;
            caseList = new CaseHearingDateDA().getHearingByDate(date);
            completeCasesDataGrid.DataContext = caseList;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e) {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            completeCasesDataGrid.DataContext = caseList;
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            caseList = new CaseHearingDateDA().getAllHearingDate();
        }
        private void enableOpenCaseButton() { btnOpenCase.IsEnabled = true; }
        private void disableOpenCaseButton() { btnOpenCase.IsEnabled = false; }
    }
}
