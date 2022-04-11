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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            ProductFilters.CmbOrderItems(cmbOrder);
            ProductFilters.CmbColorItems(cmbColor);
            ProductFilters.CmbInsertM(cmbMarca);
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            string order;

            if (cmbOrder.Text == "Preço ASCENDENTE")
            {
                order = "asc";
            }
            else{ 
                order = "desc";
            }

           
            if (cmbColor.Text != "" & cmbMarca.Text != "")
            {
                ProductFilters.PrecoCorMarcaSelect(dataGridView1, order, cmbColor.Text, cmbMarca.Text);
            }
            if (cmbColor.Text != "")
            {
                ProductFilters.PrecoCorSelect(dataGridView1, order, cmbColor.Text);
            }
            else if (cmbMarca.Text != "")
            {
                ProductFilters.MarcaPrecoSelect(dataGridView1, cmbMarca.Text, order);
            }
            else if (cmbColor.Text == "" & cmbMarca.Text == "")
            {
                ProductFilters.SortPrices(dataGridView1, order);
            }
            
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string order;

            if (cmbOrder.Text == "Preço ASCENDENTE")
            {
                order = "asc";
            }
            else
            {
                order = "desc";
            }


            
            if (cmbMarca.Text != "" & cmbOrder.Text != "")
            {
                ProductFilters.PrecoCorMarcaSelect(dataGridView1, order, cmbColor.Text, cmbMarca.Text);
            }
            if (cmbMarca.Text != "")
            {
                ProductFilters.MarcaCorSelect(dataGridView1, cmbMarca.Text, cmbColor.Text);
            }
            else if (cmbOrder.Text != "")
            {
                ProductFilters.PrecoCorSelect(dataGridView1, order, cmbColor.Text);
            }
            else if (cmbMarca.Text == "" & cmbOrder.Text == "")
            {
                ProductFilters.ColorSelect(dataGridView1, cmbColor.Text);
            }
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string order;

            if (cmbOrder.Text == "Preço ASCENDENTE")
            {
                order = "asc";
            }
            else
            {
                order = "desc";
            }


          
            if (cmbColor.Text != "" & cmbOrder.Text != "")
            {
                ProductFilters.PrecoCorMarcaSelect(dataGridView1, order, cmbColor.Text, cmbMarca.Text);
            }
            if (cmbColor.Text != "")
            {
                ProductFilters.MarcaCorSelect(dataGridView1, cmbMarca.Text, cmbColor.Text);
            }
            else if (cmbOrder.Text != "")
            {
                ProductFilters.MarcaPrecoSelect(dataGridView1, cmbMarca.Text, order);
            }
            else if (cmbColor.Text == "" & cmbOrder.Text == "")
            {
                ProductFilters.MarcaSelect(dataGridView1, cmbMarca.Text);
            }
        }

    }
}
