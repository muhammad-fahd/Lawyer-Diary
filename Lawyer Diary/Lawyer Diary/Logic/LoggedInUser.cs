using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer_Diary.Logic
{
    class LoggedInUser
    {
        public DBLayer.UserAccount Info;
        private static LoggedInUser instance;

        private LoggedInUser() { }

        public static LoggedInUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoggedInUser();
                return instance;
            }
        }
    }
}
