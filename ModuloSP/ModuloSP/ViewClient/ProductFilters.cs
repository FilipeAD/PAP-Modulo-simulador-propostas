using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
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

        private static string _COR = "";
        public static string COR
        {
            get { return _COR; }
            set { _COR = value; }
        }

        private static string _DIMEN = "";
        public static string DIMEN
        {
            get { return _DIMEN; }
            set { _DIMEN = value; }
        }

        private static string _MARCA = "";
        public static string MARCA
        {
            get { return _MARCA; }
            set { _MARCA = value; }
        }

        private static string _MODELO = "";
        public static string MODELO
        {
            get { return _MODELO; }
            set { _MODELO = value; }
        }

        private static string _PRECO = "";
        public static string PRECO
        {
            get { return _PRECO; }
            set { _PRECO = value; }
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


    }
}
