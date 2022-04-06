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

        private Form activeForm;

        private void OpenSecondForm(Form SecondForm, object btSend)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = SecondForm;
            SecondForm.TopLevel = false;
            SecondForm.FormBorderStyle = FormBorderStyle.None;
            SecondForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(SecondForm);
            this.DesktopPanel.Tag = SecondForm;
            SecondForm.BringToFront();
            SecondForm.Show();


        }
       

        private void MarcaModeloList_Load(object sender, EventArgs e)
        {
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bToolStripMenuItem.Visible = true;
            DesktopPanel.Visible = true;
            OpenSecondForm(new MarcaModeloAdd(), sender);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IDMarca_Modelo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void adicionarbt_Click(object sender, EventArgs e)
        {
            bToolStripMenuItem.Visible = true;
            DesktopPanel.Visible = true;
            OpenSecondForm(new MarcaModeloAdd(), sender);
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Prosseguir e eliminar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            else
            {
                Models.FunctionsGeneral.DeleteRow("Marca_Modelo", Models.IDManagment.IDMarca_Modelo);
                MessageBox.Show("Registo eliminado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesktopPanel.Visible = false;
            FunctionMarMod.LoadMarMod(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            bToolStripMenuItem.Visible = false;
        }
           
        
    }
}
