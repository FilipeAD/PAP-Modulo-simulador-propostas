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

        private void cmbOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbOrder.Text, cmbColor.Text, cmbMarca.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void cmbColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbColor.Text, cmbMarca.Text, cmbOrder.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void cmbMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbMarca.Text, cmbColor.Text, cmbOrder.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cmbColor.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            Maquinas.FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewClient.ProdutoShow))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new ViewClient.ProdutoShow();

            Models.Utils._form.mudaform(userList);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewClient.ProductFilters.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Produtos_Activated(object sender, EventArgs e)
        {
            ProductFilters.MaquinasInSimulacao(Models.IDManagment.IdSimulacao);
            toolStripStatusLabelImpressoras.Text = ProductFilters.NumImpressoras;
            if (Models.IDManagment.IdSimulacao != "")
            {
                toolStripStatusLabel2.Visible = true;
            }
        }

        private void Produtos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Models.IDManagment.IdSimulacao == "")
            {

            }
            else
            {

                if (MessageBox.Show("Terminar Simulação ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Models.IDManagment.IdSimulacao = "";
                    ProductFilters.NumImpressoras = "0";
                }

            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdSimulacao == "")
            {

            }
            else
            {

                if (MessageBox.Show("Terminar Simulação ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Models.IDManagment.IdSimulacao = "";
                    this.Close();
                    ProductFilters.NumImpressoras = "0";
                }

            }
        }
    }
}
