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

        public static Array LoginPermission()
       {
            ArrayList al = new ArrayList();


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
                    string[] fields = new string[rd.FieldCount];
                    for (int i = 0; i < rd.FieldCount; ++i)
                    {
                        fields[i] = rd["Permicoes_List.Nome"].ToString();
                    }
                        
                    al.Add(fields);
                   
                            
                }
                return al.ToArray();
                con.Close();

            }
        }




    }
}
