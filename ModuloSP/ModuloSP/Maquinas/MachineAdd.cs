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
      
        private void MachineAdd_Load(object sender, EventArgs e)
        {
            FunctionsMaq.CmbInsertM("Marca", txtMarca);
            
        }

        private void txtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModelo.Enabled = true;
            FunctionsMaq.CmbInsertMM(txtModelo, txtMarca.Text);
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
            Models.IDManagment.IdMaquina = Models.IDManagment.InsereID("Maquinas");
            FunctionsMaq.IDMM(txtMarca.Text, txtModelo.Text);
            FunctionsMaq.AddInfo(Models.IDManagment.IdMaquina, txtCor.Text, txtDimensoes.Text, txtPreco.Text, Models.Utils.Marca_Modelo);
            txtMarca.SelectedIndex = -1;
            txtModelo.SelectedIndex = -1;
            txtCor.Text = "";
            txtDimensoes.Text = "";
            txtPreco.Text = "";

        }

        
    }
}
