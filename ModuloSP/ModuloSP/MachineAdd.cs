using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            string query = "SELECT MAX(id) FROM maquinas";
            int novoID;
            novoID = 0;
            using (SqlCeConnection con =
                new SqlCeConnection(@"DataSource=|DataDirectory|\DataModSP.sdf"))
            {
                using (SqlCeCommand cmd = new SqlCeCommand(query, con))
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

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModelo.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlCeConnection con = new
                SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf");
            con.Open();
            string query = "INSERT INTO maquinas(" +
                "id,marca,modelo,cor,dimensoes,preco)" +
                "VALUES (@id,@marca,@modelo,@cor,@dimensoes,@preco)";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
            cmd.Parameters.AddWithValue("@modelo", txtModelo.Text);
            cmd.Parameters.AddWithValue("@cor", txtCor.Text);
            cmd.Parameters.AddWithValue("@dimensoes", txtDimensoes.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
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

        private void MachineAdd_Load(object sender, EventArgs e)
        {
            InsereID();
        }
    }
}
