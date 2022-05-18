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
    public partial class ExtensoesProduto : Form
    {
        public ExtensoesProduto()
        {
            InitializeComponent();
        }

        private void ExtensoesProduto_Load(object sender, EventArgs e)
        {
            ProductFilters.CmbInsertM("Add_Ons_Grupos", cmbOrder);
            cmbOrder.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbOrder.AutoCompleteSource = AutoCompleteSource.ListItems;
            ProductFilters.ShowAddOns(dataGridView1, Models.IDManagment.fkMarca_Modelo);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);

        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = ProductFilters.ListCMB("Add_Ons_Grupos");
            if (list.Contains(cmbOrder.Text))
            {
                ProductFilters.ShowAddOnsGrupo(dataGridView1, cmbOrder.Text, Models.IDManagment.fkMarca_Modelo);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ProductFilters.ShowAddOns(dataGridView1, Models.IDManagment.fkMarca_Modelo);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

    }
}
