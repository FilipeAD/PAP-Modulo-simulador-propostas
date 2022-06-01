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
    public partial class ViewSimulasoes : Form
    {
        public ViewSimulasoes()
        {
            InitializeComponent();
        }

        List<string> listMaqui = new List<string>(ProductFilters.MaquinasList(ProductFilters.IDSimulacao));
        List<string> listEquip = new List<string>(ProductFilters.EquipamentosList(ProductFilters.IDSimulacao));

        int i = 0;
        private void Datagrid()
        {
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }



        private void ViewSimulasoes_Load(object sender, EventArgs e)
        {
            ProductFilters.LoadSimulacaoEquipamentos(dataGridView2, ProductFilters.IDSimulacao);
            Models.FunctionsGeneral.EditDataGrid(dataGridView2);

            //#--------------------------------------------------------------------------------------------------#


            toolStripStatusLabelImpressoras.Text = listEquip.Count.ToString();


            ProductFilters.PrecoAddMaq(listEquip[i], ProductFilters.IDSimulacao);
            ProductFilters.LoadEquipamentoSimulacao(listEquip[i], txtDimensoes, txtPreco, txtCor, pictureBox1, txtDescricaoMaquinas);
            ProductFilters.LoadImMarcaMod(Models.IDManagment.fkMarca_Modelo, txtMarca);

            txtDescricaoMaquinas.AutoSize = true;
            txtDescricaoMaquinas.MaximumSize = new Size(500, 50);

            ProductFilters.LoadAddOnsSimulacao(dataGridView1, listEquip[i]);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            Datagrid();

        }



        private void btCycle_Click(object sender, EventArgs e)
        {
            if (i < listEquip.Count)
            {
                i++;
            }
            if (i >= listEquip.Count)
            {
                i = 0;
            }

            ProductFilters.PrecoAddMaq(listEquip[i], ProductFilters.IDSimulacao);
            ProductFilters.LoadEquipamentoSimulacao(listEquip[i], txtDimensoes, txtPreco, txtCor, pictureBox1, txtDescricaoMaquinas);
            ProductFilters.LoadImMarcaMod(Models.IDManagment.fkMarca_Modelo, txtMarca);

            ProductFilters.LoadAddOnsSimulacao(dataGridView1, listEquip[i]);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            Datagrid();

        }

        private void btCycleBackward_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                i = listEquip.Count;
            }
            if (i <= listEquip.Count)
            {
                i--;
            }

            ProductFilters.PrecoAddMaq(listEquip[i], ProductFilters.IDSimulacao);
            ProductFilters.LoadEquipamentoSimulacao(listEquip[i], txtDimensoes, txtPreco, txtCor, pictureBox1, txtDescricaoMaquinas);
            ProductFilters.LoadImMarcaMod(Models.IDManagment.fkMarca_Modelo, txtMarca);

            ProductFilters.LoadAddOnsSimulacao(dataGridView1, listEquip[i]);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            Datagrid();
        }

        private void ViewSimulasoes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    e.SuppressKeyPress= true;

                    btCycleBackward.PerformClick();
                   
                    break;

                case Keys.Right:
                    e.SuppressKeyPress = true;

                    btCycleFoward.PerformClick();
                   
                    break;

            }
        }

        private void ViewSimulasoes_Activated(object sender, EventArgs e)
        {
           
        }
    }
}
