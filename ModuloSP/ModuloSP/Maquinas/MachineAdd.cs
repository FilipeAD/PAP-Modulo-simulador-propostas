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
    public partial class MachineAdd : Form
    {
        public MachineAdd()
        {
            InitializeComponent();
        }

        string ADDColor;

        private void MachineAdd_Load(object sender, EventArgs e)
        {
            FunctionsMaq.CmbInsertM("Marca", txtMarca);
            txtMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMarca.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModelo.Enabled = true;
            FunctionsMaq.CmbInsertMM(txtModelo, txtMarca.Text);
            txtModelo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtModelo.AutoCompleteSource = AutoCompleteSource.ListItems;
           
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Marca")
            {
                txtMarca.Text = null;
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Marca";
                txtMarca.ForeColor = Color.Gray;
            }
        }

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (txtModelo.Text == "")
            {
                txtModelo.Text = "Modelo";
                txtModelo.ForeColor = Color.Gray;
            }
        }

        private void txtModelo_Enter(object sender, EventArgs e)
        {
            if (txtModelo.Text == "Modelo")
            {
                txtModelo.Text = null;
                txtModelo.ForeColor = Color.Black;
            }
        }

        private void txtCor_Enter(object sender, EventArgs e)
        {
            if (txtCor.Text == "Cor")
            {
                txtCor.Text = null;
                txtCor.ForeColor = Color.Black;
            }
        }

        private void txtCor_Leave(object sender, EventArgs e)
        {
            if (txtCor.Text == "")
            {
                txtCor.Text = "Cor";
                txtCor.ForeColor = Color.Gray;
            }
        }

        private void txtDimensoes_Enter(object sender, EventArgs e)
        {
            if (txtDimensoes.Text == "Dimensões")
            {
                txtDimensoes.Text = null;
                txtDimensoes.ForeColor = Color.Black;
            }
        }

        private void txtDimensoes_Leave(object sender, EventArgs e)
        {
            if (txtDimensoes.Text == "")
            {
                txtDimensoes.Text = "Dimensões";
                txtDimensoes.ForeColor = Color.Gray;
            }
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            if (txtPreco.Text == "Preço")
            {
                txtPreco.Text = null;
                txtPreco.ForeColor = Color.Black;
            }
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (txtPreco.Text == "")
            {
                txtPreco.Text = "Preço";
                txtPreco.ForeColor = Color.Gray;
            }
        }



        private void btAdd_Click_1(object sender, EventArgs e)
        {
            var list = ViewClient.ProductFilters.ListCMB("Marca");
            if (list.Contains(txtMarca.Text))
            {
                var lista = ViewClient.ProductFilters.ListCMB("Modelo");
                if (lista.Contains(txtModelo.Text))
                {
                    if (string.IsNullOrWhiteSpace(txtCor.Text) | string.IsNullOrWhiteSpace(txtDimensoes.Text) | string.IsNullOrWhiteSpace(txtPreco.Text) | pictureBox1.Image == null)
                    {
                        MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        FunctionsMaq.IDMM(txtMarca.Text, txtModelo.Text);
                        FunctionsMaq.AddInfo(ADDColor, txtDimensoes.Text, txtPreco.Text, Models.Utils.Marca_Modelo, Models.CurrentUser.IDUser, pictureBox1, txtDescricao.Text);
                        txtMarca.SelectedIndex = -1;
                        txtModelo.SelectedIndex = -1;
                        txtCor.Text = "";
                        txtDimensoes.Text = "";
                        txtPreco.Text = "";
                        pictureBox1.Image = null;
                        txtDescricao.Text = "";
                        txtCor.BackColor = Color.White;
                    }
                }
                else
                {
                    MessageBox.Show("Modelo inexistente!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Marca inexistente!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }


        private void btConectImage_Click(object sender, EventArgs e)
        {
            FunctionsMaq.UploadImage(pictureBox1);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //string code = (colorDialog1.Color.ToArgb)
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FunctionsMaq.UploadImage(pictureBox1);
        }

        private void txtCor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                ADDColor = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                txtCor.BackColor = colorDialog1.Color;

            }
           
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marca.MarcaList))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new Marca.MarcaList();

            Models.Utils._form.mudaform(userList);
        }

        private void lblModelo_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marc_Mod.MarcaModeloList))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new Marc_Mod.MarcaModeloList();

            Models.Utils._form.mudaform(userList);
        }

        private void txtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Descrição";
                txtDescricao.ForeColor = Color.Gray;
            }
        }

        private void txtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Descrição")
            {
                txtDescricao.Text = null;
                txtDescricao.ForeColor = Color.Black;
            }
        }
    }
}
