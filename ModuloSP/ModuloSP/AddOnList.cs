using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP
{
    public partial class AddOnList : Form
    {
        public AddOnList()
        {
            InitializeComponent();
        }


        private void INFOAddOn()
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select ID, Nome, Preco_Base from AddOns";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
            }
        }

        private void AddOnList_Load(object sender, EventArgs e)
        {
            INFOAddOn();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

        }

      

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEditar.IdAddOn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
