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
    public partial class MachineEdit : Form
    {
        public MachineEdit()
        {
            InitializeComponent();
        }

        private void Marca_Modelo()
        {
            SqlConnection con =
                    new SqlConnection(Utils.conString);
            con.Open();
            string query = "select Marca.Nome as Marca,  Modelo.Nome as Modelo " +
                           "from Marca_Modelo " + 
                           "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " + 
                           "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " + 
                           "where Marca_Modelo.ID = '" + IDEditar.fkMarca_Modelo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtMarca.Text = dr["Marca"].ToString();
                txtModelo.Text = dr["Modelo"].ToString();
            }
            con.Close();


        }

        private void loadMachine()
        {
            txtID.Text = IDEditar.IdMaquina;


            SqlConnection con =
                    new SqlConnection(Utils.conString);
            con.Open();
            string query = "SELECT * FROM Maquinas where id='" + txtID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IDEditar.fkMarca_Modelo = dr["fk_Marca_Modelo_ID"].ToString();
                txtCor.Text = dr["cor"].ToString();
                txtDimensoes.Text = dr["dimensoes"].ToString();
                txtPreco.Text = dr["preco"].ToString();
            }
            con.Close();
        }

        private void MachineEdit_Load(object sender, EventArgs e)
        {
            loadMachine();
            Marca_Modelo();
        }


        private void btEditar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Utils.conString);
            con.Open();
            string query = "UPDATE Maquinas SET " +
                "cor=@cor," +
                "dimensoes=@dimensoes," +
                "preco=@preco " +
                " where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@cor", txtCor.Text);
            cmd.Parameters.AddWithValue("@dimensoes", txtDimensoes.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            this.Close();
        }
    }
}
