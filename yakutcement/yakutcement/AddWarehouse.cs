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
    public partial class AddWarehouse : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }
        protected List<int> persons_id = new List<int>();
        protected List<int> plants_id = new List<int>();

        public AddWarehouse()
        {
            InitializeComponent();
        }

        private void AddWarehouse_Load(object sender, EventArgs e)
        {
            List<Plant> plants = DB.Plants.ToList();
            List<Person> persons = DB.Persons.ToList();
            List<string> plant_names = new List<string>();
            List<string> person_names = new List<string>();
            for (int i = 0; i < plants.Count; i++)
            {
                plant_names.Add(plants[i].name);
                plants_id.Add(plants[i].Id);
            }
            for (int i = 0; i < persons.Count; i++)
            {
                person_names.Add(persons[i].FirstName + ' ' + persons[i].SecondName + ' ' + persons[i].LastName);
                persons_id.Add(persons[i].Id);
            }
            comboBox1.DataSource = plant_names;
            comboBox2.DataSource = person_names;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(textBox1.Text);
            try
            {
                int plant_id = plants_id[comboBox1.SelectedIndex];
                int person_id = persons_id[comboBox2.SelectedIndex];
                try
                {
                    IWarehouse.AddWarehouse(DB, value, plant_id, person_id);
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
