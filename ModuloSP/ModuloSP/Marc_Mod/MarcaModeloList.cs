using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Marc_Mod
{
    public partial class MarcaModeloList : Form
    {
        public MarcaModeloList()
        {
            InitializeComponent();
        }




        private void MarcaModeloList_Load(object sender, EventArgs e)
        {
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);

            ViewClient.ProductFilters.CmbInsertM(cmbMarca);
            cmbMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IDMarca_Modelo = dataGridView1.CurrentRow.Cells[0].Value.ToString();

        }


        private void MarcaModeloList_Activated(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = -1;
            cmbModelo.SelectedIndex = -1;
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Models.IDManagment.IDMarca_Modelo == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Marc_Mod.MarcaModeloEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new Marc_Mod.MarcaModeloEdit();

                Models.Utils._form.mudaform(userList);
            }
        }

        private void adicionarbt_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marc_Mod.MarcaModeloAdd))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new Marc_Mod.MarcaModeloAdd();

            Models.Utils._form.mudaform(userList);
        }

        private void cmbMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FunctionMarMod.MarcaSelect(dataGridView1, cmbMarca.Text);
            cmbModelo.Enabled = true;
            FunctionMarMod.CmbInsertMM(cmbModelo, cmbMarca.Text);
            cmbModelo.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FunctionMarMod.MarcaMoDSelect(dataGridView1, cmbMarca.Text, cmbModelo.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cmbMarca.SelectedIndex = -1;
            cmbModelo.SelectedIndex = -1;
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void Editarbt_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IDMarca_Modelo == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Marc_Mod.MarcaModeloEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new Marc_Mod.MarcaModeloEdit();

                Models.Utils._form.mudaform(userList);
            }
        }

        private void eliminarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Models.IDManagment.IDMarca_Modelo))
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Prosseguir e eliminar registo " + Models.IDManagment.IDMarca_Modelo + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Models.FunctionsGeneral.DeleteRow("Maquinas", Models.IDManagment.IDMarca_Modelo);
                }
                FunctionMarMod.LoadMarMod(dataGridView1);
                Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            }
        }

        private void btAction_Click(object sender, EventArgs e)
        {
            if (btAction.Text == "Filtros")
            {
                adicionarbt.Visible = false;
                Editarbt.Visible = false;
                eliminarToolStripMenuItem1.Visible = false;

                //#-----------------------------------------

                toolStripButton1.Visible = true;
                toolStripSeparator1.Visible = true;
                toolStripLabel1.Visible = true;
                cmbMarca.Visible = true;
                toolStripLabel2.Visible = true;
                cmbModelo.Visible = true;

                btAction.Text = " <<<< ";
                btAction.Image = null;
            }
            else
            {
                adicionarbt.Visible = true;
                Editarbt.Visible = true;
                eliminarToolStripMenuItem1.Visible = true;

                //#-----------------------------------------

                toolStripButton1.Visible = false;
                toolStripSeparator1.Visible = false;
                toolStripLabel1.Visible = false;
                cmbMarca.Visible = false;
                toolStripLabel2.Visible = false;
                cmbModelo.Visible = false;

                btAction.Text = "Filtros";
                btAction.Image = System.Drawing.Image.FromFile("img/searchicon.png");

            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Models.IDManagment.IDMarca_Modelo == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Marc_Mod.MarcaModeloEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new Marc_Mod.MarcaModeloEdit();

                Models.Utils._form.mudaform(userList);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
