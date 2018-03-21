using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class UserRoleDA
    {
        Lawyer_DatabaseEntities db;

        public UserRoleDA()
        {
            db = new Lawyer_DatabaseEntities();
        }

        public List<UserRole> getAllUserRoles() {
            return db.UserRoles.ToList();
        }

        public UserRole getUserRoles(string str)
        {
            return db.UserRoles.FirstOrDefault(x => x.roleName == str);
        }

        public void addNewRole(UserRole role)
        {
            db.UserRoles.Add(role);
            db.SaveChanges();
        }

    }
}
