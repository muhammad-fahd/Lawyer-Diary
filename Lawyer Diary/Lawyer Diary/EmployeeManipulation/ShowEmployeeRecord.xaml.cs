using DBLayer;
using Lawyer_Diary.Logic;
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
    /// Interaction logic for ShowEmployeeRecord.xaml
    /// </summary>
    public partial class ShowEmployeeRecord : UserControl
    {
        BackgroundWorker worker;
        List<UserAccount> userList;
        public ShowEmployeeRecord()
        {
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
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            userList = new UserAthentication().getAllUsers();
        }
        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            employeeDataGrid.DataContext = userList;
        }
        private void employeeDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { enableDUButtons(); }
        private void btnEmployeeDelete_Click(object sender, RoutedEventArgs e)
        {
            var user = (employeeDataGrid.SelectedItem as UserAccount);
            MessageBoxResult result;
            result = MessageBox.Show("Are you sure you want to delete this?",
                                     "Delete Confirmation", MessageBoxButton.YesNo,
                                     MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                if (new UserAthentication().deleteFromDB(user as UserAccount))
                {
                    MessageBox.Show("Record Deleted", "Delete");
                }
            }
        }
        private void enableDUButtons()
        {
            UserRole role;
            role = new UserRoleDA().getUserRoles("Admin");
            if (LoggedInUser.Instance.Info.RoleID == role.roleID)
            {
                btnEmployeeDelete.IsEnabled = true;
            }
        }
        private void disableDUButtons() { btnEmployeeDelete.IsEnabled = false; }
    }
}

