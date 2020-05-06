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
        public static Person Login(DBContext db, string login, string password)
        {
            var user = (from person in db.Persons where person.Login == login select person).FirstOrDefault<Person>();
            if (user != null && user.Password.CompareTo(password) == 0) return user;
            return null;
        }


        // для реализации редактирования в отдельном окне 
        public static void EditPerson_Windowed(DBContext db)
        {
            static Person FindPerson(DBContext db, string login)
            {
                var FindedPerson = (from person in db.Persons where person.Login == login select person).FirstOrDefault<Person>();
                if (FindedPerson != null) return FindedPerson;
                else return null;
            }
            // для отображения дефолтных персон в текстбоксах
            static List<string> DefaultPerson()
            {
                var list = new List<dynamic>();
                list.Add(new { Name = "Ньургун", SecondName = "Халыев", LastName = "Леонидович", Salry = 0, login = "BohemianRhapsody" });
                list.Add(new { Name = "Ньургун", SecondName = "Халыев", LastName = "Леонидович", Salry = 0, login = "BohemianRhapsody" });
                list.Add(new { Name = "Ньургун", SecondName = "Халыев", LastName = "Леонидович", Salry = 0, login = "BohemianRhapsody" });

                var rand = new Random();
                var random_integer = rand.Next(0, 3);
                return list[random_integer];
            }
            // Пока что TextBox-ы - это ячейки из нашего DBContext
            // до времени, когда нормально установлю Xamarin
            // Или пока в Windows Forms нормально форму не оформим
            var login_in_textbox = "";
            if EditPersonForm_TextBox_Login.Text != login_in_textbox
            {
                login_in_textbox = EditingPersonForm_TextBox_Login.Text;
                try
                {
                    var EditingPerson = FindPerson(db, login_in_textbox);
                    EditPersonForm_TextBox_FirstName.Text = EditingPerson.FirstName;
                    EditPersonForm_TextBox_SecondName.Text = EditingPerson.SecondName;
                    EditPersonForm_TextBox_LastName.Text = EditingPerson.LastName;
                    EditPersonForm_TextBox_BirthDay.DateTime = EditingPerson.BirthDate;
                    EditPersonForm_TextBox_Position.Position = EditingPerson.Position;
                    EditPersonForm_TextBox_Salary.Double = EditingPerson.Salary;
                    EditPersonForm_TextBox_Level.Level = EditingPerson.Level;
                }
                catch { }
            }
            void EditPerson_Windowed_button_Click(object sender, EventArgs e, Person EditingPerson, Person Editor, DBContext db, string fName, string sName, string lName, DateTime bDay, Position pos, double salary, Level level, string login, string password))
            {
                if (Editor.Level > EditingPerson.Level)^(Editor = EditingPerson) EditPerson(db, fName, sName, lName, bDay, pos, salary, Level, Login, password);
                else MessageBox.Show("У вас нет прав");
            }
    

        }
        public static void EditPerson(Person EditingPerson, DBContext db, string fName, string sName, string lName, DateTime bDay, Position pos, double salary, Level level, string login, string password)
        {
            EditingPerson.FirstName = fName;
            EditingPerson.SecondName = sName;
            EditingPerson.LastName = lName;
            EditingPerson.BirthDate = bDay;
            EditingPerson.Position = pos;
            EditingPerson.Salary = salary;
            EditingPerson.Level = level;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
        }   
    }
}
