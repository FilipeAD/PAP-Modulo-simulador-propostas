using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewAdmin
{
    public partial class ActivityTracker : Form
    {
        public ActivityTracker()
        {
            InitializeComponent();
        }

        private void ActivityTracker_Load(object sender, EventArgs e)
        {
            AdminMethods.CmbActionsItems(cmbActions);
        }

        private void cmbActions_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbUtilizador.Items.Clear();
            AdminMethods.CmbUtilizadorItems(cmbActions.Text, cmbUtilizador);
        }

        private void cmbUtilizador_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AdminMethods.ActivityUser(cmbUtilizador.Text);
            if (cmbActions.Text == "CRUD Maquinas")
            {
                AdminMethods.ActivityMaquinas(dataGridView1, cmbUtilizador.Text);
            }
            else if (cmbActions.Text == "CRUD AddOns")
            {
                AdminMethods.ActivityAddOns(dataGridView1, cmbUtilizador.Text);
            }

            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            lblUser.Text = AdminMethods.Username;
            lblEmail.Text = AdminMethods.Email;
        }

        private void btReset_Click(object sender, EventArgs e)
        {

        }
    }
}
