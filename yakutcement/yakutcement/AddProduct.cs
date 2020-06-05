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
    public partial class AddProduct : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }
        public AddProduct()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                string description = textBox2.Text;
                double price = Convert.ToDouble(textBox3.Text);
                try
                {
                    IProduct.AddProduct(DB, name, description, price);
                    Close();
                }catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}