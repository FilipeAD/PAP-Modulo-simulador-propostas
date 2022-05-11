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
            ProductFilters.LoadMachine(ProductFilters.ID, txtDimensoes, txtPreco, txtCor, pictureBox1);
            ProductFilters.LoadCMB(Models.IDManagment.fkMarca_Modelo, txtMarca);
            Maquinas.FunctionsMaq.CmbInsertM("Add_Ons_Grupos", txtCategorias);
        }

      
    }
}
