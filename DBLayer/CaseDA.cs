using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DBLayer
{
    public class CaseDA
    {
        Lawyer_DatabaseEntities db;
        public CaseDA()
        {
            db = new Lawyer_DatabaseEntities();
        }

        public List<Case> getAllCases()
        {
            return db.Cases.ToList();
        }

        public Case getCaseByCaseId(string str)
        {
            return db.Cases.FirstOrDefault(x => x.CaseId == str);
        }

        public bool insertNewCase(Case c)
        {

            db.Cases.Add(c);
            return db.SaveChanges() > 0;
        }


        public List<Case> getAllCompleteCases()
        {
            return db.Cases.Where(x => x.isComplete == true).ToList();
        }

        public List<Case> getAllPendingCases()
        {
            return db.Cases.Where(x => x.isComplete == false).ToList();
        }
        public bool remove(string id)
        {
            Case c = db.Cases.Where(x => x.CaseId == id).FirstOrDefault();
            db.Cases.Remove(c);
            return db.SaveChanges() > 0;

        }

        public bool saveChangesToDB(Case c)
        {
            Case changeCase = db.Cases.FirstOrDefault(x => x.CaseId == c.CaseId);

            changeCase.CaseId = c.CaseId;
            changeCase.CaseName = c.CaseName;
            changeCase.CaseType = c.CaseType;
            changeCase.ClientId = c.ClientId;
            changeCase.CourtId = c.CourtId;
            changeCase.Defender = c.Defender;
            changeCase.Plaintiff = c.Plaintiff;
            changeCase.CaseDiscription = c.CaseDiscription;
            //changeCase.CaseHearingDates = c.CaseHearingDates;
            changeCase.startDate = c.startDate;
            changeCase.isComplete = c.isComplete;
            try
            {
                return db.SaveChanges() > 0;
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
                return false;

            }
        }

    }
}
