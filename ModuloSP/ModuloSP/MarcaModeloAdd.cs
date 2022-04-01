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

namespace ModuloSP
{
    public partial class MarcaModeloAdd : Form
    {
        public MarcaModeloAdd()
        {
            InitializeComponent();
        }

        private void InserirCmbMarca()
        {
            SqlConnection con = new SqlConnection(Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM Marca Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMarca.Items.Add(dr["Nome"].ToString());
            }
        }
        private void InsereIDModelo()
        {
            // procuta último ID, acrescenta + 1 e insere na txtID
            string query = "SELECT MAX(ID) FROM Modelo";
            int novoID;
            novoID = 0;
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    try
                    {
                        novoID = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                    }
                    catch
                    {
                        txtID.Text = "1";
                        return;
                    }

                    txtID.Text = novoID.ToString();
                }
                con.Close();
            }
        }
        private void InsereIDMarcaModelo()
        {
            // procuta último ID, acrescenta + 1 e insere na txtID
            string query = "SELECT MAX(ID) FROM Marca_Modelo";
            int novoID;
            novoID = 0;
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    try
                    {
                        novoID = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                    }
                    catch
                    {
                        txtID2.Text = "1";
                        return;
                    }

                    txtID2.Text = novoID.ToString();
                }
                con.Close();
            }
        }
        private void InserirModelo()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection con = new
                SqlConnection(Utils.conString);
            con.Open();
            string query = "INSERT INTO modelo(" +
                "id,nome)" +
                "VALUES (@id,@nome)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            try
            {
                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Reveja os dados que inseriu", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Registo inserido", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            con.Close();
        }
        private void GetIDMarca()
        {
            SqlConnection con = new SqlConnection(Utils.conString);
            con.Open();
            string query = "SELECT ID from Marca where nome = '" + txtMarca.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Utils.IDMarca = (dr["ID"].ToString());
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
                SqlConnection(Utils.conString);
            con.Open();
            string query = "INSERT INTO Marca_Modelo(" +
                "id, fk_Marca_ID, fk_Modelo_ID)" +
                "VALUES (@id,@fk_Marca_ID, @fk_Modelo_ID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtID2.Text);
            cmd.Parameters.AddWithValue("@fk_Marca_ID", Utils.IDMarca);
            cmd.Parameters.AddWithValue("@fk_Modelo_ID", txtID.Text );
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
            InserirCmbMarca();
            InsereIDModelo();
            InsereIDMarcaModelo();

        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = null;
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                txtNome.ForeColor = Color.Gray;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            InserirModelo();
            ConectModeloMarca();
            InsereIDModelo();
            InsereIDMarcaModelo();
        }
    }
}
