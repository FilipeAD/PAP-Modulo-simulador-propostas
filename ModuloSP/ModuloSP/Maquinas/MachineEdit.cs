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
        string ADDColor;

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
            FunctionsMaq.EditMachine(maquina, ADDColor, txtDimensoes.Text, txtPreco.Text, pictureBox1);
            this.Close();
        }

        private void btConectImage_Click(object sender, EventArgs e)
        {
            FunctionsMaq.UploadImage(pictureBox1);
        }

        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                ADDColor = "#" + (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                txtCor.BackColor = colorDialog1.Color;

            }
        }

        private void lblMarca_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marca.MarcaList))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new Marca.MarcaList();

            Models.Utils._form.mudaform(userList);
        }

        private void lblModelo_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(Marc_Mod.MarcaModeloList))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new Marc_Mod.MarcaModeloList();

            Models.Utils._form.mudaform(userList);
        }
    }
}
