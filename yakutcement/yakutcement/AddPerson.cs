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
    public partial class AddPerson : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }
        public AddPerson()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            ControlBox = false;
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
