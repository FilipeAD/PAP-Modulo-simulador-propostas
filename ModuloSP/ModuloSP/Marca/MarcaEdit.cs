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

namespace ModuloSP.Marca
{
    public partial class MarcaEdit : Form
    {
        public MarcaEdit()
        {
            InitializeComponent();
        }

        private void MarcaEdit_Load(object sender, EventArgs e)
        {
            FunctionsMarca.LoadMarca(Models.IDManagment.IdMarca, txtNome);

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FunctionsMarca.EditMarca("Marca", Models.IDManagment.IdMarca, txtNome.Text);
            this.Close();
        }
    }
}
