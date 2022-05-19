using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP.Models
{
    class Product
    {
        public int ID;
        public string Descricao;
        public double PrecoBase;

        public static Product GetProductByID(int _iID)
        {
            return GetProducts("SELECT * FROM AddOns WHERE ID = " + _iID).First();
        }

        private static List<Product> GetProducts (string _sQuery)
        {
            List<Product> _list = new List<Product>();

            using (SqlConnection _con = new SqlConnection(Models.Utils.conString))
            {
                _con.Open();

                using (SqlCommand _cmd = new SqlCommand(_sQuery, _con))
                {
                    using (SqlDataReader _reader = _cmd.ExecuteReader())
                    {
                        if (_reader.HasRows)
                        {
                            while(_reader.Read())
                            {
                                _list.Add(new Product
                                {
                                    ID = (int)_reader["ID"],
                                    Descricao = _reader["Descricao"].ToString(),
                                    PrecoBase = (double)_reader["preco_base"]
                                });
                            }
                        }
                    }
                }
            }

            return _list;
        }
    }

    class VMProduct
    {
        public int ID;
        public int quantidade;
    }
}
