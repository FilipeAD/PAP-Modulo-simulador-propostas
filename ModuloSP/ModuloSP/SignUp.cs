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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        int novoID = 0;
        int REmail = 0;
        int RUsername = 0;

        private void InsereID()
        {
            
            string query = "SELECT MAX(id) FROM Cliente";
            using (SqlCeConnection con =
                new SqlCeConnection(@"DataSource=|DataDirectory|\DataModSP.sdf"))
            {
                using (SqlCeCommand cmd = new SqlCeCommand(query, con))
                {
                    con.Open();
                    try
                    {
                        novoID = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
                    }
                    catch
                    {
                        novoID = 1;
                        return;
                    }
                }
                con.Close();
            }
        }
        private void RUserClient()
        {
            using (SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf"))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "SELECT * from Cliente where Nome = '" + txtUsername.Text.Trim() + "'";
                SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    RUsername = 1;
                }
                else
                {
                    RUsername = 0;
                }
                con.Close();
            }
        }
        private void REmailClient()
        {
            using (SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf"))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "SELECT * from Cliente where Email = '" + txtEmail.Text.Trim() + "'";
                SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    REmail = 1;

                }
                else
                {
                    REmail = 0;
                }
                con.Close();
            }
        }
        private void CreateAcount()
        {
            InsereID();
            RUserClient();
            REmailClient();


            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) )
            {
                MessageBox.Show("Todos os campos devem ser prenchidos ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            if (RUsername == 1)
            {
                MessageBox.Show("Username já existe", "!!ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                if (REmail == 1)
                {
                    MessageBox.Show("Email já existe", "!!ERRO!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCeConnection con =
                       new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf");
                        con.Open();
                    string query = "INSERT INTO Cliente(" +
                        "id,nome,email,password)" +
                        "VALUES (@id,@nome,@email,@password)";
                    SqlCeCommand cmd = new SqlCeCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", novoID);
                    cmd.Parameters.AddWithValue("@nome", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
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



        private void SignUp_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            txtPassword2.PasswordChar = '*';
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
