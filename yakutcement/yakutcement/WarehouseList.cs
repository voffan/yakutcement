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
    public partial class WarehouseList : Form
    {
        public DBContext DB { get; set; }
        public Wherehouse Used { get; set; }
        public WarehouseList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WarehouseList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Warehouses.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Значение";
            dataGridView1.Columns[3].HeaderText = "Данные склада";
            dataGridView1.Columns[5].HeaderText = "Кладовщик";
        }
    }
}
