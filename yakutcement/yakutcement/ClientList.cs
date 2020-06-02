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
    public partial class ClientList : Form
    {
        public DBContext DB { get; set; }
        public Client User { get; set; }

        protected DataGridViewCell selected_cell;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DB.Cleints.ToList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Имя";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected_cell = dataGridView1.SelectedCells[0];
            selected_cell.ReadOnly = false;
            dataGridView1.BeginEdit(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int client_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            IClient.DeleteClient(DB, client_id);
            ClientList_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_EndEdit(object sender, DataGridViewCellEventArgs e)
        {
            selected_cell.ReadOnly = true;

            DataGridViewRow selected_row = selected_cell.OwningRow;

            int id = Convert.ToInt32(selected_row.Cells[0].Value.ToString());
            string Name = selected_row.Cells[1].Value.ToString();
            string Address = selected_row.Cells[2].Value.ToString();
            string Telephone = selected_row.Cells[3].Value.ToString();
            string Email = selected_row.Cells[4].Value.ToString();
            string Inn = selected_row.Cells[5].Value.ToString();

            var user = (from client in DB.Clients where client.Id == id select client).FirstOrDefault<Client>();

            user.Name = Name;
            user.Address = Address;
            user.Telephone = Telephone;
            user.Email = Email;
            user.Inn = Inn;

            DB.SaveChanges();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}
