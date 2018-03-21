using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    class CaseHearingDateViewModel
    {
        public int CaseHearingId
        {
            get; set;
        }
        public string CaseId
        {
            get;
            set;
        }
        public DateTime HearingDate
        {
            get;
            set;
        }
    }
}
