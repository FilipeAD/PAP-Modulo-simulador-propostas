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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }


        private void CreateAcount()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Todos os campos devem ser prenchidos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Models.Utilizador.VField(txtUsername, "verify_username", "@nome"))
            {
                MessageBox.Show("Username já existe", "!!ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                if (Models.Utilizador.VField(txtEmail, "verify_email", "@email"))
                {
                    MessageBox.Show("Email já existe", "!!ERRO!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Models.Utilizador.ValidEmail(txtEmail.Text) != true)
                    {
                        MessageBox.Show("Email Invalido", "!!ERRO!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (txtPassword.Text != txtPassword2.Text)
                        {
                            MessageBox.Show("Password não coincide", "!!ERRO!!",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            SqlConnection con =
                               new SqlConnection(Models.Utils.conString);
                            con.Open();
                            string query = "INSERT INTO Utilizador(" +
                                "id,nome,email,password,fk_Grupos_ID )" +
                                "VALUES (@id,@nome,@email,@password,@fk_Grupos_ID)";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@id", Models.IDManagment.InsereID("Utilizador"));
                            cmd.Parameters.AddWithValue("@nome", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@fk_Grupos_ID", 1);
                            try
                            {
                                cmd.ExecuteScalar();
                            }
                            catch
                            {
                                MessageBox.Show("Reveja os dados inseridos", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            MessageBox.Show("Registo inserido", "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            con.Close();
                            this.Close();
                        }
                    }
                }
            }
        }




        private void SignUp_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
            this.AcceptButton = btLogin;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword2.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword2.UseSystemPasswordChar = false;
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {

            CreateAcount();

        }

    }
}
