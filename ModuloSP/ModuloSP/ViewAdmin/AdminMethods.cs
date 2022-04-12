using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewAdmin
{
    internal class AdminMethods
    {

        public static string _Username = "";
        public static string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public static string _Email = "";
        public static string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public static void CmbUtilizadorItems(ToolStripComboBox _cmb)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select nome from Utilizador";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["nome"].ToString());
            }
        }

        public static void ActivityUser(string _Username)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select nome, email from Utilizador where nome ='"+ _Username + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AdminMethods.Username = dr["Nome"].ToString();
                AdminMethods.Email = dr["email"].ToString();
            }
        }


    }
}
