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
            return GetProducts("select AddOns.ID as IDA, AddOns.Descricao as dec, Modelo_AddOns.Preco_Relacao as pr " +
                               "from AddOns " +
                               "join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID " +
                               "join Modelo_AddOns on Modelo_AddOns.fk_AddOns_ID = AddOns.ID " +
                               "where Modelo_AddOns.fK_Marca_Modelo_ID = '" + Models.IDManagment.fkMarca_Modelo +  "' " +
                               "and AddOns.ID = " + _iID).First();
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
                                    ID = (int)_reader["IDA"],
                                    Descricao = _reader["dec"].ToString(),
                                    PrecoBase = (double)_reader["pr"]
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
