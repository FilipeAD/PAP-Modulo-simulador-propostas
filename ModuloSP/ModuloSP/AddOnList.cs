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

namespace ModuloSP
{
    public partial class AddOnList : Form
    {
        public AddOnList()
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

        private void INFOAddOn()
        {
            using (SqlConnection con =
                new SqlConnection(Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select ID, Nome, Preco_Base from AddOns";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
            }
        }

        private void AddOnList_Load(object sender, EventArgs e)
        {
            INFOAddOn();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

        }

      

        


        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btBack.Visible = true;
            DesktopPanel.Visible = true;
            OpenSecondForm(new AddOnAdd(), sender);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IDEditar.IdAddOn == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btBack.Visible = true;
                DesktopPanel.Visible = true;
                OpenSecondForm(new AddOnEdit(), sender);
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            DesktopPanel.Visible = false;
            btBack.Visible = false;
            INFOAddOn();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
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
                string query = "DELETE AddOns where ID=" + (int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registo eliminado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
            INFOAddOn();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEditar.IdAddOn = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
