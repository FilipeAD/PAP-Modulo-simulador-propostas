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
            ProductFilters.Extensoes.Clear();
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



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductFilters.Extensoes.Add(ProductFilters.IDExtensoes);

            if (ProductFilters.produtos.Where(x => x.ID == Convert.ToInt32(ProductFilters.IDExtensoes)).Count() > 0)
            {
                var _aux = ProductFilters.produtos.Where(x => x.ID == Convert.ToInt32(ProductFilters.IDExtensoes)).First();

                ProductFilters.produtos.Remove(_aux);

                _aux.quantidade = _aux.quantidade + 1;

                ProductFilters.produtos.Add(_aux);
            }

            else
            {
                ProductFilters.produtos.Add(new Models.VMProduct
                {
                    ID = Convert.ToInt32(ProductFilters.IDExtensoes),
                    quantidade = 1
                });
            }

            QExtensoes.Text = ProductFilters.Extensoes.Count().ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductFilters.IDExtensoes = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            ProductFilters.Extensoes.Add(ProductFilters.IDExtensoes);

            if (ProductFilters.produtos.Where(x => x.ID == Convert.ToInt32(ProductFilters.IDExtensoes)).Count() > 0)
            {
                var _aux = ProductFilters.produtos.Where(x => x.ID == Convert.ToInt32(ProductFilters.IDExtensoes)).First();

                ProductFilters.produtos.Remove(_aux);

                _aux.quantidade = _aux.quantidade + 1;

                ProductFilters.produtos.Add(_aux);
            }

            else
            {
                ProductFilters.produtos.Add(new Models.VMProduct
                {
                    ID = Convert.ToInt32(ProductFilters.IDExtensoes),
                    quantidade = 1
                });
            }

            QExtensoes.Text = ProductFilters.Extensoes.Count().ToString();
        }

        private void toolStripExtensoes_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewClient.ListEsxtensoes))
                {
                    frm.Activate();
                    return;
                }
            }

            ViewClient.ListEsxtensoes load = new ViewClient.ListEsxtensoes();
            Models.Utils._form.mudaform(load); 
        }
    }
}
