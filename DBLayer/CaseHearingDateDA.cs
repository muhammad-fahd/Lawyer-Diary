using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class CaseHearingDateDA
    {
        Lawyer_DatabaseEntities db;
        public CaseHearingDateDA()
        {
            db = new Lawyer_DatabaseEntities();
        }

        public List<CaseHearingDate> getAllHearingDate() { return db.CaseHearingDates.ToList();}

        public List<CaseHearingDate> getOneCaseHearing(string id)
        {
            return db.CaseHearingDates.Where(x => x.CaseId == id).ToList();
        }

        public List<CaseHearingDate> getTodaysHearingDate()
        {
            return db.CaseHearingDates.Where(x=> x.HearingDate == DateTime.Today).ToList();
        }

        public bool remove(string c)
        {
            List<CaseHearingDate> list = db.CaseHearingDates.Where(x => x.CaseId == c).ToList();
            foreach (CaseHearingDate i in list) {
                db.CaseHearingDates.Remove(i);
            }
            return db.SaveChanges() > 0;
        }

        public List<CaseHearingDate> getHearingByDate(DateTime date)
        {
            return db.CaseHearingDates.Where(x => x.HearingDate == date).ToList();
        }

        public List<CaseHearingDate> getTomorrowHearingDate()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            DateTime tomorrow = new DateTime();
            TimeSpan numberOfDays = new TimeSpan(1, 0, 0, 0 , 0);
            tomorrow = date.Add(numberOfDays);
            return db.CaseHearingDates.Where(x => x.HearingDate == tomorrow.Date).ToList();
        }

        public List<CaseHearingDate> getNextWeekHearingDate()
        {
            DateTime date = new DateTime();
            date = DateTime.Now;
            DateTime week = new DateTime();
            TimeSpan numberOfDays = new TimeSpan(7, 0, 0, 0, 0);
            week = date.Add(numberOfDays);
            return db.CaseHearingDates.Where(x => x.HearingDate <= week.Date && x.HearingDate >= DateTime.Today).ToList();
        }

        public bool updateCaseHearingDate(CaseHearingDate newDate)
        {
            db.CaseHearingDates.Add(newDate);
            return db.SaveChanges() > 0;
        }
    }
}
