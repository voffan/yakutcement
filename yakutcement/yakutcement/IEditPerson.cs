using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    public class IEditPerson
    {
        public static Person FindPerson(DBContext db, string login)
        {
            var FindedPerson = (from person in db.Persons where person.Login == login select person).FirstOrDefault<Person>();
            if (FindedPerson != null) return FindedPerson;
            else return null;
        }

        private static void DefaultPerson()
        {
            var list = new List<dynamic>();
            list.Add(new { Name = "Ньургун", SecondName = "Халыев", LastName = "Леонидович", Salry = 0, login = "BohemianRhapsody" });
            list.Add(new { Name = "Ньургун", SecondName = "Халыев", LastName = "Леонидович", Salry = 0, login = "BohemianRhapsody" });
            list.Add(new { Name = "Ньургун", SecondName = "Халыев", LastName = "Леонидович", Salry = 0, login = "BohemianRhapsody" });

            var rand = new Random();
            var random_integer = rand.Next(1, 4);


        }

        public static void EditPerson(DBContext db, string fName, string sName, string lName, DateTime bDay, Position pos, double salary, Level level, string login, string password)
        {
            // I cant do form because i dont have VS on Windows
            /*
            while (EditPersonForm_TextBox1.Text != "")
            {
                var EditingPerson = FindPerson(db, login);

            }
            */
            
        }

        public static Person Login(DBContext db, string login, string password)
        {
            var user = (from person in db.Persons where person.Login == login select person).FirstOrDefault<Person>();
            if (user != null && user.Password.CompareTo(password) == 0) return user;
            return null;
        }

   //     (DBContext db, string fName, string sName, string lName, DateTime bDay, Position pos, double salary, Level level, string login, string password)
    }
}
