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
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select AddOns.ID, Descricao, Preco_Base, Add_Ons_Grupos.Nome " +
                               "from AddOns " +
                               "left join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
                Models.IDManagment.IdAddOn = "";
            }
        }

        public static void LoadEditInfo(string _ID, TextBox _textbox1, TextBox _textbox2)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT * FROM AddOns where ID = '" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.GrupoAddOn = dr["fk_Add_Ons_Grupos_ID"].ToString();
                _textbox1.Text = dr["Descricao"].ToString();
                _textbox2.Text = dr["preco_base"].ToString();
            }
            con.Close();
        }

        public static void EditInfo(string _ID, string _textbox1, string _textbox2, string _Grupo)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "UPDATE AddOns SET " +
                "Descricao=@Descricao," +
                "preco_base=@preco_base, " +
                "fk_Add_Ons_Grupos_ID=@fk_Add_Ons_Grupos_ID " +
                " where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@Descricao", _textbox1);
            cmd.Parameters.AddWithValue("@preco_base", _textbox2);
            cmd.Parameters.AddWithValue("@fk_Add_Ons_Grupos_ID", _Grupo);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        public static void AddInfo( string _textbox1, string _textbox2, string _currentUserID, string _Grupo)
        {
            Models.IDManagment.IdAddOn = Models.IDManagment.InsereID("AddOns");

           
            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO AddOns(" +
                "id,Descricao,preco_base,fk_Utilizador_id,fk_Add_Ons_Grupos_ID,Date_Time_Adicionado)" +
                "VALUES (@id,@Descricao,@preco_base,@fk_Utilizador_id,@fk_Add_Ons_Grupos_ID,@Date_Time_Adicionado)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IdAddOn);
            cmd.Parameters.AddWithValue("@Descricao", _textbox1);
            cmd.Parameters.AddWithValue("@preco_base", _textbox2);
            cmd.Parameters.AddWithValue("@fk_Utilizador_id", _currentUserID);
            cmd.Parameters.AddWithValue("@fk_Add_Ons_Grupos_ID", _Grupo);
            cmd.Parameters.AddWithValue("@Date_Time_Adicionado", DateTime.Now.ToLocalTime());
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


        public static void GroupId(string _cmb)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Add_Ons_Grupos.ID as IDGrupo " +
                           "From Add_Ons_Grupos " +
                           "where Add_Ons_Grupos.Nome = '" + _cmb + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.GrupoAddOn = dr["IDGrupo"].ToString();
            }
            con.Close();

        }


        public static void GroupLoad(string _fkID, ComboBox _txtGrupo)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Add_Ons_Grupos.Nome as Grupo " +
                           "From Add_Ons_Grupos " +
                           "where Add_Ons_Grupos.ID = '" + _fkID + "'"; 
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _txtGrupo.Text = dr["Grupo"].ToString();
            }
            con.Close();

        }


    }
}
