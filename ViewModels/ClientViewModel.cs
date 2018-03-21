using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ClientViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string _clientId;
        public string ClientId
        {
            get
            {
                return _clientId;
            }
            set
            {
                _clientId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ClientId"));
            }
        }

        private string _clientName;
        public string ClientName
        {
            get
            {
                return _clientName;
            }
            set
            {
                _clientName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ClientName"));
            }
        }
        private string _clientFname;
        public string ClientFname
        {
            get
            {
                return _clientFname;
            }
            set
            {
                _clientFname = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ClientFname"));

            }
        }
        private string _clientContact;
        public string ClientContact
        {
            get
            {
                return _clientContact;
            }
            set
            {
                _clientContact = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ClientContact"));
            }
        }
        private string _clientAddress;
        public string ClientAddress
        {
            get
            {
                return _clientAddress;
            }
            set
            {
                _clientAddress = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ClientAddress"));
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
                if (propName == "ClientId")
                {
                    if (string.IsNullOrWhiteSpace(this.ClientId))
                    {
                        result = "CNIC is required";
                    }
                    else if (ClientId != null && ClientId.IndexOf("_") != -1)
                    {
                        result = "CNIC is Incomplete";
                    }
                }
                if (propName == "ClientName")
                {
                    if (string.IsNullOrEmpty(this.ClientName))
                    {
                        result = "Name is required";
                    }
                    else if (ClientName.Length > 25)
                    {
                        result = "Name should be less then 25 Charactes";
                    }
                    else if (ClientName.Any(x => char.IsNumber(x)))
                    {
                        result = "name don't have number";
                    }
                }

                if (propName == "ClientFname")
                {
                    if (string.IsNullOrEmpty(this.ClientFname))
                    {
                        result = "Father Name is required";
                    }
                    else if (ClientFname.Length > 25)
                    {
                        result = "Father Name should be less then 25 Charactes";
                    }
                    else if (ClientFname.Any(x => char.IsNumber(x)))
                    {
                        result = "name don't have number";
                    }
                }
                if (propName == "ClientContact")
                {
                    if (string.IsNullOrWhiteSpace(this.ClientContact))
                    {
                        result = "Contact is required";
                    }
                    else if (ClientContact != null && ClientContact.IndexOf("_") != -1)
                    {
                        result = "Contact is incomplete";
                    }
                }
                if (propName == "ClientAddress")
                {
                    if (string.IsNullOrEmpty(this.ClientAddress))
                    {
                        result = "Adress is required";
                    }
                    else if (ClientAddress.Length > 60)
                    {
                        result = "Address should be less then 60 character";
                    }
                }
                return result;
            }
        }
    }
}
