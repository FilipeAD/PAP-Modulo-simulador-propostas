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

            Models.Utils._form = this;
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void Permissionview()
        {
            var list = Permissoes.AcountPermission.LoginPermission();

            if (Permissoes.AcountPermission.LoginView(list, "Visualizar todos os utilizadores"))
            {
                btUsers.Visible = true;
                listUtilizadores.Visible = true;
            }
            if (Permissoes.AcountPermission.LoginView(list, "CRUD Maquinas"))
            {
                btEquipamentos.Visible = true;
                ListImpressoras.Visible = true;
            }
            if (Permissoes.AcountPermission.LoginView(list, "CRUD AddOns"))
            {
                btEquipamentos.Visible = true;
                ListAddOns.Visible = true;
            }
            if (Permissoes.AcountPermission.LoginView(list, "Visualizar e editar Permissões"))
            {
                btUsers.Visible = true;
                ListPermicoes.Visible = true;
            }
            if (Permissoes.AcountPermission.LoginView(list, "Visualizar produtos para compra"))
            {
                btActionClient.Visible = true;
                InterfaceClient.Visible = true;
            }
          
        }

        public void closeForms()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }
        }

        public void closeForms(Form _form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name != _form.Name)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }

        public void mudaform(Form _form)
        {
            _form.WindowState = FormWindowState.Maximized;
            _form.MdiParent = this;
            _form.Size = this.Size;

            //Esc:
            _form.KeyPreview = true;
            _form.KeyDown += _form_KeyDown;

            _form.Show();
        }

        private void _form_KeyDown(object sender, KeyEventArgs e)
        {
            Form _f = (Form)sender;

            switch(e.KeyCode)
            {
                case Keys.Escape:

                    _f.Close();

                    break;
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------



        private void AdminView_Load(object sender, EventArgs e)
        {
            lblEmail.Text = Models.CurrentUser.email;
            lblUsername.Text = Models.CurrentUser.username;
            Permissionview();

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewAdmin.ActivityTracker))
                {
                    frm.Activate();
                    return;
                }
            }

            var load = new ViewAdmin.ActivityTracker();
            mudaform(load);
        }




        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Têm a certeza que pretende sair?", "Atenção", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Models.IDManagment.IdSimulacao = "";
                ViewClient.ProductFilters.NumImpressoras = "";
                Models.CurrentUser.IDUser = "";
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

        private void Menu_ItemAdded(object sender, ToolStripItemEventArgs e)
        {
            if (e.Item.Text == "")
            {
                e.Item.Visible = false;
            }
        }



        //------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        private void ListAddOns_Click_1(object sender, EventArgs e)
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

        private void lstAddOn_Click(object sender, EventArgs e)
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

       

        private void ListImpressoras_Click_1(object sender, EventArgs e)
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


        private void listMaquina_Click(object sender, EventArgs e)
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

        private void listUtilizadores_Click_1(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewAdmin.UserList))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new ViewAdmin.UserList();
            mudaform(userList);

        }



        private void InterfaceClient_Click(object sender, EventArgs e)
        {
            Menu.Visible = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewClient.ListSimulacao))
                {
                    frm.Activate();
                    return;
                }
            }

            ViewClient.ListSimulacao load = new ViewClient.ListSimulacao();
            mudaform(load);
        }


        private void ListMarca_Click_1(object sender, EventArgs e)
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

        private void ListMarcaModelo_Click(object sender, EventArgs e)
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

        private void ListPermicoes_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Permissoes.GPermissionsList))
                {
                    frm.Activate();
                    return;
                }
            }

            var load = new Permissoes.GPermissionsList();
            mudaform(load);
        }

        private void GeneralView_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (Models.CurrentUser.IDUser != "")
            {
                DialogResult dialogResult = MessageBox.Show("Têm a certeza que pretende sair?", "Atenção", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Models.IDManagment.IdSimulacao = "";
                    ViewClient.ProductFilters.NumImpressoras = "";
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            
        }
    }
}
