using DBLayer;
using Lawyer_Diary.Logic;
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
using System.Windows.Shapes;

namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        UserAthentication athentic = new UserAthentication();
        List<UserAccount> users;
        BackgroundWorker worker;
        UserAccount user;

        public LoginWindow() { InitializeComponent(); }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            users = athentic.getAllUsers();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e) { this.Close(); }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("UserName field must not be Empty", "Error");
                return;
            }
            if (txtPassword.Password == "")
            {
                MessageBox.Show("password field must not be Empty", "Error");
                return;
            }

            var data = Encoding.UTF8.GetBytes(txtPassword.Password);
            string pswrd;
            using (SHA512 sha512 = new SHA512Managed())
            {
                pswrd = BitConverter.ToString(sha512.ComputeHash(data));

            }

            try
            {
                user = users.FirstOrDefault(x => x.userName == txtUserName.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid User Name", "Error");
                return;
            }

            if (user != null)
            {
                if (txtUserName.Text == user.userName && pswrd == user.password)
                {
                    Hide();
                    LoggedInUser.Instance.Info = user;
                    MainWindow win = new MainWindow();
                    win.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Invalid Password", "Error");
                }
            }
            else
                MessageBox.Show("Invalid User Name", "Error");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerAsync();
        }
    }
}
