using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloSP.Models
{
    internal class Utilizador
    {
        public string Username;
        public string Password;

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
                }
                else
                {
                    return false;
                }
                con.Close();
            }
        }

        //public static bool CreateAcount(string _Username, string _Email, string _Password)
        //{
        //    int novoID = 0;
        //    int Rmail = 0;
        //    int RUsername = 0;

        //        using (SqlConnection con =
        //            new SqlConnection(Utils.conString))
        //        {
        //            DataTable dt = new DataTable();
        //            BindingSource bs = new BindingSource();
        //            string query = "SELECT * from Utilizador where Nome = '" + txtUsername.Text.Trim() + "'";
        //            SqlDataAdapter da = new SqlDataAdapter(query, con);
        //            da.Fill(dt);
        //            if (dt.Rows.Count == 1)
        //            {
        //                RUsername = 1;
        //            }
        //            else
        //            {
        //                RUsername = 0;
        //            }
        //            con.Close();
        //        }
        //    }
        //    private void REmail()
        //    {
        //        using (SqlConnection con =
        //            new SqlConnection(Utils.conString))
        //        {
        //            DataTable dt = new DataTable();
        //            BindingSource bs = new BindingSource();
        //            string query = "SELECT * from Utilizador where Email = '" + txtEmail.Text.Trim() + "'";
        //            SqlDataAdapter da = new SqlDataAdapter(query, con);
        //            da.Fill(dt);
        //            if (dt.Rows.Count == 1)
        //            {
        //                Rmail = 1;

        //            }
        //            else
        //            {
        //                Rmail = 0;
        //            }
        //            con.Close();
        //        }
        //    }
    }
        
    
}
