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
    /// Interaction logic for UpdateCaseNextHearing.xaml
    /// </summary>
    public partial class UpdateCaseNextHearing : UserControl
    {
        IList<Case> caseForHearing;
        CaseHearingDate updateCaseHearing;
        BackgroundWorker worker;
        public UpdateCaseNextHearing()
        {
            updateCaseHearing = new CaseHearingDate();
            caseForHearing = new List<Case>();
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
           
            cbCaseIdForHearing.DisplayMemberPath = "CaseName";
            cbCaseIdForHearing.SelectedValuePath = "CaseId";
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cbCaseIdForHearing.ItemsSource = caseForHearing;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            caseForHearing = new CaseDA().getAllPendingCases();
        }

        private void btnUpdateCaseHearing_Click(object sender, RoutedEventArgs e)
        {
            
            if (cbCaseIdForHearing.SelectedIndex < 0 || dpCaseNextHearingDate.Text == null
                || dpCaseNextHearingTime.Text == null)
            {
                MessageBox.Show("All field are necessary");
                return;
            }

            updateCaseHearing.CaseId = cbCaseIdForHearing.SelectedValue.ToString();
            updateCaseHearing.HearingDate = dpCaseNextHearingDate.SelectedDate.Value.Date;

            try
            {
                DateTime dt = (DateTime)dpCaseNextHearingTime.Value;
                TimeSpan st = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
                updateCaseHearing.HearingTime = st;
            }
            catch (FormatException exe)
            {
                MessageBox.Show(exe.ToString());
            }

            if (new CaseHearingDateDA().updateCaseHearingDate(updateCaseHearing))
            {
                MessageBox.Show("Successfully Updated Hearing Date");
                cbCaseIdForHearing.SelectedIndex = 0;
                dpCaseNextHearingDate.Text = null;
                dpCaseNextHearingTime.Text = null;
            }
            else
                MessageBox.Show("Successfully Updated Hearing Date");

        }
    }
}
