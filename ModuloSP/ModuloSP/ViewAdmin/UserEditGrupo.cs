using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewAdmin
{
    public partial class UserEditGrupo : Form
    {
        public UserEditGrupo()
        {
            InitializeComponent();
        }

        private void UserEditGrupo_Load(object sender, EventArgs e)
        {

            AdminMethods.LoadUserEditar(Models.IDManagment.IdUser, txtNome, txtEmail, txtGrupo);


            Permissoes.AcountPermission.IDNivel();
            Permissoes.AcountPermission.LoadGrupoCombobox(txtGrupo);

        }

        private void btEditar_Click(object sender, EventArgs e)
        {

            Permissoes.AcountPermission.GetIDGrupo(txtGrupo.Text);
            Permissoes.AcountPermission.EditGrupo(Models.IDManagment.IdUser, Models.Utils.Grupo);
            this.Close();


        }

    }
}
