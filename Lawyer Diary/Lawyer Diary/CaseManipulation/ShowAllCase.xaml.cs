using DBLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Lawyer_Diary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
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
    /// Interaction logic for ShowCompleteCase.xaml
    /// </summary>
    public partial class ShowAllCase : UserControl
    {
        Case selectedCase;
        List<Case> caseList;
        Case selectedForPrint;
        Court selectedForPrintCourt;
        Client selectedForPrintClient;
        BackgroundWorker worker;
        public ShowAllCase()
        {

            InitializeComponent();
            disableOpenCaseButton();
            disableDeleteBtn();
            selectedForPrint = new Case();
            selectedForPrintCourt = new Court();
            selectedForPrintClient = new Client();
        }

        private void worker_Dowork(object sender, DoWorkEventArgs e)
        {
            caseList = new CaseDA().getAllCases();
        }
        private void worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            completeCasesDataGrid.DataContext = caseList;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            #region Comment
            //var cases = from c in db.Cases
            //               join client in db.Clients
            //               on c.ClientId equals client.ClientId
            //               select new
            //               {
            //                   caseNumber = c.CaseId,
            //                   casePlaintiff = c.Plaintiff,
            //                   caseDefender = c.Defender,
            //                   caseType = c.CaseType,
            //                   caseDesc = c.CaseDiscription,
            //                   caseClient = client.ClientName
            //               };
            #endregion
            worker = new BackgroundWorker();
            worker.DoWork += worker_Dowork;
            worker.RunWorkerCompleted += worker_Completed;
            worker.RunWorkerAsync();

        }
        private void btnSearchBox_Click(object sender, RoutedEventArgs e)
        {
            if (txtSearchBox.Text == "")
            {
                MessageBox.Show("Enter CNIC");
                return;
            }
            var searchCases = caseList.Where(x => x.ClientId == txtSearchBox.Text);
            completeCasesDataGrid.DataContext = searchCases.ToList();
        }
        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            var searchCases = caseList.Where(x => x.ClientId.Contains(txtSearchBox.Text));
            completeCasesDataGrid.DataContext = searchCases.ToList();
        }
        private void btnOpenCase_Click(object sender, RoutedEventArgs e)
        {
            selectedCase = completeCasesDataGrid.SelectedItem as Case;
            CaseUpdateRecord obj = new CaseUpdateRecord(selectedCase);
            obj.ShowDialog();

        }
        private void enableOpenCaseButton() { btnOpenCase.IsEnabled = true; btnPrintCase.IsEnabled = true; }
        private void disableOpenCaseButton() { btnOpenCase.IsEnabled = false; btnPrintCase.IsEnabled = false; }
        private void completeCasesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            enableOpenCaseButton();
            enableDeleteBtn();
        }
        private void btnDeleteCase_Click(object sender, RoutedEventArgs e)
        {
            selectedCase = completeCasesDataGrid.SelectedItem as Case;
            MessageBoxResult result;
            result = MessageBox.Show("If You delete this record then you also\n" +
                                    "loose the records of this case hearings\n"
                                    + "Are you sure you want to delete this?",
                                     "Delete Confirmation", MessageBoxButton.YesNo,
                                     MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                new CaseHearingDateDA().remove(selectedCase.CaseId);
                new CaseDA().remove(selectedCase.CaseId);
                MessageBox.Show("successfully deleted", "Delete");
                UserControl_Loaded(sender, e);
            }
            else {
                MessageBox.Show("Error in  deletion");
            }
        }
        private void disableDeleteBtn() {
            btnDeleteCase.IsEnabled = false;
        }
        private void enableDeleteBtn()
        {
            if (LoggedInUser.Instance.Info.UserRole.roleName == "Admin")
                btnDeleteCase.IsEnabled = true;
            else
                btnDeleteCase.IsEnabled = false;
        }

        private void btnPrintCase_Click(object sender, RoutedEventArgs e)
        {
            var data = completeCasesDataGrid.SelectedItem as Case;
            Type type = data.GetType();

            selectedForPrint.ClientId = (string)type.GetProperty("ClientId").GetValue(data, null);
            selectedForPrint.CourtId = (Guid)type.GetProperty("CourtId").GetValue(data, null);
            selectedForPrint.CaseId = (string)type.GetProperty("CaseId").GetValue(data, null);
            selectedForPrint.CaseName = (string)type.GetProperty("CaseName").GetValue(data, null);
            selectedForPrint.CaseType = (string)type.GetProperty("CaseType").GetValue(data, null);
            selectedForPrint.Defender = (string)type.GetProperty("Defender").GetValue(data, null);
            selectedForPrint.Plaintiff = (string)type.GetProperty("Plaintiff").GetValue(data, null);
            selectedForPrint.OpponentLawyer = (string)type.GetProperty("OpponentLawyer").GetValue(data, null);
            selectedForPrint.startDate = (DateTime)type.GetProperty("startDate").GetValue(data, null);
            selectedForPrint.CaseDiscription = (string)type.GetProperty("CaseDiscription").GetValue(data, null);

            //Create table object
            selectedForPrintCourt = new CourtDA().getCourtByCourtId(selectedForPrint.CourtId);
            selectedForPrintClient = new ClientDA().getUserByClientCNIC(selectedForPrint.ClientId);

            ExportDataTableToPdf(selectedForPrint , @"E:\ProjectPrints\" + selectedForPrint.CaseId + ".pdf");
            System.Diagnostics.Process.Start(@"E:\ProjectPrints\" + selectedForPrint.CaseId + ".pdf");
            UserControl_Loaded(sender, e);
        }

        void ExportDataTableToPdf(Case myobject , String strPdfPath)
        {
            
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            document.SetMargins(20, 20, 20, 20);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            iTextSharp.text.Image imageLogo = iTextSharp.text.Image.GetInstance("D:/studdy/7th Semester/SDT/Semester Project/Lawyer Diary/Lawyer Diary/images/main.png");
            imageLogo.ScaleToFit(400, 80);
            imageLogo.SpacingAfter = 1f;
            document.Add(imageLogo);

            // Chamber Name
            BaseFont bfnChamber = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntChamber = new Font(bfnChamber, 20, 1, BaseColor.BLACK);
            iTextSharp.text.Paragraph prgCompany = new iTextSharp.text.Paragraph();
            prgCompany.Alignment = Element.ALIGN_CENTER;
            prgCompany.Add(new Chunk("Gondal Law Chamber", fntChamber));
            document.Add(prgCompany);

            //Chamber details
            iTextSharp.text.Paragraph prgDetails = new iTextSharp.text.Paragraph();
            BaseFont btnDetails = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntDetails = new Font(btnDetails, 13, 1, BaseColor.BLACK);
            prgDetails.Alignment = Element.ALIGN_CENTER;
            prgDetails.Add(new Chunk("Main Street near Library, Kchehri Rawalpindi", fntDetails));
            prgDetails.Add(new Chunk("\nPhone 0312-5197653", fntDetails));
            document.Add(prgDetails);

            //Client Details
            // fonts for Details
            BaseFont btnBOld = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntbold = new Font(btnBOld, 12, 1, BaseColor.BLACK);
            BaseFont btnsoft = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntsoft = new Font(btnsoft, 12, 2, BaseColor.DARK_GRAY);
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 20, 1, BaseColor.DARK_GRAY);

            iTextSharp.text.Paragraph prgClientInfo = new iTextSharp.text.Paragraph();
            prgClientInfo.Alignment = Element.ALIGN_LEFT;
            prgClientInfo.Add(new Chunk("\nClient Name: ", fntbold));
            prgClientInfo.Add(new Chunk("" +  selectedForPrintClient.ClientName , fntsoft));
            //prgInvoiceno.Add(new Chunk("                                                                 Customer Name:", fntbold));
            //prgInvoiceno.Add(new Chunk("" + myobject.CustomerName, fntsoft));
            document.Add(prgClientInfo);

            //Add a line seperation
            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph(new Chunk
                                        (new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F,
                                        iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);
            //Add line break
            document.Add(new Chunk("\n", fntHead));
            DataTable tableData = caseDataTable();
            PdfPTable table = new PdfPTable(tableData.Columns.Count);
            for (int i = 0; i < tableData.Rows.Count; i++)
            {
                for (int j = 0; j < tableData.Columns.Count; j++)
                {
                    table.AddCell(tableData.Rows[i][j].ToString());
                }
            }
            document.Add(table);
            document.Add(new Chunk("\n\nCase Description ", fntbold ));
            iTextSharp.text.Paragraph desc = new iTextSharp.text.Paragraph("               " + selectedForPrint.CaseDiscription);
            desc.Alignment = Element.ALIGN_JUSTIFIED;
            document.Add(desc);

            document.Close();
            writer.Close();
            fs.Close();
        }

        private DataTable caseDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("");
            table.Columns.Add("");

            table.Rows.Add("Case Number", selectedForPrint.CaseId);
            table.Rows.Add("Case Name", selectedForPrint.CaseName);
            table.Rows.Add("Defender", selectedForPrint.Defender);
            table.Rows.Add("Plaintiff", selectedForPrint.Plaintiff);
            table.Rows.Add("Starting Date", selectedForPrint.startDate.ToShortDateString());
            table.Rows.Add("Opponent Lawyer", selectedForPrint.OpponentLawyer);
            table.Rows.Add("Court Type", selectedForPrintCourt.CourtType);
            table.Rows.Add("Court City", selectedForPrintCourt.CourtCity);
            return table;

        }
    }
}
