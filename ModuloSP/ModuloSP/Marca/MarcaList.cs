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

namespace ModuloSP.Marca
{
    public partial class MarcaList : Form
    {
        public MarcaList()
        {
            InitializeComponent();
        }


        private void MarcaList_Load(object sender, EventArgs e)
        {
            FunctionsMarca.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdMarca = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }


        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdMarca == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Marca.MarcaEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new Marca.MarcaEdit();

                Models.Utils._form.mudaform(userList);
            }
        }

        private void adicionarbt_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marca.MarcaAdd))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new Marca.MarcaAdd();

            Models.Utils._form.mudaform(userList);
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Models.IDManagment.IdMarca))
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Prosseguir e eliminar registo " + Models.IDManagment.IdMarca + "?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    Models.FunctionsGeneral.DeleteRow("Maquinas", Models.IDManagment.IdMarca);
                }
                FunctionsMarca.LoadInfo(dataGridView1);
                Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Models.IDManagment.IdMarca == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(Marca.MarcaEdit))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new Marca.MarcaEdit();

                Models.Utils._form.mudaform(userList);
            }
        }
    }
}
