using DBLayer;
using Lawyer_Diary.Hearings;
using Lawyer_Diary.Logic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lawyer_Diary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(new TodaysHearings());
            enableAdminRole();
        }
        private void menuFileQuit_Click(object sender, RoutedEventArgs e)
        {
            LoggedInUser.Instance.Info = null;
            this.Close();
        }
        private void menuAccountLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LoggedInUser.Instance.Info = null;
            LoginWindow win = new LoginWindow();
            win.Show();
            this.Close();
        }

        private void menuAddNewEmployee_Click(object sender, RoutedEventArgs e)
        {
            EmployeeRegistration employee = new EmployeeRegistration();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(employee);
        }

        private void menuAddClient_Click(object sender, RoutedEventArgs e)
        {

            ClientRegistration client = new ClientRegistration();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(client);
        }

        private void menuaddNewCase_Click(object sender, RoutedEventArgs e)
        {
            AddNewCase newCase = new AddNewCase();
            newCase.Show();
        }

        private void btnUpdateCaseHearingFromMenu_Click(object sender, RoutedEventArgs e)
        {
            UpdateCaseNextHearing nextHearingUC = new UpdateCaseNextHearing();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(nextHearingUC);
        }

        private void menuShowClients_Click(object sender, RoutedEventArgs e)
        {
            ShowAllClients showClient = new ShowAllClients();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(showClient);
        }

        private void menuCaseCompCase_Click(object sender, RoutedEventArgs e)
        {
            ShowCompleteCase scc = new ShowCompleteCase();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(scc);
        }

        private void menuPendingCase_Click(object sender, RoutedEventArgs e)
        {
            ShowPendingCase spc = new ShowPendingCase();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(spc);
        }

        private void menuCaseAllCase_Click(object sender, RoutedEventArgs e)
        {
            ShowAllCase sac = new ShowAllCase();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(sac);
        }

        private void btnTodaysCaseHearingFromMenu_Click(object sender, RoutedEventArgs e)
        {
            TodaysHearings todayHear = new TodaysHearings();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(todayHear);
        }

        private void menuShowEmployee_Click(object sender, RoutedEventArgs e)
        {
            ShowEmployeeRecord ser = new ShowEmployeeRecord();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(ser);
        }

        private void btnTomorrowCaseHearingFromMenu_Click(object sender, RoutedEventArgs e)
        {
            TomorrosHearings obj = new TomorrosHearings();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(obj);
        }

        private void btnNextWeekCaseHearingFromMenu_Click(object sender, RoutedEventArgs e)
        {
            NextWeekHearings obj = new NextWeekHearings();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(obj);
        }
        private void btnCaseHearingByDates_Click(object sender, RoutedEventArgs e)
        {
            HearingByDates obj = new HearingByDates();
            userControleHolder.Children.Clear();
            userControleHolder.Children.Add(obj);
        }

        private void enableAdminRole()
        {
            UserRole role;
            role = new UserRoleDA().getUserRoles("Admin");
            if (LoggedInUser.Instance.Info.RoleID == role.roleID)
            {
                lblwelcomeNote.Content = "Welcome \"Admin\"\n" + LoggedInUser.Instance.Info.name;
                menuAddNewEmployee.IsEnabled = true;

            }
            else
            {
                lblwelcomeNote.Content = "Welcome \"Employee\"\n" + LoggedInUser.Instance.Info.name;
                menuAddNewEmployee.IsEnabled = false;
            }

        }
    }
}
