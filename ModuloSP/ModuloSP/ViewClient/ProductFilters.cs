using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewClient
{
    internal class ProductFilters
    {

        private static string _ID = "";
        public static string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private static string _IDExtensoes = "";
        public static string IDExtensoes
        {
            get { return _IDExtensoes; }
            set { _IDExtensoes = value; }
        }



        public static List<string> Extensoes = new List<string>();
        public static List<Models.VMProduct> produtos = new List<Models.VMProduct>();


        public static void ShowSimulacao(DataGridView _DataGridName, string _IDUser)
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
                _DataGridName.DataSource = bs;
                con.Close();
            }
        }

        public static List<string> ListCMB(string _Database)
        {
            List<string> al = new List<string>();

            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM " + _Database + " Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                al.Add(dr["Nome"].ToString());
            }
            con.Close();
            return al;
        }

        public static void LoadMachine(string _ID, Label _Dimensoes, Label _Preco, Label _Cor, PictureBox _Image, Label _Descricao)
        {
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT * FROM Maquinas where id='" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _Cor.Text = dr["cor"].ToString();
                _Dimensoes.Text = dr["dimensoes"].ToString();
                _Preco.Text = dr["preco"].ToString() + "€";
                _Descricao.Text = dr["Descricao"].ToString();
                byte[] data = dr["Produto_Imagem"].ToString().Length > 0 ? (byte[])(dr["Produto_Imagem"]) : Maquinas.FunctionsMaq.ConvertImageToBytes(Properties.Resources.editcolu);
                MemoryStream mem = new MemoryStream(data); 
                _Image.Image = Image.FromStream(mem);
                Models.IDManagment.fkMarca_Modelo = dr["fk_Marca_Modelo_ID"].ToString();
            }
            con.Close();
        }
     
        public static void LoadImMarcaMod(string _ID, Label _MarcaModelo)
        {
            SqlConnection con =
                   new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Marca.Nome as Marca,  Modelo.Nome as Modelo " +
                           "from Marca_Modelo " +
                           "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                           "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                           "where Marca_Modelo.ID = '" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _MarcaModelo.Text = "IMPRESSORA " + dr["Marca"].ToString() + " " + dr["Modelo"].ToString();
            }
            con.Close();
        }


        public static void ShowAddOnsGrupo(DataGridView _DataGridName, string _grupo, string _Modelo)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select AddOns.ID, Descricao as Descrição, Add_Ons_Grupos.Nome " +
                               "from AddOns " +
                               "join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID " +
                               "join Modelo_AddOns on Modelo_AddOns.fk_AddOns_ID = AddOns.ID " +
                               "where Add_Ons_Grupos.Nome = '" + _grupo + "' and Modelo_AddOns.fK_Marca_Modelo_ID = '" + _Modelo + "' order by AddOns.ID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
            }
        }

        public static void ShowAddOns(DataGridView _DataGridName, string _Modelo)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select AddOns.ID, Descricao as Descrição, Add_Ons_Grupos.Nome as Grupo, Modelo_AddOns.Preco_Relacao as [Preço]" +
                               "from AddOns " +
                               "join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID " +
                               "join Modelo_AddOns on Modelo_AddOns.fk_AddOns_ID = AddOns.ID " +
                               "where Modelo_AddOns.fK_Marca_Modelo_ID = '" + _Modelo + "' order by AddOns.ID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
            }
        }

        public static void CmbInsertM(string _Database, ToolStripComboBox _cmb)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM " + _Database + " Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }
        }

        public static void CmbOrderItems(ToolStripComboBox _cmb)
        {
            _cmb.Items.Add("Preço ASCENDENTE");
            _cmb.Items.Add("Preço DESCENDENTE");
        }

        public static void CmbColorItems(ToolStripComboBox _cmb)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select maq.Cor " +
                           "from Maquinas as maq " +
                           "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                           "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                           "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                           "Group by maq.Cor";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Cor"].ToString());
            }
        }

        public static void CmbInsertM(ToolStripComboBox _cmb)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM Marca Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }
        }

        //#------------------------------------------------------------------------------------------------------------------#
        
        public static void SortPrices(DataGridView _DataGridName, string _order)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "order by Preco " + _order;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }
        public static void ColorSelect(DataGridView _DataGridName, string _order)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where cor = '" + _order + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }
        public static void MarcaSelect(DataGridView _DataGridName, string _order)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where mar.Nome = '" + _order + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }
        public static void MarcaPrecoSelect(DataGridView _DataGridName, string _Marca, string _Preco)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where mar.Nome = '" + _Marca + "' order by Preco " + _Preco;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }
        public static void MarcaCorSelect(DataGridView _DataGridName, string _Marca, string _Cor)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where mar.Nome = '" + _Marca + "' and maq.Cor = '" + _Cor + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }
        public static void PrecoCorSelect(DataGridView _DataGridName, string _Preco, string _Cor)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where Cor = '" + _Cor + "' order by Preco " + _Preco ;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }
        public static void PrecoCorMarcaSelect(DataGridView _DataGridName, string _Preco, string _Cor, string _marca)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where maq.Cor = '" + _Cor + "' and mar.Nome = '" + _marca + "' order by Preco " + _Preco;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        //#------------------------------------------------------------------------------------------------------------------#
        
        public static void OverlayFilter(DataGridView _DataGridName, string _MainVariabel, string _OtherVariabel1, string _OtherVariabel2, string _Order, string _Cor, string _Marca)
        {
            string order;
            if (_Order == "Preço ASCENDENTE")
            {
                order = "asc";
            }
            else
            {
                order = "desc";
            }

            if (_OtherVariabel1 != "" && _OtherVariabel2 != "")
            {
                ProductFilters.PrecoCorMarcaSelect(_DataGridName, order, _Cor, _Marca);
            }
            else if (_OtherVariabel1 != "")
            {
                if (_MainVariabel == _Order)
                {
                    ProductFilters.PrecoCorSelect(_DataGridName, order, _Cor);
                }
                else if (_MainVariabel == _Cor)
                {
                    ProductFilters.MarcaCorSelect(_DataGridName, _Marca, _Cor);
                }
                else
                {
                    ProductFilters.MarcaCorSelect(_DataGridName, _Marca, _Cor);
                }
            }
            else if (_OtherVariabel2 != "")
            {
                if (_MainVariabel == _Order)
                {
                    ProductFilters.MarcaPrecoSelect(_DataGridName, _Marca, order);
                }
                else if (_MainVariabel == _Cor)
                {
                    ProductFilters.PrecoCorSelect(_DataGridName, order, _Cor);
                }
                else
                {
                    ProductFilters.MarcaPrecoSelect(_DataGridName, _Marca, order);
                }
            }
            else if (_OtherVariabel1 == "" && _OtherVariabel2 == "")
            {
                if (_MainVariabel == _Order)
                {
                    ProductFilters.SortPrices(_DataGridName, order);
                }
                else if (_MainVariabel == _Cor)
                {
                    ProductFilters.ColorSelect(_DataGridName, _Cor);
                }
                else
                {
                    ProductFilters.MarcaSelect(_DataGridName, _Marca);
                }
                
            }

        }

        //#------------------------------------------------------------------------------------------------------------------#

        public static void Simulacao()
        {
            Models.IDManagment.IdSimulacao = Models.IDManagment.InsereID("Simulacoes");

            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO Simulacoes(" +
                "id,Data_Simulacao,fk_Utilizador_id)" +
                "VALUES (@id,@Data_Simulacao,@fk_Utilizador_id)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IdSimulacao);
            cmd.Parameters.AddWithValue("@Data_Simulacao", DateTime.Now.ToLocalTime());
            cmd.Parameters.AddWithValue("@fk_Utilizador_ID", Models.CurrentUser.IDUser);
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
            con.Close();
        }







    }
}
