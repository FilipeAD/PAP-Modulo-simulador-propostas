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

        //Carregar informação da tabela Equipamentos
        public static void ActivityUtilizadores(DataGridView _Datagridview)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "Select Simulacoes.ID, FORMAT ( Data_Simulacao, 'dd/MM/yyyy ')  as [Data], FORMAT ( Data_Simulacao, 'HH:mm')  as [Hora], count(Equipamentos.fk_Maquinas_ID) as [Maquinas na Simulação], Utilizador.Nome " +
                               "from Equipamentos " +
                               "join Simulacoes on Simulacoes.ID = Equipamentos.fk_Simulacoes_ID " +
                               "join Utilizador on Utilizador.ID = Simulacoes.fk_Utilizador_ID " +
                               " group by Simulacoes.ID, Utilizador.Nome,  Data_Simulacao ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        //Carregar informação da tabela Equipamentos segundo o ID do utilizador selecionado apartir do evento cellClick na datagridview
        public static void ActivityUtilizador(DataGridView _Datagridview, string _IDUser)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "Select Simulacoes.ID, FORMAT ( Data_Simulacao, 'dd/MM/yyyy ')  as [Data], FORMAT ( Data_Simulacao, 'HH:mm')  as [Hora], count(Equipamentos.fk_Maquinas_ID) as [Maquinas na Simulação] " +
                               "from Equipamentos " +
                               "join Simulacoes on Simulacoes.ID = Equipamentos.fk_Simulacoes_ID " +
                               "join Utilizador on Utilizador.ID = Simulacoes.fk_Utilizador_ID " +
                               "where Utilizador.ID = " + _IDUser +
                               "group by Simulacoes.ID, Utilizador.Nome,  Data_Simulacao ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        //Carregar informação da tabela Equipamentos segundo o ID do utilizador e quando a data for maior ou igual à variavel
        public static void UtilizadorRangeDateBigger(DataGridView _Datagridview, string _IDUser, string _DATE)
        {
            using (SqlConnection con =
                    new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "Select Simulacoes.ID, FORMAT(Data_Simulacao, 'dd/MM/yyyy ') as [Data], FORMAT(Data_Simulacao, 'HH:mm') as [Hora], count(Equipamentos.fk_Maquinas_ID) as [Maquinas na Simulação] " +
                               "from Equipamentos " +
                               "join Simulacoes on Simulacoes.ID = Equipamentos.fk_Simulacoes_ID " +
                               "join Utilizador on Utilizador.ID = Simulacoes.fk_Utilizador_ID " +
                               "where Utilizador.ID = " + _IDUser +
                               " and Data_Simulacao >= '" + _DATE + " 00:00:00.000' " +
                               "group by Simulacoes.ID, Utilizador.Nome,  Data_Simulacao ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
            }
        }

        //Carregar informação da tabela Equipamentos segundo o ID do utilizador e quando a data estiver entre o intervalo de tempo criado pelas variaveis
        public static void UtilizadorRangeDateSmaller(DataGridView _Datagridview, string _IDUser, string _DATE, string _DATE2)
        {
            using (SqlConnection con =
                    new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "Select Simulacoes.ID, FORMAT(Data_Simulacao, 'dd/MM/yyyy ') as [Data], FORMAT(Data_Simulacao, 'HH:mm') as [Hora], count(Equipamentos.fk_Maquinas_ID) as [Maquinas na Simulação] " +
                               "from Equipamentos " +
                               "join Simulacoes on Simulacoes.ID = Equipamentos.fk_Simulacoes_ID " +
                               "join Utilizador on Utilizador.ID = Simulacoes.fk_Utilizador_ID " +
                               "where Utilizador.ID = " + _IDUser +
                               " and Data_Simulacao >= '" + _DATE + " 00:00:00.000' and Data_Simulacao <= '" + _DATE2 + " 00:00:00.000' " + 
                               " group by Simulacoes.ID, Utilizador.Nome,  Data_Simulacao ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
            }
        }

        //Carregar informação da tabela Utilizador segundo o ID do utilizador selecionado apartir do evento cellClick na datagridview
        public static void LoadUserEditar(string _ID, TextBox _Nome, TextBox _Email, ComboBox _Grupo)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Utilizador.Nome as Nome , Email, Grupos.Nome as Grupo FROM Utilizador " +
                           "INNER JOIN Grupos on Grupos.ID = Utilizador.fk_Grupos_ID " +
                           "where Utilizador.ID='" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _Nome.Text = dr["Nome"].ToString();
                _Email.Text = dr["Email"].ToString();
                _Grupo.Text = dr["Grupo"].ToString();
            }
            con.Close();
        }

        //Carregar informação da tabela Utilizador quando o nivel do utilizador com sessão inicada for maior que o dos outros utilizadores
        public static void INFOUser(DataGridView _data)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select Utilizador.ID, Utilizador.Nome, Email, Grupos.Nome as Grupo FROM Utilizador " +
                    "INNER JOIN Grupos on Grupos.ID = Utilizador.fk_Grupos_ID " +
                    " where Grupos.Nivel < " + Models.CurrentUser.nivel;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _data.DataSource = bs;
                con.Close();
            }
            Models.IDManagment.IdUser = "";
        }



     





    }
}
