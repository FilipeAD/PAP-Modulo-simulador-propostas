using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewAdmin
{
    internal class AdminMethods
    {

        public static string _Username = "";
        public static string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public static string _Email = "";
        public static string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public static void CmbUtilizadorItems(string _Permisson, ComboBox _cmb)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("allowed_users", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@Permission_Nome", _Permisson);
                cmd.Parameters.AddWithValue("@estado", "True");
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    _cmb.Items.Add(dr["nome"].ToString());
                }
                con.Close();
            }
        }

        public static void CmbActionsItems(ComboBox _cmb)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM Permicoes_List " + 
                           "where Nome != 'Visualizar e editar Permissões' and Nome != 'Visualizar produtos para compra' and Nome != 'Visualizar Atividade dos Utilizadores' and Nome != 'Visualizar todos os utilizadores' " +
                           "Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }
        }

        public static void ActivityUser(string _Username)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select nome, email from Utilizador where nome ='"+ _Username + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AdminMethods.Username = dr["Nome"].ToString();
                AdminMethods.Email = dr["email"].ToString();
            }
        }

        public static void ActivityMaquinas(DataGridView _Datagridview, string _cmbText)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select Maquinas.ID, Maquinas.Dimensoes, Maquinas.Cor, Modelo.Nome as [Modelo], Marca.Nome as [Marca], Preco, Utilizador.Nome as Criador ,  FORMAT (Date_Time_Added, 'dd/MM/yyyy ')  as [Data de criação] " +
                                "from Maquinas " +
                                "join Marca_Modelo on Marca_Modelo.ID = Maquinas.fk_Marca_Modelo_ID " +
                                "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                                "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                                "join Utilizador on Utilizador.ID = Maquinas.fk_Utilizador_ID " +
                                "where Utilizador.Nome = '" + _cmbText + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        public static void ActivityAddOns(DataGridView _Datagridview, string _cmbText)
        {
            using (SqlConnection con =
                    new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select  AddOns.ID,  AddOns.Nome, Preco_Base, Utilizador.Nome as Criador, FORMAT (Date_Time_Added, 'dd/MM/yyyy ')  as [Data de criação] " +
                               "from AddOns " +
                               "join Utilizador on Utilizador.ID = AddOns.fk_Utilizador_ID " +
                               "where Utilizador.Nome = '" + _cmbText + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
            }
        }


        public static void ActivityAddOnsTime(DataGridView _Datagridview, string _cmbText, MonthCalendar _DATE)
        {
            using (SqlConnection con =
                    new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select  AddOns.ID,  AddOns.Nome, Preco_Base, Utilizador.Nome as Criador, FORMAT(Date_Time_Added, 'dd/MM/yyyy ') as [Data de criação] " +
                               "from AddOns " +
                               "join Utilizador on Utilizador.ID = AddOns.fk_Utilizador_ID " +
                               "where Date_Time_Added > '" + _DATE.Text + " 00:00:00.000' and Utilizador.Nome = '" + _cmbText + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
            }
        }


    }
}
