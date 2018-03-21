using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class CaseViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private string _CaseId;
        public string CaseId
        {
            get
            {
                return _CaseId;
            }
            set
            {
                _CaseId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CaseId"));
            }
        }
        private string _CaseName;
        public string CaseName
        {
            get
            {
                return _CaseName;
            }
            set
            {
                _CaseName = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CaseName"));
            }
        }
        private string _Plaintiff;
        public string Plaintiff
        {
            get
            {
                return _Plaintiff;
            }
            set
            {
                _Plaintiff = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Plaintiff"));
            }
        }
        private string _Defender;
        public string Defender
        {
            get
            {
                return _Defender;
            }
            set
            {
                _Defender = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Defender"));
            }
        }
        private string _OpponentLawyer;
        public string OpponentLawyer
        {
            get
            {
                return _OpponentLawyer;
            }
            set
            {
                _OpponentLawyer = value;
                PropertyChanged(this, new PropertyChangedEventArgs("OpponentLawyer"));
            }
        }
        private string _CaseDiscription;
        public string CaseDiscription
        {
            get
            {
                return _CaseDiscription;
            }
            set
            {
                _CaseDiscription = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CaseDiscription"));
            }
        }
        private DateTime _startDate;
        public DateTime startDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("startDate"));
            }
        }
        private bool? _isComplete;
        public bool? isComplete
        {
            get
            {
                return _isComplete;
            }
            set
            {
                _isComplete = value;
                PropertyChanged(this, new PropertyChangedEventArgs("startDate"));
            }
        }

        private string _CaseType;
        public string CaseType
        {
            get
            {
                return _CaseType;
            }
            set
            {
                _CaseType = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CaseType"));
            }
        }

        private string _ClientId;
        public string ClientId
        {
            get
            {
                return _ClientId;
            }
            set
            {
                _ClientId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("ClientId"));
            }
        }

        private Guid _CourtId;
        public Guid CourtId
        {
            get
            {
                return _CourtId;
            }
            set
            {
                _CourtId = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CourtId"));
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        public string this[string PropName]
        {
            get
            {
                string result = "";
                if (PropName == "CaseId")
                {
                    if (string.IsNullOrWhiteSpace(CaseId))
                    {
                        result = "CaseId is required";
                    }
                    else if (CaseId.Length > 6)
                    {
                        result = "Number of digit in CaseId is less then 6";
                    }
                    else if (CaseId.Any(x => !char.IsLetterOrDigit(x)))
                    {
                        result = "CaseId just have Letter and Digit";
                    }
                }
                else if (PropName == "CaseName")
                {
                    if (string.IsNullOrEmpty(CaseName))
                    {
                        result = "CaseName is required";
                    }
                    else if (CaseName.Length > 25)
                    {
                        result = "Case Name must have less then 20 Character";
                    }
                }
                else if (PropName == "Plaintiff")
                {
                    if (string.IsNullOrEmpty(Plaintiff))
                    {
                        result = "Plaintiff is required";
                    }
                    else if (Plaintiff.Length > 25)
                    {
                        result = "Plaintiff name must have less then 25 Character";
                    }
                }
                else if (PropName == "Defender")
                {
                    if (string.IsNullOrWhiteSpace(Defender))
                    {
                        result = "Defender is required";
                    }
                    else if (Defender.Length > 25)
                    {
                        result = "Defender name must have less then 25 Character";
                    }
                }
                else if (PropName == "OpponentLawyer")
                {
                    if (string.IsNullOrWhiteSpace(OpponentLawyer))
                    {
                        result = "OpponentLawyer is required";
                    }
                    else if (OpponentLawyer.Length > 25)
                    {
                        result = "OpponentLawyer name must have less then 25 Character";
                    }
                }
                else if (PropName == "CaseDiscription")
                {
                    if (string.IsNullOrWhiteSpace(CaseDiscription))
                    {
                        result = "CaseDiscription is required";
                    }
                    else if (CaseDiscription.Length > 5000)
                    {
                        result = "CaseDiscription name must have less then 5000 Character";
                    }
                }
                else if (PropName == "CaseType")
                {
                    if (string.IsNullOrWhiteSpace(CaseType) || CaseType == "Select Case Type..")
                    {
                        result = "CaseType is required";
                    }
                }
                else if (PropName == "startDate")
                {
                    if (startDate == null)
                    {
                        result = "Starting date is required";
                    }
                }
                else if (PropName == "ClientId")
                {
                    if (this.ClientId == null)
                    {
                        result = "Client is required";
                    }
                }
                else if (PropName == "CourtId")
                {
                    if (CourtId == null )
                    {
                        result = "Court is required";
                    }
                }
                return result;
            }
        }
    }
}
