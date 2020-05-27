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
            //foreach (Position j in (Position[])Enum.GetValues(typeof(Position)))
            //comboBox1.Items.Add(j);


            //foreach (Level j in (Level[])Enum.GetValues(typeof(Level)))
            //comboBox2.Items.Add(j);

            comboBox1.DataSource = Enum.GetValues(typeof(Position));
            comboBox2.DataSource = Enum.GetValues(typeof(Level));

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname, sname, lname, login, pass;
            double salary;
            int pos;
            int level;
            DateTime bDay;
            fname = textBox1.Text;
            lname = textBox2.Text;
            sname = textBox3.Text;
            salary = double.Parse(textBox4.Text.Replace(".", ","));
            login = textBox5.Text;
            pass = textBox6.Text;
            bDay = dateTimePicker1.Value;
            pos = comboBox1.SelectedIndex;
            level = comboBox2.SelectedIndex;
            try
            {
                IPerson.AddPerson(DB, fname, sname, lname, bDay, (Position)Enum.ToObject(typeof(Position), pos), salary, (Level)Enum.ToObject(typeof(Level), level), login, pass);
                Close();
            }
            catch (Exception error)
            {
                    MessageBox.Show(error.Message);
            }
        }

    }
}
