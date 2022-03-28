using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP
{
    public partial class AdminView : Form
    {
        

        public AdminView()
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

        private void AdminView_Load(object sender, EventArgs e)
        {
            lblUsername.Text = CurrentUser.username;


        }

        private void btClients_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new ClientList(), sender);
        }

        private void btAddOn_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new AddOnList(), sender);
        }

        private void btMaquinas_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new MachineList(), sender);
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
