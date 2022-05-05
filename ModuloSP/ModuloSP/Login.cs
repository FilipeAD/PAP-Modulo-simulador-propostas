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

namespace ModuloSP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btLogin;

            txtPassword.PasswordChar = '*';

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" | txtPassword.Text == "")
            {
                MessageBox.Show("Todos os campos devem ser prenchidos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                if (Models.Utilizador.LoginAcount(txtUsername.Text, txtPassword.Text))
                {
                    GeneralView form = new GeneralView();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Verifique o Username ou Password", "!!ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtUsername.Text = "";
                txtPassword.Text = "";
                showPass.Checked = false;
            }
        }



        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUp form = new SignUp();
            form.ShowDialog();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

    }
}
