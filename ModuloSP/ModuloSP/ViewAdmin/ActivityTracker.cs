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
            DateBiggerThan.Enabled = true;
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
          
        }



      
        private void DateBiggerThan_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (cmbActions.Text == "CRUD AddOns")
            {
                AdminMethods.AddOnsRangeDateBigger(dataGridView1, cmbUtilizador.Text, DateBiggerThan.SelectionStart.Date.ToString("yyyy-MM-dd"));
            }
            else if (cmbActions.Text == "CRUD Maquinas")
            {
                AdminMethods.MaquinasRangeDateBigger(dataGridView1, cmbUtilizador.Text, DateBiggerThan.SelectionStart.Date.ToString("yyyy-MM-dd"));
            }
           
            DateSmallerThan.Enabled = true;
        }

        private void cmbActions_Enter(object sender, EventArgs e)
        {
            if (cmbActions.Text == "Ação")
            {
                cmbActions.Text = null;
                cmbActions.ForeColor = Color.Black;
            }
        }

        private void cmbActions_Leave(object sender, EventArgs e)
        {
            if (cmbActions.Text == "")
            {
                cmbActions.Text = "Ação";
                cmbActions.ForeColor = Color.Gray;
            }
        }

        private void cmbUtilizador_Enter(object sender, EventArgs e)
        {
            if (cmbUtilizador.Text == "Utilizador")
            {
                cmbUtilizador.Text = null;
                cmbUtilizador.ForeColor = Color.Black;
            }
        }
        private void cmbUtilizador_Leave(object sender, EventArgs e)
        {
            if (cmbUtilizador.Text == "")
            {
                cmbUtilizador.Text = "Utilizador";
                cmbUtilizador.ForeColor = Color.Gray;
            }
        }

        private void DateSmallerThan_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (DateBiggerThan.SelectionStart.Date >= DateSmallerThan.SelectionStart.Date)
            {
                MessageBox.Show("Intervalo de tempo incorreto", "Aviso",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cmbActions.Text == "CRUD AddOns")
                {
                    AdminMethods.AddOnsRangeDateSmaller(dataGridView1, cmbUtilizador.Text, DateBiggerThan.SelectionStart.Date.ToString("yyyy-MM-dd"), DateSmallerThan.SelectionStart.Date.ToString("yyyy-MM-dd"));
                }
                else if (cmbActions.Text == "CRUD Maquinas")
                {
                    AdminMethods.MaquinasRangeDateSmaller(dataGridView1, cmbUtilizador.Text, DateBiggerThan.SelectionStart.Date.ToString("yyyy-MM-dd"), DateSmallerThan.SelectionStart.Date.ToString("yyyy-MM-dd"));
                }
            }
            
        }
    }
}
