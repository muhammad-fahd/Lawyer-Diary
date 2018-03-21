using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class UserAccountViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string _userName;
        public string userName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("userName"));
            }
        }
        private string _password;
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("password"));
            }
        }
        private int _userId;
        public int userId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("userId"));
            }
        }
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("name"));
            }
        }
        private string _email;
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("email"));
            }
        }
        private string _Contact;
        public string Contact
        {
            get
            {
                return _Contact;
            }
            set
            {
                _Contact = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Contact"));
            }
        }
        private string _RoleID;
        public string RoleID
        {
            get
            {
                return _RoleID;
            }
            set
            {
                _RoleID = value;
                PropertyChanged(this, new PropertyChangedEventArgs("RoleID"));
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string propName]
        {
            get
            {
                string result = "";
                if (propName == "userName")
                {
                    if (string.IsNullOrWhiteSpace(userName))
                    {
                        result = "Username is required";
                    }
                    else if (userName.Length < 6)
                    {
                        result = "Must be greater then 6 chracter";
                    }
                    else if (userName.Length > 15)
                    {
                        result = "Must be less then 15 chracter";
                    }
                    
                }
                #region CommentedPassword Section
                //if (propName == "password")
                //{
                //    if (string.IsNullOrWhiteSpace(password))
                //    {
                //        result = "password is required";
                //    }
                //    else if (password.Length < 5)
                //    {
                //        result = "Must be greater then 6 chracter";
                //    }
                //    else if (password.Length > 10)
                //    {
                //        result = "Must be less then 10 chracter";
                //    }
                //}
                #endregion
                if (propName == "name")
                {
                    if (string.IsNullOrWhiteSpace(name))
                    {
                        result = "password is required";
                    }
                    else if (name.Length > 25)
                    {
                        result = "Must be less then 25 chracter";
                    }
                    else if (name.Any(x => char.IsNumber(x)))
                    {
                        result = "name don't have number";
                    }
                }
                if (propName == "Contact")
                {
                    if (string.IsNullOrWhiteSpace(Contact))
                    {
                        result = "Contact is required";
                    }
                    else if (Contact != null && Contact.IndexOf("_") != -1)
                    {
                        result = "Contact is incomplete";
                    }
                }
                if (propName == "email")
                {
                    var emailValid = new EmailAddressAttribute();
                    if (string.IsNullOrWhiteSpace(email))
                    {
                        result = "email is required";
                    }
                    else if (!emailValid.IsValid(email))
                    {
                        result = "email is not valid";
                    }
                }
                if (propName == "RoleID")
                {
                    if (RoleID == "Select Role" || RoleID==null)
                    {
                        result = "Contact is required";
                    }
                }
                return result;
            }
        }
    }
}
