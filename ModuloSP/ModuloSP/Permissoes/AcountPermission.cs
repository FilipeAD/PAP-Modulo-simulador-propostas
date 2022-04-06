using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP.Permissoes
{
    class AcountPermission
    {

        public static bool LoginPermission()
       {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("group_permissons", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@group", Models.CurrentUser.group);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {

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
