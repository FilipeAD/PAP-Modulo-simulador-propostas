﻿using System;
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
                    OpenSecondForm(new GPermissionsList(), btSend);
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
                OpenSecondForm(new GPermissionsList(), sender);
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
            OpenSecondForm(new UserList(), sender);
        }

        private void ListImpressoras_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new MachineList(), sender);
        }

        private void ListAddOns_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new AddOnList(), sender);
        }

        private void mainaction_Click(object sender, EventArgs e)
        {

        }

        private void ListMarca_Click_1(object sender, EventArgs e)
        {
            OpenSecondForm(new MarcaList(), sender);
        }

        private void ListModelo_Click_1(object sender, EventArgs e)
        {
            OpenSecondForm(new ModeloList(), sender);
        }
    }
}
