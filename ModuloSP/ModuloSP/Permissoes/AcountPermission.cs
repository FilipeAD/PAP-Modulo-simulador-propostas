using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static List<string> GrupoPermission()
        {
            List<string> al = new List<string>();


            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("grupoList", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
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


        public static void EditPermission(DataGridView _datagrid)
        {
            for (int item = 0; item <= _datagrid.Rows.Count - 1; item++)
            {
                using (SqlConnection con =
                    new SqlConnection(Models.Utils.conString))
                {
                    SqlCommand cmd = new SqlCommand("Update_Permissions", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@fkGrupos", Models.Utils.Grupo);
                    cmd.Parameters.AddWithValue("@estado", _datagrid.Rows[item].Cells[2].Value);
                    cmd.Parameters.AddWithValue("@fkPermissoes", item+1);
                    SqlDataReader rd = cmd.ExecuteReader();
                    con.Close();
                }
            }
        }


        public static void GetIDGrupo(string grupo)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select fk_Grupos_ID " +
                           "FROM Permissoes_Gerais " +
                           "INNER JOIN Grupos on Grupos.ID = Permissoes_Gerais.fk_Grupos_ID " +
                           "where Grupos.Nome = '" + grupo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.Grupo = dr["fk_Grupos_ID"].ToString();
            }
            con.Close();
        }


        public static void LoadInfo(DataGridView _datagrid, string _nome)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                con.Open();
                string query = "SELECT Permissoes_List.Nome as Permições, Grupos.Nome as Grupo, Estado " +
                               "FROM Permissoes_Gerais " +
                               "INNER JOIN Permissoes_List on Permissoes_List.ID = Permissoes_Gerais.fk_Permissoes_List_ID " +
                               "INNER JOIN Grupos on Grupos.ID = Permissoes_Gerais.fk_Grupos_ID " +
                               "where Grupos.Nome like '" + _nome + "%'" +
                               "order by Grupo DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    _datagrid.Rows.Add(dr["Permições"], dr["Grupo"], dr["Estado"]);
                }
                con.Close();
            }
        }

        public static void IDNivel()
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"Select nivel
                            from Grupos
                            where id =" + Models.CurrentUser.group;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.CurrentUser.nivel = dr["nivel"].ToString();
            }
            con.Close();
        }

        public static void LoadGrupo(ToolStripComboBox _cmb)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"Select nome 
                            from Grupos
                            where Nivel < " + Models.CurrentUser.nivel;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }

            
            con.Close();
        }

        public static void LoadGrupoCombobox(ComboBox _cmb)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"Select nome 
                            from Grupos
                            where Nivel < " + Models.CurrentUser.nivel;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }


            con.Close();
        }


        public static void EditGrupo(string _ID, string _Grupo)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "UPDATE Utilizador SET " +
                "fk_Grupos_ID=@fk_Grupos_ID " +
                "where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@fk_Grupos_ID", _Grupo);

            try
            {
                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Reveja os dados que inseriu", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }



    }
}
