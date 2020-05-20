using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    public class IPerson
    {
        public static bool AddPerson(DBContext db, string fName, string sName, string lName, DateTime bDay, Position pos, double salary, Level level, string login, string password)
        {
            Person p = new Person()
            {
                FirstName = fName,
                SecondName = sName,
                LastName = lName,
                BirthDate = bDay,
                Position = pos,
                Salary = salary,
                Level = level,
                Login = login,
                Password = password
            };
            db.Persons.Add(p);
            db.SaveChanges();
            return true;
        }


        public static Person Login(DBContext db, string login, string password)
        {
            var user = (from person in db.Persons where person.Login == login select person).FirstOrDefault<Person>();
            if (user != null && user.Password.CompareTo(password) == 0) return user;
            return null;
        }
    }
}
