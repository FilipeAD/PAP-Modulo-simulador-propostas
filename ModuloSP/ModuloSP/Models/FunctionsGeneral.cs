using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Models
{
    internal class FunctionsGeneral
    {
        //Apagar registo especificado pelo ID
        public static void DeleteRow(string _Database, string _ID)
        {
            SqlConnection con = new SqlConnection(Utils.conString);
            con.Open();
            string query = "DELETE "+ _Database + " where ID = " + _ID;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Editar as datagriview consuante os padroes de cor e tamanhos especificados
        public static void EditDataGrid(DataGridView _DataGrid)
        {
                _DataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                _DataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                _DataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                _DataGrid.ReadOnly = true;
                _DataGrid.AllowUserToAddRows = false;
                _DataGrid.RowHeadersVisible = false;
                _DataGrid.BorderStyle = BorderStyle.None;
                _DataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
                _DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                _DataGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 178, 178);
                _DataGrid.DefaultCellStyle.SelectionForeColor = Color.White;

                _DataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(94, 94, 94);
                _DataGrid.RowTemplate.Height = 25;
                _DataGrid.EnableHeadersVisualStyles = false;
                _DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                _DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(94, 94, 94);
                _DataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                _DataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
           

        }



    }
}
