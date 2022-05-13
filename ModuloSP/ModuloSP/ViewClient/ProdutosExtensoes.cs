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
    public partial class ProdutosExtensoes : Form
    {
        public ProdutosExtensoes()
        {
            InitializeComponent();
        }

        private void ProdutosExtensoes_Load(object sender, EventArgs e)
        {
            ProductFilters.LoadMachine(ProductFilters.ID, txtDimensoes, txtPreco, txtCor, pictureBox1, txtDescricaoMaquinas);
            ProductFilters.LoadImMarcaMod(Models.IDManagment.fkMarca_Modelo, txtMarca);
            Maquinas.FunctionsMaq.CmbInsertM("Add_Ons_Grupos", txtCategorias);
            txtCategorias.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCategorias.AutoCompleteSource = AutoCompleteSource.ListItems;
            txtDescricaoMaquinas.AutoSize = true;
            txtDescricaoMaquinas.MaximumSize = new Size(450, 50);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void txtCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = ProductFilters.ListCMB("Add_Ons_Grupos");
            if (list.Contains(txtCategorias.Text))
            {
                txtNome.SelectedIndex = -1;
                txtNome.Items.Clear();
                txtNome.Enabled = true;
                ProductFilters.CmbInsertAddon(txtNome, txtCategorias.Text);
                txtNome.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtNome.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
        }

        private void txtCategorias_TextChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
        }

        private void txtNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtNome.Text);
            
        }

      
    }
}
