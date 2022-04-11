﻿using System;
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
    }
}
