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
    public partial class FactoryInfo : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }
        public Plant TPlant { get; set; }
        
        public FactoryInfo()
        {
            InitializeComponent();
        }

        private void FactoryInfo_Load(object sender, EventArgs e)
        {
            /*
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            button3.Enabled = false;
            */

            textBox1.Text = TPlant.name;
            textBox2.Text = TPlant.addres;
            textBox3.Text = TPlant.telephone;
            textBox4.Text = TPlant.inn.ToString();
            textBox5.Text = TPlant.kpp.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TPlant.name = textBox1.Text;
            TPlant.addres = textBox2.Text;
            TPlant.telephone = textBox3.Text;
            TPlant.inn = Convert.ToInt32(textBox4.Text);
            TPlant.kpp = Convert.ToInt32(textBox5.Text);
            DB.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((from Plant in DB.Plants where Plant.Id == 1 select Plant).FirstOrDefault<Plant>().name.ToString());
        }
    }
}
