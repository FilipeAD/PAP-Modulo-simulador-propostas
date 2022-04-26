using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Permissoes
{
    public partial class GPermissionsList : Form
    {
        public GPermissionsList()
        {
            InitializeComponent();
        }


        private void DatagridStyle()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
        }


        private void GPermissionsList_Load(object sender, EventArgs e)
        {


        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var list = AcountPermission.GrupoPermission();

            if (AcountPermission.LoginView(list, txtNome.Text))
            {
                MessageBox.Show("Não tem permições para aceder a esse grupo!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                dataGridView1.Rows.Clear();
                AcountPermission.GetIDGrupo(txtNome.Text);
                AcountPermission.LoadInfo(dataGridView1, txtNome.Text);
                DatagridStyle();
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            AcountPermission.EditPermission(dataGridView1);
        }

      
    }
}
