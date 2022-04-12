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
            AdminMethods.CmbUtilizadorItems(cmbUtilizador);

           
        }

        private void cmbUtilizador_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdminMethods.ActivityUser(cmbUtilizador.Text);
            lblUser.Text = AdminMethods.Username;
            lblEmail.Text = AdminMethods.Email;
        }
    }
}
