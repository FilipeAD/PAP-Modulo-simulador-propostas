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
    public partial class MarcaModeloAdd : Form
    {
        public MarcaModeloAdd()
        {
            InitializeComponent();
        }

        private void GetIDMarca()
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT ID from Marca where nome = '" + txtMarca.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.IDMarca = (dr["ID"].ToString());
            }
        }


        private void ConectModeloMarca()
        {
            GetIDMarca();
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO Marca_Modelo(" +
                "id, fk_Marca_ID, fk_Modelo_ID)" +
                "VALUES (@id,@fk_Marca_ID, @fk_Modelo_ID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IDMarca_Modelo);
            cmd.Parameters.AddWithValue("@fk_Marca_ID", Models.Utils.IDMarca);
            cmd.Parameters.AddWithValue("@fk_Modelo_ID", Models.IDManagment.IdModelo);
            try
            {
                cmd.ExecuteScalar();
            }
            catch
            {
                return;
            }

            

            con.Close();
            txtMarca.SelectedIndex = -1;
            txtNome.Text = "";

        }

        private void MarcaModeloAdd_Load(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.CmbInsertM("Marca", "Nome", txtMarca);
            txtMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

      
        private void btAdd_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else {
                if (AddOn.FunctionsAddOn.VField(txtMarca.Text, txtNome.Text, "verify_MarcaModelo", "@Marca", "@Modelo") == true)
                {
                    MessageBox.Show("Registo já existe.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Models.IDManagment.IDMarca_Modelo = Models.IDManagment.InsereID("Marca_Modelo");
                    Models.IDManagment.IdModelo = Models.IDManagment.InsereID("Modelo");
                    Marca.FunctionsMarca.AddInfo("Modelo", txtNome, Models.IDManagment.IdModelo);
                    ConectModeloMarca();
                    txtNome.Text = "";
                    txtMarca.SelectedIndex = -1;
                }
            }


        }

    }
}
