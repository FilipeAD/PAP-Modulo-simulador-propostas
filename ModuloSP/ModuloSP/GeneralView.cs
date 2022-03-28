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
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {

                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "SELECT * from Utilizador where Nome = '" + CurrentUser.username + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                Clipboard.SetText(query);
                da.Fill(dt);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CurrentUser.IDUser = dr["ID"].ToString();
                    CurrentUser.username = dr["Nome"].ToString();
                }

                con.Close();
            }

        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            











            lblUsername.Text = CurrentUser.username;


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAddOns_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new AddOnList(), sender);
            if (panel6.Height == 199)
            {
                panel6.Height = 60;
            }
            else
            {
                panel6.Height = 199;
            }
        }

        private void btClients_Click_1(object sender, EventArgs e)
        {
            OpenSecondForm(new ClientList(), sender);

            panel7.Visible = false;


        }

        private void btMaquinas_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new MachineList(), sender);
            if (panel5.Height == 199)
            {
                panel5.Height = 60;
            }
            else
            {
                panel5.Height = 199;
            }
        }
    }
}
