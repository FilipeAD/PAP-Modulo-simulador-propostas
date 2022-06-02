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
    public partial class MarcaModeloEdit : Form
    {
        public MarcaModeloEdit()
        {
            InitializeComponent();
        }

        private void GetIDModelo()
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Modelo.ID from Marca_Modelo " +
                            "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                            "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                            "where Modelo.Nome = '" + txtNome.Text + " '";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.IDManagment.IdModelo = (dr["ID"].ToString());
            }
        }



        private void btEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Marca.FunctionsMarca.EditMarca("Modelo", Models.IDManagment.IdModelo, txtNome.Text);
                this.Close();
            }
        }



        private void MarcaModeloEdit_Load(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.LoadCMB(txtMarca, txtNome, Models.IDManagment.IDMarca_Modelo);
            GetIDModelo();

            AddOn.FunctionsAddOn.INFOAddOnMarca(dataGridView1, Models.IDManagment.IDMarca_Modelo);

            FunctionMarMod.INFOMaquinaMarca(dataGridView2, Models.IDManagment.IDMarca_Modelo);


        }

        private void MarcaModeloEdit_Activated(object sender, EventArgs e)
        {
            AddOn.FunctionsAddOn.INFOAddOnMarca(dataGridView1, Models.IDManagment.IDMarca_Modelo);
            FunctionMarMod.INFOMaquinaMarca(dataGridView2, Models.IDManagment.IDMarca_Modelo);

        }

        private void adicionarbt_Click_1(object sender, EventArgs e)
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

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdAddOnMarca = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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
                FunctionMarMod.LoadMarMod(dataGridView1);
                Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            }
        }

        private void toolStripAddMaquina_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Maquinas.MachineMarcaAdd))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new Maquinas.MachineMarcaAdd();

            Models.Utils._form.mudaform(userList);
        }

        private void toolStripEditMaquina_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdMaquina == "")
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem1.Text == "Ver cor")
            {
                for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                {
                    dataGridView2.Rows[i].Cells["cor"].Style.BackColor = System.Drawing.ColorTranslator.FromHtml(dataGridView2.Rows[i].Cells["Cor"].Value.ToString());
                    dataGridView2.Rows[i].Cells["cor"].Style.ForeColor = System.Drawing.ColorTranslator.FromHtml(dataGridView2.Rows[i].Cells["Cor"].Value.ToString());
                }
                dataGridView2.CurrentCell.Selected = false;

                toolStripMenuItem1.Text = "Ver Hex Code";
            }
            else if (toolStripMenuItem1.Text == "Ver Hex Code")
            {
                FunctionMarMod.INFOMaquinaMarca(dataGridView2, Models.IDManagment.IDMarca_Modelo);
                dataGridView1.Refresh();

                toolStripMenuItem1.Text = "Ver cor";
            }
        }
    }
}
