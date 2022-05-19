using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewClient
{
    public partial class ListEsxtensoes : Form
    {
        public ListEsxtensoes()
        {
            InitializeComponent();
        }

        private void ListEsxtensoes_Load(object sender, EventArgs e)
        {
                //MessageBox.Show(_sTexto);

            DataTable _table = new DataTable();

            _table.Columns.Add("ID");
            _table.Columns.Add("Descrição");
            _table.Columns.Add("Preço base");
            _table.Columns.Add("QTD");

            //foreach (string _sTexto in ProductFilters.Extensoes)
            //{
            //    var _addOn = Models.Product.GetProductByID(Convert.ToInt32(_sTexto));

            //    _table.Rows.Add(new string[] { _addOn.ID.ToString(), _addOn.Descricao, _addOn.PrecoBase.ToString("n2") });
            //}
            
            foreach (var _aux in ProductFilters.produtos)
            {
                var _addOn = Models.Product.GetProductByID(_aux.ID);

                _table.Rows.Add(new string[] { _addOn.ID.ToString(), _addOn.Descricao, _addOn.PrecoBase.ToString("n2"), _aux.quantidade.ToString() });
            }

                dataGridView1.DataSource = _table;
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }
    }
}
