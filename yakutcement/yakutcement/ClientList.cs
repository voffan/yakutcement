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
    public partial class ClientList : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }

        protected DataGridViewCell selected_cell;

        public ClientList()
        {
            InitializeComponent();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.Level == Level.Admin)
            {
                AddClient1 addp = new AddClient1();
                addp.DB = this.DB;
                addp.User = this.User;
                addp.ShowDialog();
                dataGridView1.DataSource = DB.Clients.ToList();
            }
            else
            {
                MessageBox.Show("You dont have permission");
            }
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название фирмы";
            dataGridView1.Columns[2].HeaderText = "Адрес";
            dataGridView1.Columns[3].HeaderText = "Контактный телефон";
            dataGridView1.Columns[4].HeaderText = "Электронная почта";
            dataGridView1.Columns[5].HeaderText = "ИНН";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
