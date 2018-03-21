using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class CourtDA
    {
        Lawyer_DatabaseEntities db;
        public CourtDA()
        {
            db = new Lawyer_DatabaseEntities();
        }

        public Court getCourtByCourtId(Guid id) {
            return db.Courts.Where(x => x.CourtId == id).FirstOrDefault();
        }
        public List<Court> getAllCourts()
        {
            return db.Courts.Distinct().ToList();
        }

        public List<Court> getCourtsByCourtType(string str)
        {
            return db.Courts.Where(x => x.CourtType.Contains(str)).Distinct().ToList();
        }
        public Court getCourtsByCourtType_CourtCity(string type , string city)
        {
            return db.Courts.FirstOrDefault(x => x.CourtType == type && x.CourtCity == city);
        }

        public bool insertNewCourt(Court court)
        {
            db.Courts.Add(court);
            return db.SaveChanges() > 0;
        }
    }
}
