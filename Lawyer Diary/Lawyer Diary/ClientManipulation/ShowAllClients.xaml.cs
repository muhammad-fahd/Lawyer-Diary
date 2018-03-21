using DBLayer;
using Lawyer_Diary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;


namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for ShowAllClients.xaml
    /// </summary>
    public partial class ShowAllClients : UserControl
    {
        List<Client> clientList;
        BackgroundWorker worker;
        public ShowAllClients()
        {
            clientList = new List<Client>();
            InitializeComponent();
            disableDUButtons();
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
            clientDataGrid.DataContext = clientList;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            clientList = new ClientDA().getAllClients();
        }

        private void clientDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            enableDUButtons();
        }



        private void btnClientUpdate_Click(object sender, RoutedEventArgs e)
        {
            var client = (clientDataGrid.SelectedItem as Client);
            ClientUpdateRecord clientUpdt = new ClientUpdateRecord(client);
            clientUpdt.ShowDialog();

        }

        private void btnClientDelete_Click(object sender, RoutedEventArgs e)
        {
            var client = (clientDataGrid.SelectedItem as Client);
            MessageBoxResult result;
            result = MessageBox.Show("Are you sure you want to delete this?",
                                     "Delete Confirmation", MessageBoxButton.YesNo,
                                     MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (new ClientDA().deleteFromDB(client as Client))
                {
                    MessageBox.Show("Record Deleted", "Delete");
                    clientDataGrid.DataContext = clientList;
                }
            }
        }

        private void enableDUButtons()
        {
            UserRole role;
            role = new UserRoleDA().getUserRoles("Admin");
            if (LoggedInUser.Instance.Info.RoleID == role.roleID)
            {
                btnClientDelete.IsEnabled = true;
            }
            btnClientUpdate.IsEnabled = true;
        }
        private void disableDUButtons()
        {
            btnClientDelete.IsEnabled = false;
            btnClientUpdate.IsEnabled = false;
        }
    }
}
