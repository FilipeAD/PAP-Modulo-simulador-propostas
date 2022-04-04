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
    public partial class MarcaAdd : Form
    {
        public MarcaAdd()
        {
            InitializeComponent();
        }

        

        private void btAdd_Click(object sender, EventArgs e)
        {
            Models.IDManagment.IdMarca = Models.IDManagment.InsereID("Marca");
            FunctionsMarca.AddInfo(txtNome.Text, Models.IDManagment.IdMarca);
            txtNome.Text = "";
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = null;
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome";
                txtNome.ForeColor = Color.Gray;
            }
        }

        private void MarcaAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
