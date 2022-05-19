using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewClient
{
    public partial class ListSimulacao : Form
    {
        public ListSimulacao()
        {
            InitializeComponent();
        }

        private void Simulacao_Load(object sender, EventArgs e)
        {
            //ProductFilters.Simulacao();
            ProductFilters.ShowSimulacao(dataGridView1, Models.CurrentUser.IDUser);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewClient.Produtos))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new ViewClient.Produtos();

            Models.Utils._form.mudaform(userList);
        }
    }
}
