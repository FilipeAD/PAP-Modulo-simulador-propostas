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

        private static string _IdMarca = "";
        public static string IdMarca
        {
            get { return _IdMarca; }
            set { _IdMarca = value; }
        }

        private static string _fkMarca_Modelo = "";
        public static string fkMarca_Modelo
        {
            get { return _fkMarca_Modelo; }
            set { _fkMarca_Modelo = value; }
        }
    }
}
