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
    public partial class MachineList : Form
    {
        public MachineList()
        {
            InitializeComponent();
        }


        private void INFOMaquinas()
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco "+
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
            }
        }
        private void MachineList_Load(object sender, EventArgs e)
        {
            INFOMaquinas();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEditar.IdMaquina = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
