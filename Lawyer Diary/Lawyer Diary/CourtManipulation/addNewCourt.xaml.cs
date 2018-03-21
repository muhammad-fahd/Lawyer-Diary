using DBLayer;
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
using System.Windows.Shapes;

namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for addNewCourt.xaml
    /// </summary>
    public partial class addNewCourt : Window
    {

        public addNewCourt()
        {
            InitializeComponent();
        }

        private void btnCancelCourt_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSaveCourt_Click(object sender, RoutedEventArgs e)
        {
            if (txtCourtType.Text == "")
            {
                MessageBox.Show("Court Type field must not be Empty", "Error");
                txtCourtType.Focus();
                return;
            }
            if (txtCourtCity.Text == "")
            {
                MessageBox.Show("password field must not be Empty", "Error");
                txtCourtCity.Focus();
                return;
            }

            Court court = new Court();
            court.CourtId = Guid.NewGuid();
            court.CourtCity = txtCourtCity.Text;
            court.CourtType = txtCourtType.Text;

            if (new CourtDA().insertNewCourt(court))
            {
                MessageBox.Show("Court Successfuly Added to your System");
                this.Close();
            }
            else {
                MessageBox.Show("Court Successfuly Added to your System");
            }
        }
    }
}
