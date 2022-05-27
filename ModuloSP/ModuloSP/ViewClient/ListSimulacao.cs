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
            ProductFilters.ShowSimulacao(dataGridView1, Models.CurrentUser.IDUser);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Models.IDManagment.IdSimulacao = "";

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

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (ProductFilters.IDSimulacao == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(ViewClient.ViewSimulasoes))
                    {
                        frm.Activate();
                        return;
                    }
                }
                var userList = new ViewClient.ViewSimulasoes();

                Models.Utils._form.mudaform(userList);
            }

         
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductFilters.IDSimulacao = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ListSimulacao_Activated(object sender, EventArgs e)
        {
            ProductFilters.ShowSimulacao(dataGridView1, Models.CurrentUser.IDUser);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            toolStripStatusLabel3.Text = "  " + DateTime.Now.ToLocalTime().ToShortDateString().ToString() + "  ";
            toolStripStatusLabelImpressoras.Text = dataGridView1.Rows.Count.ToString();
        }

       
    }
}
