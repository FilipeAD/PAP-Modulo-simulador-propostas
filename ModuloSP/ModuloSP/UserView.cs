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
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
        }


        private void UserView_Load(object sender, EventArgs e)
        {
            lblUsername.Text = CurrentUser.username;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
