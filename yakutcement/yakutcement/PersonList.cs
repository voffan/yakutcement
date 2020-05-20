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
            /*dataGridView1.DataSource = DB.Persons.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPerson addp = new AddPerson();
            addp.DB = this.DB;
            addp.User = this.User;
            addp.ShowDialog();
        }
    }
}
