using System;
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
            Permissoes.AcountPermission.IDNivel();
            AdminMethods.INFOUser(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            AdminMethods.ActivityUtilizadores(dataGridView2);
            Models.FunctionsGeneral.EditDataGrid(dataGridView2);




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
  

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Models.IDManagment.IdUser = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            AdminMethods.ActivityUtilizador(dataGridView2, Models.IDManagment.IdUser);
            Models.FunctionsGeneral.EditDataGrid(dataGridView2);
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

        private void UserList_Activated(object sender, EventArgs e)
        {
            AdminMethods.INFOUser(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void DateBiggerThan_DateSelected(object sender, DateRangeEventArgs e)
        {

            AdminMethods.UtilizadorRangeDateBigger(dataGridView2, Models.IDManagment.IdUser, DateBiggerThan.SelectionStart.Date.ToString("yyyy-MM-dd"));
            DateSmallerThan.Enabled = true;
            Models.FunctionsGeneral.EditDataGrid(dataGridView2);


        }

        private void DateSmallerThan_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (DateBiggerThan.SelectionStart.Date >= DateSmallerThan.SelectionStart.Date)
            {
                MessageBox.Show("Intervalo de tempo incorreto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AdminMethods.UtilizadorRangeDateSmaller(dataGridView2, Models.IDManagment.IdUser, DateBiggerThan.SelectionStart.Date.ToString("yyyy-MM-dd"), DateSmallerThan.SelectionStart.Date.ToString("yyyy-MM-dd"));
                Models.FunctionsGeneral.EditDataGrid(dataGridView2);

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminMethods.ActivityUtilizador(dataGridView2, Models.IDManagment.IdUser);
            Models.FunctionsGeneral.EditDataGrid(dataGridView2);
        }

    }
}
