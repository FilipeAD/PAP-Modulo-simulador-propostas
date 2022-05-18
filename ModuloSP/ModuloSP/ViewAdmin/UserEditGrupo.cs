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
            Maquinas.FunctionsMaq.CmbInsertM("Grupos", txtGrupo);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
