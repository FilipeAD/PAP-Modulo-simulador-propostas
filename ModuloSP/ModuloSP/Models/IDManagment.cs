using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP.Models
{
    internal class IDManagment
    {

        public static string InsereID(string _Database)
        {

            string query = "SELECT MAX(ID) FROM " + _Database;
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    try
                    {
                        string id = (int.Parse(cmd.ExecuteScalar().ToString()) + 1).ToString();

                        con.Close();

                        return id;
                    }
                    catch
                    {
                        con.Close();

                        return "1";
                    }
                }
                
            }
        }

        private static string _IdMaquina = "";
        public static string IdMaquina
        {
            get { return _IdMaquina; }
            set { _IdMaquina = value; }
        }

        private static string _IdAddOn = "";
        public static string IdAddOn
        {
            get { return _IdAddOn; }
            set { _IdAddOn = value; }
        }

        private static string _IdAddOnMarca = "";
        public static string IdAddOnMarca
        {
            get { return _IdAddOnMarca; }
            set { _IdAddOnMarca = value; }
        }

        private static string _IdAddOnMarcaADD = "";
        public static string IdAddOnMarcaADD
        {
            get { return _IdAddOnMarcaADD; }
            set { _IdAddOnMarcaADD = value; }
        }

        private static string _IdMarca = "";
        public static string IdMarca
        {
            get { return _IdMarca; }
            set { _IdMarca = value; }
        }

        private static string _IdModelo = "";
        public static string IdModelo
        {
            get { return _IdModelo; }
            set { _IdModelo = value; }
        }

        private static string _fkMarca_Modelo = "";
        public static string fkMarca_Modelo
        {
            get { return _fkMarca_Modelo; }
            set { _fkMarca_Modelo = value; }
        }

        private static string _IDMarca_Modelo = "";
        public static string IDMarca_Modelo
        {
            get { return _IDMarca_Modelo; }
            set { _IDMarca_Modelo = value; }
        }
    }
}
