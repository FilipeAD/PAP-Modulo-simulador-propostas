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
    public partial class AddOnMarcaAdd : Form
    {
        public AddOnMarcaAdd()
        {
            InitializeComponent();
        }

        private void AddOnMarcaAdd_Load(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.CmbInsertM("Marca", txtMarca);
            FunctionsAddOn.CmbInsertAddon("AddOns", txtAddOn);
        }

        private void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModelo.Enabled = true;
            Maquinas.FunctionsMaq.CmbInsertMM(txtModelo, txtMarca.Text);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.IDMM(txtMarca.Text, txtModelo.Text);
            FunctionsAddOn.AddOnId(txtAddOn.Text);
            if  (FunctionsAddOn.VField(Models.Utils.IDAddOn, Models.Utils.Marca_Modelo, "verify_MarcaAddOn", "@addOns", "@marca_modelo"))
            {
                MessageBox.Show("Conexão entre AddOn e Marca|Modelo já existe !!", "!!ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMarca.Text) | string.IsNullOrWhiteSpace(txtModelo.Text) | string.IsNullOrWhiteSpace(txtPreco.Text) | string.IsNullOrWhiteSpace(txtAddOn.Text))
                {
                    MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                   
                    FunctionsAddOn.AddInfoMarcaAddOn(txtPreco.Text, Models.Utils.IDAddOn, Models.Utils.Marca_Modelo);
                    txtMarca.SelectedIndex = -1;
                    txtModelo.SelectedIndex = -1;
                    txtAddOn.SelectedIndex = -1;
                    txtPreco.Text = "";

                }
            }
        }
    }
}
