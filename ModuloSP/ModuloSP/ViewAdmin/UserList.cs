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

namespace ModuloSP.ViewAdmin
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        private void INFOUser()
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select Utilizador.ID, Utilizador.Nome, Email, Grupos.Nome as Grupo FROM Utilizador "+
                    "INNER JOIN Grupos on Grupos.ID = Utilizador.fk_Grupos_ID " +
                    " where fk_Grupos_ID != 2 "; 
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
            }
        }

        private void ClientList_Load(object sender, EventArgs e)
        {
            INFOUser();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;


        }
    }
}
