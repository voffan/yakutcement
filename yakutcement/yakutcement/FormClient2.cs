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
    public partial class FormClient2 : Form
    {
        private FormClient1 mainForm;

        public FormClient2()
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
            DBContext db;
            try
            {
                db = new DBContext();
                Client c = new Client();
                c.Id = 1;
                c.Name = "ДСК";
                c.Address = "ш. Новопокровский тракт, 10";
                c.Telephone = "8(411)233-13-28";
                c.Email = "DSK@gmail.com";
                c.Inn = "644909589022";
                c.Login = "Yee";
                c.Password = "089";
                db.Clients.Add(c);
                db.SaveChanges();
            }catch(Exception error){
                // Handle error
                MessageBox.Show(error.ToString());
            }
            try
            {
                Client c = IClient.Login(mainForm.DB, textBox1.Text, textBox2.Text);
                if (c == null) MessageBox.Show("Пароль или логин не верный!!!");
                else
                {
                    this.Hide();
                    mainForm.User = c;
                    mainForm.ShowDialog();
                    Close();
                }
            } catch(Exception error){
                MessageBox.Show(error.ToString());
            }
        }

        private void FormClient2_Load(object sender, EventArgs e)
        {
            mainForm = new FormClient1();
            mainForm.DB = new DBContext();
        }
    }
}
