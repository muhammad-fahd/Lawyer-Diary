using DBLayer;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Lawyer_Diary.Logic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System;

namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for AddNewCase.xaml
    /// </summary>
    public partial class CaseUpdateRecord : Window
    {
        BackgroundWorker worker;
        Court court;
        //Client client;
        Case newCase;
        List<Case> caseList;
        List<Court> courtList;
        #region Updation
        string type = "", city = "" ;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private Case _updateCase;
        private Court selectedForPrintCourt;
        private Client selectedForPrintClient;

        public Case updateCase
        {
            get
            {
                return _updateCase;
            }
            set
            {
                _updateCase = value;
                PropertyChanged(this, new PropertyChangedEventArgs("updateCase"));
            }
        }
        #endregion
        public CaseUpdateRecord(Case uc)
        {
            this.updateCase = uc;
            newCase = new Case();
            court = new Court();
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = updateCase;
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_Completed;
            worker.RunWorkerAsync();

            cbCaseType.Items.Add("Select Case Type..");
            cbCaseType.Items.Add("Criminal");
            cbCaseType.Items.Add("Civilian");
            cbCaseType.Items.Add("Family");
            cbCaseType.Items.Add("RettPetition");
            cbCaseType.SelectedValue = updateCase.CaseType;

            cbCaseCourtType.DisplayMemberPath = "CourtType";
            cbCaseCourtType.SelectedValuePath = "CourtType";
            cbCaseCourtType.SelectedValue = updateCase.Court.CourtType;

            cbCaseCourtCity.DisplayMemberPath = "CourtCity";
            cbCaseCourtCity.SelectedValuePath = "CourtCity";
            cbCaseCourtCity.SelectedValue = updateCase.Court.CourtCity;
        }

        private void worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            cbCaseCourtType.DataContext = courtList;
            cbCaseCourtCity.DataContext = courtList;
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            caseList = new CaseDA().getAllCases();
            courtList = new CourtDA().getAllCourts();
        }

        private void btnCase_AddCourt_Click(object sender, RoutedEventArgs e)
        {
            addNewCourt newCourt = new addNewCourt();
            newCourt.ShowDialog();
            courtList = new CourtDA().getAllCourts();

            cbCaseCourtType.DataContext = courtList;
            cbCaseCourtCity.DataContext = courtList;
            cbCaseCourtType.SelectedValue = type;
            cbCaseCourtCity.SelectedValue = city;


        }

        private void btnCaseSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCaseName.Text) || string.IsNullOrWhiteSpace(txtCaseId.Text) ||
                string.IsNullOrWhiteSpace(txtCaseDisc.Text) || string.IsNullOrWhiteSpace(txtCasePlaintiff.Text) ||
                string.IsNullOrWhiteSpace(txtCaseDefender.Text) || string.IsNullOrWhiteSpace(txtCaseOppLawyer.Text)
                || cbCaseCourtCity.SelectedIndex < 0 || cbCaseCourtType.SelectedIndex < 0 || cbCaseType.SelectedIndex < 0
                || dpCaseStartDate.SelectedDate == null || cbCaseType.Text == "Select Case Type..")
            {
                MessageBox.Show("All Fields Are Necessary");
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

            if (new CaseDA().saveChangesToDB(updateCase))
            {
                MessageBox.Show("Record Updated..", "Information");
                this.Close();
            }
            else {
                MessageBox.Show("Record not updated..", "Information");
            }
        }

        private void btnCaseCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnPrintCase_Click(object sender, RoutedEventArgs e)
        {
            #region ;;;;;
            //string heading = "Gondal Law Chamber";

            ////string fileName = Path.Combine("@C:\\Users\\Lawyer Diary", "CaseFile.pdf");
            //string fileName = "CaseFile.pdf";
            //FileStream fileStream = new FileStream(fileName , FileMode.Create, FileAccess.Write, FileShare.None);
            //Document document = new Document(PageSize.A4, 36, 36, 60 , 60);
            //PdfWriter writer = PdfWriter.GetInstance(document, fileStream);
            //document.Open();

            //BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1250 , BaseFont.NOT_EMBEDDED);
            //Font headFont = new Font(baseFont, 13 ,  Font.NORMAL);
            //iTextSharp.text.Paragraph headingParagraph = new iTextSharp.text.Paragraph();
            //headingParagraph.Alignment = Element.ALIGN_LEFT;
            //headingParagraph.Add(new Chunk(heading.ToUpper() , headFont));
            //document.Add(headingParagraph);

            //iTextSharp.text.Paragraph discription = new iTextSharp.text.Paragraph();
            //BaseFont tableBaseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //Font tableFont = new Font(baseFont, 12, 1, BaseColor.BLACK);
            //discription.Alignment = Element.ALIGN_LEFT;
            //BaseFont tableBaseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //Font tableFont = new Font(baseFont, 12, 1, BaseColor.WHITE);
            #endregion

            //iTextSharp.text.Paragraph Line = new iTextSharp.text.Paragraph(
            //                                            new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(
            //                                                0.0F , 100.0F, BaseColor.GRAY , Element.ALIGN_JUSTIFIED , 1))    
            //                                            );
            //document.Add(Line);
            //document.Add(new Chunk("\n"));

            //PdfPTable pdfTable = new PdfPTable(table.Columns.Count);


            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    for (int j = 0; j < table.Columns.Count; j++)
            //    {
            //        pdfTable.AddCell(table.Rows[i][j].ToString());
            //    }
            //}
            //iTextSharp.text.Paragraph caseDiscription = new iTextSharp.text.Paragraph("       " + updateCase.CaseDiscription);
            //caseDiscription.Alignment = Element.ALIGN_JUSTIFIED;
            //pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            ////pdfTable.LockedWidth = true;
            ////float[] widths = new float[] { 60f, 60f };
            ////pdfTable.SetWidths(widths);

            //document.Add(pdfTable);
            //document.Add(new Chunk("\n\n"));
            //document.Add(new iTextSharp.text.Paragraph(new Chunk("Case Discription" , headFont)));
            //document.Add(caseDiscription);
            ////iTextSharp.text.Paragraph printingDate = new iTextSharp.text.Paragraph("Date: " + System.DateTime.Now);
            ////printingDate.Alignment = Element.ALIGN_BOTTOM;
            //document.Close();
            selectedForPrintCourt = new CourtDA().getCourtByCourtId(updateCase.CourtId);
            selectedForPrintClient = new ClientDA().getUserByClientCNIC(updateCase.ClientId);

            ExportDataTableToPdf(updateCase, @"E:\ProjectPrints\" + updateCase.CaseId + ".pdf");
            System.Diagnostics.Process.Start(@"E:\ProjectPrints\" + updateCase.CaseId + ".pdf");
            //UserControl_Loaded(sender, e);



        }
        private void ExportDataTableToPdf(Case myobject, String strPdfPath)
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
            prgClientInfo.Add(new Chunk("" + selectedForPrintClient.ClientName, fntsoft));
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
            document.Add(new Chunk("\n\nCase Description ", fntbold));
            iTextSharp.text.Paragraph desc = new iTextSharp.text.Paragraph("               " + updateCase.CaseDiscription);
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

            table.Rows.Add("Case Number", updateCase.CaseId);
            table.Rows.Add("Case Name", updateCase.CaseName);
            table.Rows.Add("Defender", updateCase.Defender);
            table.Rows.Add("Plaintiff", updateCase.Plaintiff);
            table.Rows.Add("Starting Date", updateCase.startDate.ToShortDateString());
            table.Rows.Add("Opponent Lawyer", updateCase.OpponentLawyer);
            table.Rows.Add("Court Type", selectedForPrintCourt.CourtType);
            table.Rows.Add("Court City", selectedForPrintCourt.CourtCity);
            return table;

        }
    }
}
