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
    public partial class AddOnEdit : Form
    {
        public AddOnEdit()
        {
            InitializeComponent();
        }

        private void AddOnEdit_Load(object sender, EventArgs e)
        {
            FunctionsAddOn.LoadEditInfo(Models.IDManagment.IdAddOn, txtNome, txtPreco);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            FunctionsAddOn.EditInfo(Models.IDManagment.IdAddOn, txtNome.Text, txtPreco.Text);
            this.Close();
        }
    }
}
