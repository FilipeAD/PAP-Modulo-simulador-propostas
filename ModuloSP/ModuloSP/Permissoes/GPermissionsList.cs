using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
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
                con.Open();
                string query = "SELECT Permicoes_List.Nome as Permições, Grupos.Nome as Grupo, Estado " +
                               "FROM Permicoes_Gerais " +
                               "INNER JOIN Permicoes_List on Permicoes_List.ID = Permicoes_Gerais.fk_Permisscoes_List_ID " +
                               "INNER JOIN Grupos on Grupos.ID = Permicoes_Gerais.fk_Grupos_ID " +
                               "where Grupos.ID != 2 " +
                               "order by Grupo DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["Permições"], dr["Grupo"], dr["Estado"]);
                }
                con.Close();
            }
        }
        
        private void DatagridStyle()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;

        }


        private void GPermissionsList_Load(object sender, EventArgs e)
        {
            INFOPermicoes();
            DatagridStyle();
        }
    }
}
