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
    public partial class ClientRegistration : UserControl
    {
        ClientViewModel _vm;
        List<Client> userList;
        BackgroundWorker worker;

        public ClientRegistration()
        {
            InitializeComponent();

            _vm = new ClientViewModel();
            this.DataContext = _vm;
            
        }

        private void btnClientSave_Click(object sender, RoutedEventArgs e)
        {
            if (Validation.GetHasError(txtClientCNIC) || Validation.GetHasError(txtClientFname)||
                Validation.GetHasError(txtClientContact) || Validation.GetHasError(txtClientAddress)||
                Validation.GetHasError(txtClientName))
            { 
                return;
            }

            Client client = new Client();

            client.ClientName = txtClientName.Text;
            client.ClientId = txtClientCNIC.Text;
            client.ClientFname = txtClientFname.Text;
            client.ClientContact = txtClientContact.Text;
            client.ClientAddress = new TextRange(txtClientAddress.Document.ContentStart,
                                                 txtClientAddress.Document.ContentEnd).Text;

            if (new ClientDA().insertNewClient(client))
            {
                MessageBox.Show("Sucessfully Inserted");
                txtClientName.Text = "";
                txtClientCNIC.Text = "";
                txtClientFname.Text = "";
                txtClientContact.Text = "";
                new TextRange(txtClientAddress.Document.ContentStart,
                                                     txtClientAddress.Document.ContentEnd).Text = "";
            }
            else
            {
                MessageBox.Show("Error in Registration", "Error");
            }
        }
        private void txtClientCNIC_LostFocus(object sender, RoutedEventArgs e)
        {
            bool isAvailable = false;
            foreach (Client u in userList)
            {
                if (u.ClientId == txtClientCNIC.Text)
                {
                    isAvailable = true;
                    break;
                }
            }
            if (isAvailable)
            {
                MessageBox.Show("Every User must have unique username\nThis username is already available", "Error");
                return;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            userList = new ClientDA().getAllClients();
        }
    }
}
