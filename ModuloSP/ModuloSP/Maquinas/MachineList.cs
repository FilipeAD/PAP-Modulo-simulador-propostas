using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Maquinas
{
    public partial class MachineList : Form
    {
        public MachineList()
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

        private void MachineList_Load(object sender, EventArgs e)
        {
            FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdMaquina = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bToolStripMenuItem.Visible = true;
            DesktopPanel.Visible = true;
            OpenSecondForm(new Maquinas.MachineAdd(), sender);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdMaquina == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bToolStripMenuItem.Visible = true;
                DesktopPanel.Visible = true;
                OpenSecondForm(new MachineEdit(), sender);
            }
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Prosseguir e eliminar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            else
            {
                Models.FunctionsGeneral.DeleteRow("Maquinas", Models.IDManagment.IdMaquina);

            }
            FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bToolStripMenuItem.Visible = false;
            DesktopPanel.Visible = false;
            FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void adicionarbt_Click(object sender, EventArgs e)
        {
            bToolStripMenuItem.Visible = true;
            DesktopPanel.Visible = true;
            OpenSecondForm(new Maquinas.MachineAdd(), sender);
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdMaquina == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bToolStripMenuItem.Visible = true;
                DesktopPanel.Visible = true;
                OpenSecondForm(new MachineEdit(), sender);
            }
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DesktopPanel.Visible == false)
            {
                if (Models.IDManagment.IdMaquina == "")
                {
                    MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (MessageBox.Show("Prosseguir e eliminar registo " + Models.IDManagment.IdMaquina + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Models.FunctionsGeneral.DeleteRow("Maquinas", Models.IDManagment.IdMaquina);

                    }
                    FunctionsMaq.LoadInfo(dataGridView1);
                    Models.FunctionsGeneral.EditDataGrid(dataGridView1);
                }
            }
        }
    }
}
