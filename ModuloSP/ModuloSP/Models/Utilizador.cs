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
        //Iniciar sessão se username e passwword sejam validos
        public static bool LoginAcount(string _Username, string _Password)
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                SqlCommand cmd = new SqlCommand("user_login", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@user", _Username);
                cmd.Parameters.AddWithValue("@pass", Models.Encrypt.Cryptography.Encrypt(_Password));
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

        //Verificar se campo já existe apartir de stored procedure na BD
        public static bool VField(TextBox _textbox, string _Procedure, string _field)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand(_Procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue(_field, _textbox.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        //Verificar se o endereço email é valido
        public static bool ValidEmail(string _email)
        {
            try
            {
                var enderecoEmail = new System.Net.Mail.MailAddress(_email);
                return enderecoEmail.Address == _email;
            }
            catch
            {
                return false;
            }
        }
    }
    
}
