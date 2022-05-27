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
    public partial class ProdutoShow : Form
    {
        public ProdutoShow()
        {
            InitializeComponent();
        }
        private void DatagridStyle()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 242, 242);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(178, 178, 178);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(94, 94, 94);
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(94, 94, 94);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
        }

        private void AddExtensoes()
        {
            ProductFilters.produtos.Clear();
            ProductFilters.ModelAddOnsID.Clear();
            ProductFilters.extensoes.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                if ((bool)(dataGridView1.Rows[i].Cells["Slt"].Value) == true)
                {
                    ProductFilters.IDExtensoes = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    ProductFilters.ExtensoesID(Models.IDManagment.fkMarca_Modelo, dataGridView1.Rows[i].Cells[1].Value.ToString());
                    ProductFilters.ModelAddOnsID.Add(ProductFilters.IDModExtensoes);

                    ProductFilters.extensoes.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());


                    ProductFilters.produtos.Add(new Models.VMProduct
                    {
                        ID = Convert.ToInt32(ProductFilters.IDExtensoes),
                        quantidade = Convert.ToInt32((dataGridView1.Rows[i].Cells["QTD"].Value)),
                        preco = Convert.ToDouble((dataGridView1.Rows[i].Cells["Preco"].Value)),
                        IDMarcaModelo = Convert.ToInt32(Models.IDManagment.fkMarca_Modelo)
                    });

                }
            }
        }


        private void ProdutosExtensoes_Load(object sender, EventArgs e)
        {
            ProductFilters.LoadMachine(ProductFilters.ID, txtDimensoes, txtPreco, txtCor, pictureBox1, txtDescricaoMaquinas);
            ProductFilters.LoadImMarcaMod(Models.IDManagment.fkMarca_Modelo, txtMarca);
            txtDescricaoMaquinas.AutoSize = true;
            txtDescricaoMaquinas.MaximumSize = new Size(500, 50);



            //----------------------------------------Extensoes----------------------------------------------

            ProductFilters.extensoes.Clear();
            ProductFilters.produtos.Clear();


            ProductFilters.CmbInsertM("Add_Ons_Grupos", cmbOrder);
            cmbOrder.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbOrder.AutoCompleteSource = AutoCompleteSource.ListItems;


            ProductFilters.ShowAddOns(dataGridView1, Models.IDManagment.fkMarca_Modelo);
            DatagridStyle();

        }



        private void txtCor_TextChanged(object sender, EventArgs e)
        {
            txtCor.BackColor = ColorTranslator.FromHtml(txtCor.Text);
        }

   



        private void toolStripExtensoes_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            AddExtensoes();
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells["Slt"].Value) == true && row.Cells["QTD"].Value == null)
                {
                    row.Cells["QTD"].Value = "1";
                }

            }


            int sum = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["QTD"].Value);


            }
            QExtensoes.Text = sum.ToString();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    e.SuppressKeyPress = true;
                    dataGridView1.EndEdit();
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if ((bool)(row.Cells["Slt"].Value) == true && row.Cells["QTD"].Value == null)
                        {
                            row.Cells["QTD"].Value = "1";
                        }

                    }


                    int sum = 0;

                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["QTD"].Value);


                    }
                    QExtensoes.Text = sum.ToString();
                    break;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            AddExtensoes();
            if (Models.IDManagment.IdSimulacao == "")
            {
                if (MessageBox.Show("Prosseguir e iniciar Proposta ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    ProductFilters.Simulacao();

                    ProductFilters.Equipamentos();
                    ProductFilters.ListCycle(ProductFilters.produtos, ProductFilters.ModelAddOnsID);

                    ProductFilters.produtos.Clear();

                    Models.Utils._form.closeForms(new Produtos());
                    ProductFilters.produtos.Clear();
                    ProductFilters.ModelAddOnsID.Clear();
                    this.Close();


                }
            }
            else
            {
                ProductFilters.Equipamentos();
                ProductFilters.ListCycle(ProductFilters.produtos, ProductFilters.ModelAddOnsID);

                ProductFilters.produtos.Clear();

                Models.Utils._form.closeForms(new Produtos());

                this.Close();
            }

        }
    }
}
