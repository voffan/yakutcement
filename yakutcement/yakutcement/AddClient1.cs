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
    public partial class AddClient1 : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }

        public AddClient1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name,address,telephone,email,INN;
            name = textBox1.Text;
            address = textBox2.Text;
            telephone = textBox3.Text;
            email = textBox4.Text;
            INN = textBox5.Text;
            try
            {
                //IClient.AddClient(DB, name, address, telephone, email,INN);
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void AddClient1_Load(object sender, EventArgs e)
        {

        }
    }
}
