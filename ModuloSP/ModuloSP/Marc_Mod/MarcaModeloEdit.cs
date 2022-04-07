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

namespace ModuloSP.Marc_Mod
{
    public partial class MarcaModeloEdit : Form
    {
        public MarcaModeloEdit()
        {
            InitializeComponent();
        }

        private void GetIDModelo()
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Modelo.ID from Marca_Modelo " +
                            "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                            "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                            "where Modelo.Nome = '" + txtNome.Text + " '";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.IDManagment.IdModelo = (dr["ID"].ToString());
            }
        }



        private void btEdit_Click(object sender, EventArgs e)
        {
            Marca.FunctionsMarca.EditMarca("Modelo", Models.IDManagment.IdModelo, txtNome.Text);
            this.Close();
        }



        private void MarcaModeloEdit_Load(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.LoadCMB(txtMarca, txtNome, Models.IDManagment.IDMarca_Modelo);
            GetIDModelo();

        }
    }
}
