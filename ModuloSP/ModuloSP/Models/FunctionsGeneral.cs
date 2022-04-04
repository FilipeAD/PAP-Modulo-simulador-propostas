using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Models
{
    internal class FunctionsGeneral
    {
        public static void DeleteRow(string _Database, string _ID)
        {
            SqlConnection con = new SqlConnection(Utils.conString);
            con.Open();
            string query = "DELETE "+ _Database + " where ID = " + _ID;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void EditDataGrid(DataGridView _DataGrid)
        {
            _DataGrid.ReadOnly = true;
            _DataGrid.AllowUserToAddRows = false;
            _DataGrid.RowHeadersVisible = false;
        }

        public static void VerifyOpenForm(Form _formName)
        {
            int _iCount = Application.OpenForms.Cast<Form>().Where(x => x.Name == _formName.Name).Count();
           
            //_formName.WindowState = FormWindowState.Maximized;
            //_formName.MdiParent = this;
            //_formName.Size = this.Size;
            //_formName.Show();
        }


    }
}
