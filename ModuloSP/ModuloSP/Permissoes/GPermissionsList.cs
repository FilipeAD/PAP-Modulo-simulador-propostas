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
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;


            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 178, 178);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(94, 94, 94);
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(94, 94, 94);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 10, FontStyle.Bold);

        }


        private void GPermissionsList_Load(object sender, EventArgs e)
        {
            DatagridStyle();

            AcountPermission.IDNivel();
            AcountPermission.LoadGrupo(txtNome);

            txtNome.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNome.AutoCompleteSource = AutoCompleteSource.ListItems;



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

        private void GPermissionsList_Activated(object sender, EventArgs e)
        {

        }


        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
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
                    break;

            }
        }

        private void txtNome_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
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
                    break;

            }
        }

    }
}
