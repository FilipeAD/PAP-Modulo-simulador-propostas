using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Permissoes
{
    public partial class GPermissionsList : Form
    {
        public GPermissionsList()
        {
            InitializeComponent();
        }


        private void INFOPermicoes()
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "SELECT Permicoes_List.Nome as Permições, Grupos.Nome as Grupo, Estado FROM Permicoes_Gerais INNER JOIN Permicoes_List on Permicoes_List.ID = Permicoes_Gerais.fk_Permisscoes_List_ID  INNER JOIN Grupos on Grupos.ID = Permicoes_Gerais.fk_Grupos_ID where Grupos.ID != 2";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
            }
        }
        
        private void DatagridStyle()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns["Permições"].ReadOnly = true;
            dataGridView1.Columns["Grupo"].ReadOnly = true;
            this.dataGridView1.Columns["Permições"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["Grupo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["Estado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["Grupo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        private void GPermissionsList_Load(object sender, EventArgs e)
        {
            INFOPermicoes();
            DatagridStyle();
        }
    }
}
