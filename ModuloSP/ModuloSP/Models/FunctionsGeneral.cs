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
            //_DataGrid.Columns[0].Width = 35;
            //_DataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //_DataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _DataGrid.ReadOnly = true;
            _DataGrid.AllowUserToAddRows = false;
            _DataGrid.RowHeadersVisible = false;
        }



    }
}
