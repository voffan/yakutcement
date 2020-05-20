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
    public partial class Form1 : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here will be help window!!!");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //toolStripStatusLabel1.Text = "Пользователь: " + User.LastName + " " + User.FirstName + " " + User.SecondName;
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonList list = new PersonList();
            list.DB = this.DB;
            list.User = this.User;
            list.Show();
        }
    }
}
