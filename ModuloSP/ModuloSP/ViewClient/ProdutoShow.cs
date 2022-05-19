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
    public partial class ProdutoShow : Form
    {
        public ProdutoShow()
        {
            InitializeComponent();
        }

        private void ProdutosExtensoes_Load(object sender, EventArgs e)
        {
            ProductFilters.LoadMachine(ProductFilters.ID, txtDimensoes, txtPreco, txtCor, pictureBox1, txtDescricaoMaquinas);
            ProductFilters.LoadImMarcaMod(Models.IDManagment.fkMarca_Modelo, txtMarca);
            txtDescricaoMaquinas.AutoSize = true;
            txtDescricaoMaquinas.MaximumSize = new Size(500, 50);
        }



        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            txtCor.BackColor = ColorTranslator.FromHtml(txtCor.Text);
        }

        private void btExtensoes_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewClient.ExtensoesProduto))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new ViewClient.ExtensoesProduto();

            Models.Utils._form.mudaform(userList);
        }

    }
}
