using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Marc_Mod
{
    internal class FunctionMarMod
    {
        public static void LoadMarMod(DataGridView _DataGridName)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select Marca_Modelo.ID, Marca.Nome, Modelo.Nome as Modelo " +
                                "from Marca_Modelo " +
                                "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                                "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IDMarca_Modelo = "";
            }
        }

        public static bool RepeatedValue(string _txt1, string _txt2)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("verify_MarcaModelo", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@Marca", _txt1);
                cmd.Parameters.AddWithValue("@Modelo", _txt2);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    con.Close();
                    return false;
                    
                }

            }
        }

    }
        
}

