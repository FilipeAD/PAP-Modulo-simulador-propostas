using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Models
{
    internal class Utilizador
    {
        public static bool LoginAcount(string _Username, string _Password)
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("user_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@user", _Username);
                cmd.Parameters.AddWithValue("@pass", _Password);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        CurrentUser.IDUser = rd["ID"].ToString();
                        CurrentUser.username = rd["Nome"].ToString();
                        CurrentUser.email = rd["email"].ToString();
                        CurrentUser.group = rd["fk_Grupos_ID"].ToString();
                    }
                    return true;
                    con.Close();
                }
                else
                {
                    return false;
                    con.Close();
                }

            }
        }
    }
    
}
