using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP
{
    public partial class GeneralView : Form
    {
        

        public GeneralView()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenSecondForm(Form SecondForm, object btSend)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = SecondForm;
            SecondForm.TopLevel = false;
            SecondForm.FormBorderStyle = FormBorderStyle.None;
            SecondForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(SecondForm);
            this.DesktopPanel.Tag = SecondForm;
            SecondForm.BringToFront();
            SecondForm.Show();


        }


        private void GroupPermissions()
        {
           if (CurrentUser.group == "3")
            {



            }

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            










            lblEmail.Text = CurrentUser.email;
            lblUsername.Text = CurrentUser.username;


        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Têm a certeza que pretende sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (userpanel.Visible == false)
            {
                userpanel.Visible = true;
            }
            else
            {
                userpanel.Visible = false;
            }
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            if (panel5.Width == 61)
            {
                panel5.Width = 136;
            }
            else
            {
                panel5.Width = 61;
            }
            
        }

        private void btAddOns_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new AddOnList(), sender);
        }

        private void btUtilizadores_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new UserList(), sender);
        }

        private void btMaquinas_Click_1(object sender, EventArgs e)
        {
            OpenSecondForm(new MachineList(), sender);
        }
    }
}
