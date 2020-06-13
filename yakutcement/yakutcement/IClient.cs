using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    public class IClient
    {
        public static bool AddClient(DBContext db, string name, string address, string email, string tel)
        {
            Client c = new Client()
            {
                Name = name,
                Address = address,
                Email = email,
                Telephone = tel,
            };
            db.Clients.Add(c);
            db.SaveChanges();
            return true;
        }

    
        public static bool DeleteCleint(DBContext db, Person user, int id)
        {
            if (user.Level == Level.Admin && user.Id != id)
            {
                var c = (from client in db.Clients where client.Id == id select client).FirstOrDefault<Client>();
                db.Clients.Remove(c);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Person Login(DBContext db, string login, string password)
        {
            var user = (from person in db.Persons where person.Login == login select person).FirstOrDefault<Person>();
            if (user != null && user.Password.CompareTo(password) == 0) return user;
            return null;
        }
    }
}
