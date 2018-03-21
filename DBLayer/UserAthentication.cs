using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBLayer
{
    public class UserAthentication
    {
        Lawyer_DatabaseEntities db;
        public UserAthentication()
        {
            db = new Lawyer_DatabaseEntities();
        }

        public List<UserAccount> getAllUsers()
        {
            return db.UserAccounts.ToList();
        }

        public UserAccount getUserByUserName(String str)
        {
            return db.UserAccounts.Where(x => x.userName == str).FirstOrDefault();
        }

        public bool deleteFromDB(UserAccount u)
        {
            MessageBoxResult result = 0;
            UserAccount employee;
            employee = db.UserAccounts.Where(x => u.userId == x.userId).FirstOrDefault();
            db.UserAccounts.Remove(employee);
            try
            {
                return db.SaveChanges() > 0;
            }
            catch (DbUpdateException e)
            {
                result = MessageBox.Show("You cannot delete this record because " +
                                         "Some Case records are associated this client ", "Information");
                return false;
            }
        }


        public bool insertNewEmployee(UserAccount user)
        {
            db.UserAccounts.Add(user);
            return db.SaveChanges() > 0;
        }

    }
}
