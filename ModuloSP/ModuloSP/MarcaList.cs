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
    public partial class MarcaList : Form
    {
        public MarcaList()
        {
            InitializeComponent();
        }

        private Form activeForm;

        private void OpenSecondForm(Form SecondForm, object btSend)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = SecondForm;
            SecondForm.TopLevel = false;
            SecondForm.FormBorderStyle = FormBorderStyle.None;
            SecondForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(SecondForm);
            this.DesktopPanel.Tag = SecondForm;
            SecondForm.BringToFront();
            SecondForm.Show();


        }
        private void INFOMarca()
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select ID, Nome as Marca from marca";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
            }
        }


        private void MarcaList_Load(object sender, EventArgs e)
        {
            INFOMarca();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btBack.Visible = true;
            DesktopPanel.Visible = true;
            OpenSecondForm(new MarcaAdd(), sender);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IDEditar.IdMarca == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btBack.Visible = true;
                DesktopPanel.Visible = true;
                OpenSecondForm(new MarcaEdit(), sender);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Prosseguir e eliminar?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(Utils.conString);
                con.Open();
                string query = "DELETE Marca where ID= '" + IDEditar.IdMarca+ "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registo eliminado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            INFOMarca();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEditar.IdMarca = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DesktopPanel.Visible = false;
            btBack.Visible = false;
            INFOMarca();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }
    }
}
