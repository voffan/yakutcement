using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yakutcement
{
    public partial class PersonList : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }

        protected DataGridViewCell selected_cell;

        protected Dictionary<string, Position> position_dict = new Dictionary<string, Position>();

        protected Dictionary<string, Level> level_dict = new Dictionary<string, Level>();

        public PersonList()
        {
            position_dict.Add("Manager", yakutcement.Position.Manager);
            position_dict.Add("Keeper", yakutcement.Position.Keeper);
            position_dict.Add("Admin", yakutcement.Position.Admin);
            position_dict.Add("PlantMan", yakutcement.Position.PlantMan);
            position_dict.Add("QuarryMan", yakutcement.Position.QuarryMan);

            level_dict.Add("Manager", yakutcement.Level.Manager);
            level_dict.Add("Keeper", yakutcement.Level.Keeper);
            level_dict.Add("Admin", yakutcement.Level.Admin);
            level_dict.Add("PlantMan", yakutcement.Level.PlantMan);
            level_dict.Add("QuarryMan", yakutcement.Level.QuarryMan);
            level_dict.Add("Client", yakutcement.Level.Client);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PersonList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Persons.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected_cell = dataGridView1.SelectedCells[0];
            selected_cell.ReadOnly = false;
            dataGridView1.BeginEdit(false);
        }
   
        private void button4_Click(object sender, EventArgs e)
        {
            int person_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            IPerson.DeletePerson(DB, User, person_id);
            PersonList_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            selected_cell.ReadOnly = true;

            DataGridViewRow selected_row = selected_cell.OwningRow;

            int id = Convert.ToInt32(selected_row.Cells[0].Value.ToString());
            string first_name = selected_row.Cells[1].Value.ToString();
            string second_name = selected_row.Cells[2].Value.ToString();
            string last_name = selected_row.Cells[3].Value.ToString();
            DateTime birthday = Convert.ToDateTime(selected_row.Cells[4].Value.ToString());
            string position = selected_row.Cells[5].Value.ToString();
            int salary = Convert.ToInt32(selected_row.Cells[6].Value.ToString());
            string level = selected_row.Cells[7].Value.ToString();

            var user = (from person in DB.Persons where person.Id == id select person).FirstOrDefault<Person>();

            user.FirstName = first_name;
            user.SecondName = second_name;
            user.LastName = last_name;
            user.BirthDate = birthday;
            user.Salary = salary;
            try
            {
                user.Position = position_dict[position];
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            try
            {
                user.Level = level_dict[level];
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }

            DB.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
