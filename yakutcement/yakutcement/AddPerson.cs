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
    public partial class AddPerson : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }
        public AddPerson()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            var combobox1items = new Position[5];
            int i = 0;
            foreach (Position position in Enum.GetValues(typeof(Position)))
            {
                combobox1items[i] = position;
            }

            var combobox2items = new Level[6];
            i = 0;
            foreach (Level level in Enum.GetValues(typeof(Level)))
            {
                combobox2items[i] = level;
            }



            /*comboBox1.Items.Add("Менеджер");
            comboBox1.Items.Add("Кладовщик");
            comboBox1.Items.Add("Системный администратор");
            comboBox1.Items.Add("Сотрудник завода");
            comboBox1.Items.Add("Сотрудник карьера");

            comboBox2.Items.Add("Менеджер");
            comboBox2.Items.Add("Кладовщик");
            comboBox2.Items.Add("Системный администратор");
            comboBox2.Items.Add("Сотрудник завода");
            comboBox2.Items.Add("Сотрудник карьера");
            comboBox2.Items.Add("Клиент");*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname, sname, lname, login, pass;
            double salary;
            Position pos;
            Level level;
            DateTime bDay;
            fname = textBox1.Text;
            lname = textBox2.Text;
            sname = textBox3.Text;
            salary = double.Parse(textBox1.Text.Replace(".", ","));
            login = textBox5.Text;
            pass = textBox6.Text;
            bDay = dateTimePicker1.Value;
            /*pos = comboBox1.SelectedItem;
            level = from Level in Level where Level.index == comboBox2.SelectedIndex select Level;
            if (IPerson.AddPerson(DB, fname, sname, lname, bDay, pos, salary, level, login, pass))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Error");
            }*/
        }

    }
}
