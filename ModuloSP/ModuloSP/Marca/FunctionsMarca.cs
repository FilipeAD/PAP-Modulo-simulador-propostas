using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Marca
{
    internal class FunctionsMarca
    {
        public static void LoadInfo(DataGridView _Database)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select * from marca";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Database.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMarca = "";
            }
        }

        public static void AddInfo(string _DatabaseN, TextBox _Nome, string _ID)
        {
           

            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO "+ _DatabaseN + " (" +
                "id,nome)" +
                "VALUES (@id,@nome)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@nome", _Nome.Text);
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

        public static void LoadMarca(string _ID, TextBox _Nome)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT * FROM Marca where ID='" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _Nome.Text = dr["nome"].ToString();
            }
        }

        public static void EditMarca(string _DatabaseN, string _ID, string _Nome)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "UPDATE " + _DatabaseN + " SET " +
                "nome=@nome " +
                " where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@nome", _Nome);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }
    }
}
