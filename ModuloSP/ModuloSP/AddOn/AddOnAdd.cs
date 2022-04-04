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
            Models.IDManagment.IdAddOn= Models.IDManagment.InsereID("AddOn");
            FunctionsAddOn.AddInfo(txtNome.Text, txtPreco.Text);
            txtNome.Text = "";
            txtPreco.Text = "";
        }
    }
}
