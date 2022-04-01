using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.AddOn
{
    internal class FunctionsAddOn
    {
        public static void INFOAddOn(DataGridView _Datagridview )
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select ID, Nome, Preco_Base from AddOns";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
            }
        }

        public static void LoadEditInfo(string _ID, string _textbox1, string _textbox2)
        {
            SqlConnection con =
                    new SqlConnection(Utils.conString);
            con.Open();
            string query = "SELECT * FROM AddOns where ID='" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _textbox1 = dr["nome"].ToString();
                _textbox2 = dr["preco_base"].ToString();
            }
            con.Close();
        }

        public static void EditInfo(string _ID, string _textbox1, string _textbox2)
        {
            SqlConnection con = new SqlConnection(Utils.conString);
            con.Open();
            string query = "UPDATE AddOns SET " +
                "nome=@nome," +
                "preco_base=@preco_base " +
                " where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@nome", _textbox1);
            cmd.Parameters.AddWithValue("@preco_base", _textbox2);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        public static void AddInfo(string _ID, string _textbox1, string _textbox2)
        {
            Models.IDManagment.InsereID("AddOn", _ID);

            if (string.IsNullOrWhiteSpace(_textbox1) | string.IsNullOrWhiteSpace(_textbox2))
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
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@nome", _textbox1);
            cmd.Parameters.AddWithValue("@preco_base", _textbox2);
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
            _textbox1 = "";
            _textbox2 = "";
        }

    }
}
