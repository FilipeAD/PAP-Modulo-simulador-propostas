using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.AddOn
{
    public partial class AddOnMarcaEdit : Form
    {
        public AddOnMarcaEdit()
        {
            InitializeComponent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.IDMM(txtMarca.Text, txtModelo.Text);
            FunctionsAddOn.AddOnId(txtAddOn.Text);
            FunctionsAddOn.EditInfoAddMarca(Models.IDManagment.IdAddOnMarca, txtPreco.Text, Models.Utils.IDAddOn, Models.Utils.Marca_Modelo);
            this.Close();
        }

        private void AddOnMarcaEdit_Load(object sender, EventArgs e)
        {
            FunctionsAddOn.LoadEditInfoAddOnMarca(Models.IDManagment.IdAddOnMarca, txtMarca, txtModelo, txtAddOn, txtPreco);
        }
    }
}
