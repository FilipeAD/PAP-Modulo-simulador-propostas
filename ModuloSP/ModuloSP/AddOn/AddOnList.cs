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

namespace ModuloSP.AddOn
{
    public partial class AddOnList : Form
    {
        public AddOnList()
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



        private void AddOnList_Load(object sender, EventArgs e)
        {
            FunctionsAddOn.INFOAddOn(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //btBack.Visible = true;
            DesktopPanel.Visible = true;
            OpenSecondForm(new AddOnAdd(), sender);

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdAddOn == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //btBack.Visible = true;
                DesktopPanel.Visible = true;

            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DesktopPanel.Visible = false;
            //btBack.Visible = false;
            FunctionsAddOn.INFOAddOn(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Prosseguir e eliminar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            else
            {
                Models.FunctionsGeneral.DeleteRow("AddOns", Models.IDManagment.IdAddOn);
                MessageBox.Show("Registo eliminado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FunctionsAddOn.INFOAddOn(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdAddOn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }


        private void adicionarbt_Click_1(object sender, EventArgs e)
        {
            DesktopPanel.Visible = true;
            OpenSecondForm(new AddOnAdd(), sender);

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdAddOn == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DesktopPanel.Visible = true;
                OpenSecondForm(new AddOnEdit(), sender);
            }
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DesktopPanel.Visible == false)
            {
                if (Models.IDManagment.IdAddOn == "")
                {
                    MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{ 
                    if (MessageBox.Show("Prosseguir e eliminar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Models.FunctionsGeneral.DeleteRow("AddOns", Models.IDManagment.IdAddOn);
                        MessageBox.Show("Registo eliminado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    FunctionsAddOn.INFOAddOn(dataGridView1);
                    Models.FunctionsGeneral.EditDataGrid(dataGridView1);
                }
            }

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesktopPanel.Visible = false;
            FunctionsAddOn.INFOAddOn(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }
    }
}
