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
    public partial class FormClient1 : Form
    {
        public DBContext DB { get; set; }
        public Client User { get; set; }

        public FormClient1()
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

        private void FormClient1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Пользователь: " + User.Name;
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientList list = new ClientList();
            list.DB = this.DB;
            list.User = this.User;
            list.Show();
        }
    }
}
