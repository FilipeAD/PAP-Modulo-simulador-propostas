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
    public partial class MachineAdd : Form
    {
        public MachineAdd()
        {
            InitializeComponent();
        }
        private void InsereID()
        {
            // procuta último ID, acrescenta + 1 e insere na txtID
            string query = "SELECT MAX(ID) FROM Maquinas";
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

        private void InserirCmbModelo()
        {
            txtModelo.Items.Clear();
            SqlConnection con = new SqlConnection(Utils.conString);
            con.Open();
            string query = "SELECT Modelo.Nome as Modelo FROM Marca_Modelo " +
                            "INNER JOIN Modelo on Marca_Modelo.fk_Modelo_ID = Modelo.ID " +
                            "INNER JOIN Marca on Marca_Modelo.fk_Marca_ID = Marca.ID " +
                            "where Marca.Nome = '" + txtMarca.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtModelo.Items.Add(dr["Modelo"].ToString());
            }
        }

        private void Marca_Modelo()
        {
            SqlConnection con =
                    new SqlConnection(Utils.conString);
            con.Open();
            string query = "select Marca_Modelo.ID as IDMarcaModelo " +
                            "from Marca_Modelo " +
                            "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                            "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                            "where Marca.Nome = '" + txtMarca.Text + "' and Modelo.Nome = '" + txtModelo.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Utils.Marca_Modelo = dr["IDMarcaModelo"].ToString();
            }
            con.Close();


        }

        private void MachineAdd_Load(object sender, EventArgs e)
        {
            InsereID();
            InserirCmbMarca();
            
            
            
        }

        private void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModelo.Enabled = true;
            InserirCmbModelo();
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.Text = null;
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.Gray;
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (txtModelo.Text == "")
            {
                txtModelo.Text = "Modelo";
                txtModelo.ForeColor = Color.Gray;
            }
        }

        private void txtModelo_Enter(object sender, EventArgs e)
        {
            if (txtModelo.Text == "Modelo")
            {
                txtModelo.Text = null;
                txtModelo.ForeColor = Color.Black;
            }
        }

        private void txtCor_Enter(object sender, EventArgs e)
        {
            if (txtCor.Text == "Cor")
            {
                txtCor.Text = null;
                txtCor.ForeColor = Color.Black;
            }
        }

        private void txtCor_Leave(object sender, EventArgs e)
        {
            if (txtCor.Text == "")
            {
                txtCor.Text = "Cor";
                txtCor.ForeColor = Color.Gray;
            }
        }

        private void txtDimensoes_Enter(object sender, EventArgs e)
        {
            if (txtDimensoes.Text == "Dimensões")
            {
                txtDimensoes.Text = null;
                txtDimensoes.ForeColor = Color.Black;
            }
        }

        private void txtDimensoes_Leave(object sender, EventArgs e)
        {
            if (txtDimensoes.Text == "")
            {
                txtDimensoes.Text = "Dimensões";
                txtDimensoes.ForeColor = Color.Gray;
            }
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            if (txtPreco.Text == "Preço")
            {
                txtPreco.Text = null;
                txtPreco.ForeColor = Color.Black;
            }
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (txtPreco.Text == "")
            {
                txtPreco.Text = "Preço";
                txtPreco.ForeColor = Color.Gray;
            }
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            Marca_Modelo();

            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection con = new
                SqlConnection(Utils.conString);
            con.Open();
            string query = "INSERT INTO maquinas(" +
                "id,cor,dimensoes,preco,fk_Marca_modelo_id)" +
                "VALUES (@id,@cor,@dimensoes,@preco,@fk_marca_modelo_id)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@cor", txtCor.Text);
            cmd.Parameters.AddWithValue("@dimensoes", txtDimensoes.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
            cmd.Parameters.AddWithValue("@fk_marca_modelo_id", Int32.Parse(Utils.Marca_Modelo));
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
            this.Close();

        }

        
    }
}
