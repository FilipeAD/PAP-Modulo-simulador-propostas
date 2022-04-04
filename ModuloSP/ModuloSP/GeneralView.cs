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

        private void GroupVerification(object btSend)
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {

               
                SqlCommand cmd = new SqlCommand("GroupVerification", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue("@group", txtSearch.Text);
                SqlDataReader rd = cmd.ExecuteReader();

                
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Utils.GroupSearch = rd["Nome"].ToString();
                    }
                    //OpenSecondForm(new GPermissionsList(), btSend);
                }
                else
                {
                    MessageBox.Show("Grupo não existe", "!!ERRO!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSearch.Text = "Procure um grupo especifico nas permissões";
                    txtSearch.ForeColor = Color.Gray;
                }
                con.Close();
            }
        }

        private void mudaform(Form _form)
        {
            _form.WindowState = FormWindowState.Maximized;
            _form.MdiParent = this;
            _form.Size = this.Size;
            _form.Show();
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
            if(Menu.Visible == false)
            {
                Menu.Visible = true;
            }
            else
            {
                Menu.Visible = false;   
            }

        }

        private void btPermissões_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Procure um grupo especifico nas permissões")
            {
                //OpenSecondForm(new GPermissionsList(), sender);
            }
            else
            {
                GroupVerification(sender);
            }
            
        }

        private void txtGrupo_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Procure um grupo especifico nas permissões")
            {
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtGrupo_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Procure um grupo especifico nas permissões";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }



        private void listUtilizadores_Click(object sender, EventArgs e)
        {
            var userList = new UserList();
            mudaform(userList);
        }



        private void ListImpressoras_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Maquinas.MachineList))
                {
                    frm.Activate();
                    return;
                }
            }
            
            Maquinas.MachineList load = new Maquinas.MachineList();
            mudaform(load);
        }

        private void ListAddOns_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(AddOn.AddOnList))
                {
                    frm.Activate();
                    return;
                }
            }

            AddOn.AddOnList load = new AddOn.AddOnList();
            mudaform(load);
        }



        private void marcaModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marc_Mod.MarcaModeloList))
                {
                    frm.Activate();
                    return;
                }
            }

            Marc_Mod.MarcaModeloList load = new Marc_Mod.MarcaModeloList();
            mudaform(load);
        }

        private void ListMarca_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marca.MarcaList))
                {
                    frm.Activate();
                    return;
                }
            }

            Marca.MarcaList load = new Marca.MarcaList();
            mudaform(load);
        }
    }
}
