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
    public partial class AddClient : Form
    {
        public DBContext DB { get; set; }
        public Client User { get; set; }
        public AddClient()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
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
            string Name,Addres,Email,Telephone,Inn;
            Name = textBox1.Text;
            Addres = textBox2.Text;
            Email = textBox3.Text;
            Telephone = textBox4.Text;
            try
            {
                IClient.AddClient(Name,Addres,Email,Telephone,Inn);
                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

    }
}
