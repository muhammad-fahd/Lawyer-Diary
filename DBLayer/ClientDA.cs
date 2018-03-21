using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ViewModels;

namespace DBLayer
{
    public class ClientDA
    {
        Lawyer_DatabaseEntities db;
        public ClientDA()
        {
            db = new Lawyer_DatabaseEntities();
        }

        public List<Client> getAllClients()
        {
            return db.Clients.ToList();
        }

        public Client getUserByClientName(String str)
        {
            return db.Clients.FirstOrDefault(x => x.ClientName == str);
        }

        public Client getUserByClientCNIC(String str)
        {
            return db.Clients.FirstOrDefault(x => x.ClientId == str);
        }

        public bool saveChangesToDB(Client x)
        {
            Client changeClient = db.Clients.FirstOrDefault(s => s.ClientId == x.ClientId);

            changeClient.ClientId = x.ClientId;
            changeClient.ClientName = x.ClientName;
            changeClient.ClientContact = x.ClientContact;
            changeClient.ClientFname = x.ClientFname;
            changeClient.ClientAddress = x.ClientAddress;
            return db.SaveChanges() > 0;
        }

        public bool insertNewClient(Client user)
        {
            db.Clients.Add(user);
            return db.SaveChanges() > 0;
        }

        public bool deleteFromDB(Client c)
        {
            MessageBoxResult result = 0;
            Client client;
            client = db.Clients.Where(x => c.ClientId == x.ClientId).FirstOrDefault();
            db.Clients.Remove(client);
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
            //finally{
            //    if (result == MessageBoxResult.Yes) {
            //        Case caseClient = db.Cases.Where(x => x.ClientId == client.ClientId).FirstOrDefault();
            //        db.Cases.Remove(caseClient);
            //        db.Clients.Remove(client);
            //        db.SaveChanges();
            //        MessageBox.Show("Client and Its Cases are deleted", "Confirmation");
            //    }
        }
    }

}