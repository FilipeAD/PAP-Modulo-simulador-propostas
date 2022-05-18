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

namespace ModuloSP.ViewAdmin
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

       

        private void ClientList_Load(object sender, EventArgs e)
        {
            AdminMethods.INFOUser(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);


        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdUser == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(UserEditGrupo))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new UserEditGrupo();

                Models.Utils._form.mudaform(userList);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdUser = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Models.IDManagment.IdUser == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(UserEditGrupo))
                    {
                        frm.Activate();
                        return;
                    }
                }

                var userList = new UserEditGrupo();

                Models.Utils._form.mudaform(userList);
            }
        }
    }
}
