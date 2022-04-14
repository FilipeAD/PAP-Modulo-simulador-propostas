using System;
using System.Collections;
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

        public static List<string> LoginPermission()
        {
            List<string> al = new List<string>();


            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("group_permissons", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@grupo", Models.CurrentUser.group);
                cmd.Parameters.AddWithValue("@estado", "True");
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    al.Add(rd["Nome"].ToString());
                }
                con.Close();
                return al;
            }
        }

        public static bool LoginView(List<string> _PermissionList, string _PermissionNome)
        {
            if (_PermissionList.Contains(_PermissionNome))
            {
                return true;
            }
            else
            {
                return false;
            }
        }






    }
}
