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
        public Person User { get; set; }
        public Wherehouse Place { get; set; }

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
            dataGridView1.Columns[3].HeaderText = "Завод";
            dataGridView1.Columns[5].HeaderText = "Кладовщик";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
  
        private void button2_Click(object sender, EventArgs e)
        {
            AddWarehouse addw = new AddWarehouse();
            addw.DB = this.DB;
            addw.User = this.User;
            addw.ShowDialog();
            dataGridView1.DataSource = DB.Warehouses.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int warehouse_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("Вы точно хотите удалить склад?", "Удаление", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    IWarehouse.DeleteWarehouse(DB, warehouse_id);
                    dataGridView1.DataSource = DB.Warehouses.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите строку", "Ошибка");
            }
        }
    }
}
