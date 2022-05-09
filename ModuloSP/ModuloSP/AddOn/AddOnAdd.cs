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
    public partial class AddOnAdd : Form
    {
        public AddOnAdd()
        {
            InitializeComponent();
        }

       
      
        private void AddOnAdd_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) | string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Models.IDManagment.IdAddOn = Models.IDManagment.InsereID("AddOn");
                FunctionsAddOn.AddInfo(txtNome.Text, txtPreco.Text, Models.CurrentUser.IDUser);
                txtNome.Text = "";
                txtPreco.Text = "";
            }

          
        }
    }
}
