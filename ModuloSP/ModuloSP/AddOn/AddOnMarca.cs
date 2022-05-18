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
    public partial class AddOnMarca : Form
    {
        public AddOnMarca()
        {
            InitializeComponent();
        }

        private void AddOnMarca_Load(object sender, EventArgs e)
        {
            FunctionsAddOn.INFOAddOnMarca(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            ViewClient.ProductFilters.CmbInsertM(cmbMarca);
        }

        private void adicionarbt_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(AddOn.AddOnMarcaAdd))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new AddOn.AddOnMarcaAdd();

            Models.Utils._form.mudaform(userList);
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdAddOnMarca == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(AddOn.AddOnMarcaEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new AddOn.AddOnMarcaEdit();

                Models.Utils._form.mudaform(userList);
            }
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Models.IDManagment.IdAddOnMarca))
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Prosseguir e eliminar registo " + Models.IDManagment.IdAddOnMarca + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Models.FunctionsGeneral.DeleteRow("Modelo_AddOns", Models.IDManagment.IdAddOnMarca);
                }
                FunctionsAddOn.INFOAddOnMarca(dataGridView1);
                Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdAddOnMarca = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Models.IDManagment.IdAddOnMarca == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(AddOn.AddOnMarcaEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new AddOn.AddOnMarcaEdit();

                Models.Utils._form.mudaform(userList);
            }
        }

        private void AddOnMarca_Activated(object sender, EventArgs e)
        {
            FunctionsAddOn.INFOAddOnMarca(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            FunctionsAddOn.MarcaSelect(dataGridView1, cmbMarca.Text);
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            FunctionsAddOn.INFOAddOnMarca(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            cmbMarca.Text = "Marca";
        }

        private void cmbMarca_Enter(object sender, EventArgs e)
        {
            if (cmbMarca.Text == "Marca")
            {
                cmbMarca.Text = null;
            }
        }

        private void cmbMarca_Leave(object sender, EventArgs e)
        {
            if (cmbMarca.Text == "")
            {
                cmbMarca.Text = "Marca";
            }
        }

    }
}
