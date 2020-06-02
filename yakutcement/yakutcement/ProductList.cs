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
    public partial class ProductList : Form
    {
        public DBContext DB { get; set; }
        public Person User { get; set; }
        private DataGridViewCell selected_cell;

        public ProductList()
        {
            InitializeComponent();
        }

        private void ProductList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Products.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Название";
            dataGridView1.Columns[2].HeaderText = "Описание";
            dataGridView1.Columns[3].HeaderText = "Цена(в рублях)";
            if (User.Level == Level.Admin)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProduct addp = new AddProduct
            {
                DB = this.DB,
                User = this.User
            };
            addp.ShowDialog();
            dataGridView1.DataSource = DB.Products.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected_cell = dataGridView1.SelectedCells[0];
            selected_cell.ReadOnly = false;
            dataGridView1.BeginEdit(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить товар?", "Удаление", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    int product_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    IProduct.DeleteProduct(DB, product_id);
                    dataGridView1.DataSource = DB.Products.ToList();
                }
                catch (Exception)
                {
                    MessageBox.Show("Выберите строку", "Ошибка");
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            selected_cell.ReadOnly = true;
            DataGridViewRow selected_row = selected_cell.OwningRow;

            try
            {
                int id = Convert.ToInt32(selected_row.Cells[0].Value.ToString());
                string name = selected_row.Cells[1].Value.ToString();
                string description = selected_row.Cells[2].Value.ToString();
                double price = Convert.ToDouble(selected_row.Cells[3].Value.ToString());

                IProduct.EditProduct(DB, id, name, description, price);
                dataGridView1.DataSource = DB.Products.ToList();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
