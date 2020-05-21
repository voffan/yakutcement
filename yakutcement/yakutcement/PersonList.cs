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
        
        public PersonList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PersonList_Load(object sender, EventArgs e)
        {
            if (User.Level == Level.Admin)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            dataGridView1.DataSource = DB.Persons.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "День рождения";
            dataGridView1.Columns[5].HeaderText = "Позиция";
            dataGridView1.Columns[6].HeaderText = "Зарплата (USD)";
            dataGridView1.Columns[7].HeaderText = "Уровень доступа";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (User.Level == Level.Admin)
            {
                AddPerson addp = new AddPerson();
                addp.DB = this.DB;
                addp.User = this.User;
                addp.ShowDialog();
                dataGridView1.DataSource = DB.Persons.ToList();
            }
            else 
            {
                MessageBox.Show("You dont have permission");
            }
        }
    }
}
