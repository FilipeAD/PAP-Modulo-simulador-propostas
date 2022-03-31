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
    public partial class AddOnAdd : Form
    {
        public AddOnAdd()
        {
            InitializeComponent();
        }

        private void InsereID()
        {
            // procuta último ID, acrescenta + 1 e insere na txtID
            string query = "SELECT MAX(ID) FROM AddOns";
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
      
        private void AddOnAdd_Load(object sender, EventArgs e)
        {
            InsereID();
        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            // verifica se a textbox foi preenchida
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection con = new
                SqlConnection(Utils.conString);
            con.Open();
            string query = "INSERT INTO AddOns(" +
                "id,nome,preco_base)" +
                "VALUES (@id,@nome,@preco_base)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@preco_base", txtPreco.Text);
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
            txtNome.Text = "";
            txtPreco.Text = "";
        }
    }
}
