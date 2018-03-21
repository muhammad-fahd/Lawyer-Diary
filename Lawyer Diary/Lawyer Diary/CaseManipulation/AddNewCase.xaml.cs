using DBLayer;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using ViewModels;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.ComponentModel;
using System;

namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for AddNewCase.xaml
    /// </summary>
    public partial class AddNewCase : Window
    {
        Court court;
        Client client;
        Case newCase;
        BackgroundWorker worker;
        List<Case> caseList;
        List<Court> courtList;
        List<Client> clientList;
        CaseViewModel _vm;
        public AddNewCase()
        {
            _vm = new CaseViewModel();
            this.DataContext = _vm;
            InitializeComponent();
            newCase = new Case();
            court = new Court();
            client = new Client();
            txtErrorShow.Content = "";

        }
        private void btnCaseSave_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(txtCaseName) || Validation.GetHasError(txtCaseId) || Validation.GetHasError(txtCaseDisc)
                || Validation.GetHasError(txtCasePlaintiff) || Validation.GetHasError(txtCaseDefender)
                || cbCaseClient.SelectedIndex < 0
                || cbCaseCourtCity.SelectedIndex < 0 || cbCaseCourtType.SelectedIndex < 0 || cbCaseType.SelectedIndex < 0
                || dpCaseStartDate.SelectedDate == null || cbCaseType.Text == "Select Case Type..")
            {
                txtErrorShow.Content = "All Fields Necessary";
                return;
            }
            court = new CourtDA().getCourtsByCourtType_CourtCity(cbCaseCourtType.Text, cbCaseCourtCity.Text);

            if (court != null)
            {
                newCase.CourtId = court.CourtId;
            }
            else
            {
                MessageBox.Show("Court Data not found in your System");
                return;
            }

            newCase.CaseId = txtCaseId.Text;
            newCase.CaseName = txtCaseName.Text;
            newCase.CaseType = cbCaseType.SelectedValue.ToString();
            newCase.Defender = txtCaseDefender.Text;
            newCase.Plaintiff = txtCasePlaintiff.Text;
            newCase.OpponentLawyer = txtCaseOppLawyer.Text;
            newCase.startDate = dpCaseStartDate.SelectedDate.Value.Date;
            newCase.ClientId = cbCaseClient.SelectedValue.ToString();
            newCase.CaseDiscription = new TextRange(txtCaseDisc.Document.ContentStart,
                                                    txtCaseDisc.Document.ContentEnd).Text;
            if ((bool)cbIsCaseCompleted.IsChecked)
            {
                newCase.isComplete = true;
            }
            else {
                newCase.isComplete = false;
            }


            if (new CaseDA().insertNewCase(newCase))
            {
                MessageBox.Show("Inserted Done..");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error in Insertion..", "Error");
            }
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            caseList = new CaseDA().getAllCases();
            courtList = new CourtDA().getAllCourts();
            clientList = new ClientDA().getAllClients();
        }
        private void worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            cbCaseCourtType.ItemsSource = courtList;
            cbCaseCourtCity.ItemsSource = courtList;
            cbCaseClient.ItemsSource = clientList;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += worker_Completed;
            worker.RunWorkerAsync();
            dpCaseStartDate.DisplayDate = DateTime.Now;
            dpCaseStartDate.Text = "";
            cbCaseType.Items.Add("Select Case Type..");
            cbCaseType.Items.Add("Criminal");
            cbCaseType.Items.Add("Civilian");
            cbCaseType.Items.Add("Family");
            cbCaseType.Items.Add("RettPetition");
            cbCaseType.SelectedIndex = 0;
            cbCaseCourtType.DisplayMemberPath = "CourtType";
            cbCaseCourtType.SelectedValuePath = "CourtType";

            cbCaseCourtCity.DisplayMemberPath = "CourtCity";
            cbCaseCourtCity.SelectedValuePath = "CourtCity";

            
            cbCaseClient.DisplayMemberPath = "ClientName";
            cbCaseClient.SelectedValuePath = "ClientId";
            //dpCaseStartDate.DisplayDateStart = DateTime.Today;

        }
        private void btnCaseCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnCase_AddCourt_Click(object sender, RoutedEventArgs e)
        {
            addNewCourt newCourt = new addNewCourt();
            newCourt.ShowDialog();
        }
        private void txtCaseId_LostFocus(object sender, RoutedEventArgs e)
        {
            bool isAvailable = false;
            foreach (Case c in caseList)
            {
                if (c.CaseId == txtCaseId.Text)
                {
                    isAvailable = true;
                    break;
                }
            }

            if (isAvailable)
            {
                MessageBox.Show("Every case must have unique caseId\nThis caseId is already available", "Error");
                return;
            }
        }
    }
}
