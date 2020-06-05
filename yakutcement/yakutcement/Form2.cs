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
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Person p = IPerson.Login(mainForm.DB, textBox1.Text, textBox2.Text);
                if (p == null) MessageBox.Show("Пароль или логин не верный!!!");
                else
                {
                    this.Hide();
                    mainForm.User = p;
                    mainForm.ShowDialog();
                    Close();
                }
            } catch(Exception error){
                MessageBox.Show(error.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mainForm = new Form1();
            mainForm.DB = new DBContext();
        }
    }
}
