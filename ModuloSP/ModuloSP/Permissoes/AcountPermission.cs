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

        public static void EditPermission(string estado)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("Update_Permissions", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@fkGrupos", Models.Utils.Grupo);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@fkPermissoes", Models.Utils.Permissoes);
                SqlDataReader rd = cmd.ExecuteReader();
                con.Close();
            }
        
        }

        public static void GetIDGrupoPermicoes(string grupo, string permissoes)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select fk_Permisscoes_List_ID, fk_Grupos_ID " +
                           "FROM Permicoes_Gerais " +
                           "INNER JOIN Permicoes_List on Permicoes_List.ID = Permicoes_Gerais.fk_Permisscoes_List_ID " +
                           "INNER JOIN Grupos on Grupos.ID = Permicoes_Gerais.fk_Grupos_ID " +
                           "where Permicoes_List.Nome = '" + grupo + "' and Grupos.Nome = '" + permissoes + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.Grupo = dr["fk_Grupos_ID"].ToString();
                Models.Utils.Permissoes = dr["fk_Permisscoes_List_ID"].ToString();
            }
            con.Close();
        }






    }
}
