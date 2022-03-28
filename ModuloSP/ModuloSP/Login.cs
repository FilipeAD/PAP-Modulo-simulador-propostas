using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void LoginClient()
        {
            using (SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf"))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "SELECT * from Cliente where Nome = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
                SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCeCommand cmd = new SqlCeCommand(query, con);
                    SqlCeDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CurrentUser.IDUser = dr["ID"].ToString();
                        CurrentUser.username = dr["Nome"].ToString();
                    }
                    UserView form = new UserView();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Verifique o Username ou Password", "!!ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        }

        private void LoginAdmin()
        {
            using (SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf"))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "SELECT * from Administrador where Nome = '" + txtUsername.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
                SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCeCommand cmd = new SqlCeCommand(query, con);
                    SqlCeDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        CurrentUser.IDUser = dr["ID"].ToString();
                        CurrentUser.username = dr["Nome"].ToString();
                    }
                    AdminView form = new AdminView();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Verifique o Username ou Password", "!!ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                con.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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
                if (btLogin.Text == "LOG IN ADMIN")
                {
                    LoginAdmin();
                }
                else
                {
                    LoginClient();
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (btLogin.Text == "LOG IN")
            {
                btLogin.Text = "LOG IN ADMIN";
            }
            else
            {
                btLogin.Text = "LOG IN";
            }
            
        }
    }
}
