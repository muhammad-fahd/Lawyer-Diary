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
using ViewModels;

namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for ClientRegistration.xaml
    /// </summary>
    public partial class ClientUpdateRecord : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private Client _client;

        public Client client
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;
                PropertyChanged(this, new PropertyChangedEventArgs("client"));
            }
        }

        public ClientUpdateRecord(Client c)
        {
            InitializeComponent();
            this.client = c;

        }
        private void btnClientSave_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtClientName.Text) || string.IsNullOrWhiteSpace(txtClientFname.Text) ||
                string.IsNullOrWhiteSpace(txtClientContact.Text) || string.IsNullOrWhiteSpace(txtClientAddress.Text))
            {
                MessageBox.Show("All Field Are Necessary", "Error");
                return;
            }

            if (new ClientDA().saveChangesToDB(_client))
            {
                MessageBox.Show("Data Updated Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Not Updated", "Error");
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = client;
        }
    }
}
