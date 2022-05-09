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


       


        private void AddOnList_Load(object sender, EventArgs e)
        {
            FunctionsAddOn.INFOAddOn(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdAddOn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }


        private void adicionarbt_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(AddOn.AddOnAdd))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new AddOn.AddOnAdd();

            Models.Utils._form.mudaform(userList);

        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdAddOn == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(AddOn.AddOnEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new AddOn.AddOnEdit();

                Models.Utils._form.mudaform(userList);

            }
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Models.IDManagment.IdAddOn))
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Prosseguir e eliminar registo " + Models.IDManagment.IdAddOn + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Models.FunctionsGeneral.DeleteRow("AddOns", Models.IDManagment.IdAddOn);
                }
                FunctionsAddOn.INFOAddOn(dataGridView1);
                Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            }

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionsAddOn.INFOAddOn(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Models.IDManagment.IdAddOn == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(AddOn.AddOnEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new AddOn.AddOnEdit();

                Models.Utils._form.mudaform(userList);

            }
        }
    }
}
