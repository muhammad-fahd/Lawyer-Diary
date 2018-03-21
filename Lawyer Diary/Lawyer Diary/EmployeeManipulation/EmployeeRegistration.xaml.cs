using DBLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for EmployeeRegistration.xaml
    /// </summary>
    public partial class EmployeeRegistration : UserControl
    {
        UserAccountViewModel _vm;
        List<UserAccount> userList;
        BackgroundWorker worker;
        List<UserRole> rolesList;
        public EmployeeRegistration()
        {
            _vm = new UserAccountViewModel();
            this.DataContext = _vm;
            InitializeComponent();
        }

        private void btnEmployeeSave_Click(object sender, RoutedEventArgs e)
        {
            if  (Validation.GetHasError(txtUserName) || txtPassword.Password == "" || txtPasswordConfirm.Password == ""
                || Validation.GetHasError(txtName) || Validation.GetHasError(txtEmail)|| Validation.GetHasError(txtContatc)
                || Validation.GetHasError(cbUserRole))
            {
                return;
            }
            if (txtPasswordConfirm.Password != txtPassword.Password)
            {
                MessageBox.Show("Confirm Password and Password Field not matched", "Error");
                return;
            }

            UserAccount newUser = new UserAccount();
            newUser.name = txtName.Text;
            newUser.userName = txtUserName.Text;
            newUser.email = txtEmail.Text;
            newUser.Contact = txtContatc.Text;

            var data = Encoding.UTF8.GetBytes(txtPassword.Password);
            string pswrd;
            using (SHA512 sha512 = new SHA512Managed())
            {
                pswrd = BitConverter.ToString(sha512.ComputeHash(data));

            }
            newUser.password = pswrd;
            newUser.RoleID = cbUserRole.SelectedValue.ToString();
            if (new UserAthentication().insertNewEmployee(newUser))
            {
                MessageBox.Show("Data Inserted..\nUserName:  " + txtUserName.Text);
                txtName.Text = "";
                txtUserName.Text = "";
                txtEmail.Text = "";
                txtContatc.Text = "";
                txtPassword.Password = "";
                txtPasswordConfirm.Password = "";
                cbUserRole.SelectedValue = "";
            }
            else
                MessageBox.Show("Error in Insertion", "Error");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
            cbUserRole.DisplayMemberPath = "roleName";
            cbUserRole.SelectedValuePath = "roleID";
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cbUserRole.ItemsSource = rolesList;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            userList = new UserAthentication().getAllUsers();
            rolesList = new UserRoleDA().getAllUserRoles();
        }

        private void txtUserName_LostFocus(object sender, RoutedEventArgs e)
        {
            bool isAvailable = false;
            foreach (UserAccount u in userList)
            {
                if (u.userName == txtUserName.Text)
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

        private void txtPasswordConfirm_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password != txtPasswordConfirm.Password)
            {
                MessageBox.Show("Password not matched");
                return;
            }
        }
    }


}
