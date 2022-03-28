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
    public partial class AddOnEdit : Form
    {
        public AddOnEdit()
        {
            InitializeComponent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf");
            con.Open();
            string query = "UPDATE AddOns SET " +
                "nome=@nome," +
                "preco=@preco " +
                " where id=@id";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtID.Text);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@preco", txtPreco.Text);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
            this.Close();
        }

        private void AddOnEdit_Load(object sender, EventArgs e)
        {
            txtID.Text = IDEditar.IdAddOn;


            SqlCeConnection con =
                    new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf");
            con.Open();
            string query = "SELECT * FROM Addons where id='" + txtID.Text + "'";
            SqlCeCommand cmd = new SqlCeCommand(query, con);
            SqlCeDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtNome.Text = dr["nome"].ToString();
                txtPreco.Text = dr["preco"].ToString();
            }
            con.Close();
        }
    }
}
