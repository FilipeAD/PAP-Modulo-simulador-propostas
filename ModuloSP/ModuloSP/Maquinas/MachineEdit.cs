using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Maquinas
{
    public partial class MachineEdit : Form
    {
        public MachineEdit()
        {
            InitializeComponent();
        }

        private void MachineEdit_Load(object sender, EventArgs e)
        {
            FunctionsMaq.LoadMachine(Models.IDManagment.IdMaquina, txtCor, txtDimensoes, txtPreco, Models.IDManagment.fkMarca_Modelo);
            FunctionsMaq.LoadCMB(txtMarca.Text, txtModelo.Text);
        }


        private void btEditar_Click(object sender, EventArgs e)
        {
            FunctionsMaq.EditMachine(Models.IDManagment.IdMaquina, txtCor.Text, txtDimensoes.Text, txtPreco.Text);
            this.Close();
        }
    }
}
