using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    public class IClient
    {
        public static bool AddClient(DBContext db, string Name, string Address, string Email, string Telephone, string login, string password)
        {
            Client c = new Client()
            {
                Name = Name,
                Address = Address,
                Email = Email,
                Telephone = Telephone,
                Login = login,
                Password = password
            };
            db.Clients.Add(c);
            db.SaveChanges();
            return true;
        }


        public static bool DeleteCleint(DBContext db, Client user, int id)
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
		
        public static Cleint Login(DBContext db, string login, string password)
        {
            var user = (from client in db.Clients where client.Login == login select client).FirstOrDefault<Client>();
            if (user != null && user.Password.CompareTo(password) == 0) return user;
            return null;
        }
    }
}
