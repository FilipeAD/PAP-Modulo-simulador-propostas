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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IDMarca_Modelo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
        }

        private void adicionarbt_Click(object sender, EventArgs e)
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

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            FunctionMarMod.MarcaSelect(dataGridView1, cmbMarca.Text);
        }

        private void MarcaModeloList_Activated(object sender, EventArgs e)
        {
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }
    }
}
