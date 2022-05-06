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
        string maquina = string.Empty;

        public MachineEdit(string _maquina)
        {
            InitializeComponent();

            maquina = _maquina;
        }

        public MachineEdit()
        {
            InitializeComponent();

            maquina = Models.IDManagment.IdMaquina;

            Models.IDManagment.IdMaquina = string.Empty;
        }

        private void MachineEdit_Load(object sender, EventArgs e)
        {
            FunctionsMaq.LoadMaquinasEditar(maquina, txtCor, txtDimensoes, txtPreco, pictureBox1);
            FunctionsMaq.LoadCMB(txtMarca, txtModelo, Models.IDManagment.fkMarca_Modelo);
        }


        private void btEditar_Click(object sender, EventArgs e)
        {
            FunctionsMaq.EditMachine(maquina, txtCor.Text, txtDimensoes.Text, txtPreco.Text, pictureBox1);
            this.Close();
        }

        private void btConectImage_Click(object sender, EventArgs e)
        {
            FunctionsMaq.UploadImage(pictureBox1);
        }
    }
}
