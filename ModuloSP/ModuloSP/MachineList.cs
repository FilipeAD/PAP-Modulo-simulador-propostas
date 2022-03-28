using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP
{
    public partial class MachineList : Form
    {
        public MachineList()
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

        private void INFOMaquinas()
        {
            using (SqlCeConnection con =
                new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf"))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select * from maquinas";
                SqlCeDataAdapter da = new SqlCeDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                dataGridView1.DataSource = bs;
                con.Close();
            }
        }
        private void MachineList_Load(object sender, EventArgs e)
        {
            INFOMaquinas();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new MachineAdd(), sender);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Prosseguir com a remoção ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            else
            {
                SqlCeConnection con = new SqlCeConnection(@"Data Source=|DataDirectory|\DataModSP.sdf");
                con.Open();
                string query = "DELETE Maquinas where ID=" + (int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                SqlCeCommand cmd = new SqlCeCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registo Removido", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            OpenSecondForm(new MachineEdit(), sender);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDEditar.IdMaquina = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
