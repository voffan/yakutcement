using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakutcement
{
    public class IPerson
    {
        public static void AddPerson(DBContext db, string fName, string sName, string lName, DateTime bDay, Position pos, double salary, Level level, string login, string password)
        {

        }
        public static void DeletePerson(DBContext db, int id)
        {
            var user = (from person in db.Persons where person.Id == id select person).FirstOrDefault<Person>();
            db.Persons.Remove(user);
            db.SaveChanges();
        }
        public static Person Login(DBContext db, string login, string password)
        {
            var user = (from person in db.Persons where person.Login == login select person).FirstOrDefault<Person>();
            if (user != null && user.Password.CompareTo(password) == 0) return user;
            return null;
        }

        public static bool EditingPerson_Equals_EditorPerson_Check(Person user, Person EditingPerson)
        {
            if (user == EditingPerson) return true;
            else return false;
        }

        public static bool Admin_Check(Person user, Person EditingPerson)
        {
            if (user.Level == Level.Admin) return true;
            else return false;
        }


        public static bool EditPerson(int EditingPerson_id, Person user, DBContext db, string fName, string sName, string lName, DateTime bDay, Position pos, double salary, Level level)
        {
            var EditingPerson =(from person in db.Persons where person.Id == EditingPerson_id select person).FirstOrDefault<Person>();
            if ((EditingPerson_Equals_EditorPerson_Check(user, EditingPerson)) | (Admin_Check(user, EditingPerson)))
            {
                EditingPerson.FirstName = fName;
                EditingPerson.SecondName = sName;
                EditingPerson.LastName = lName;
                EditingPerson.BirthDate = bDay;
                if (Admin_Check(user, EditingPerson))
                {
                    EditingPerson.Position = pos;
                    EditingPerson.Salary = salary;
                    EditingPerson.Level = level;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("У вас нет прав на изменение позиции, зарплаты и уровня!");
                    return false;
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show(Convert.ToString(e));
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("У вас нет прав");
                return false;
            }
            return true;
        }   
    }
}
