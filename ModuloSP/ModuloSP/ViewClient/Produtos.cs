﻿using System;
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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            ProductFilters.CmbOrderItems(cmbOrder);
            ProductFilters.CmbColorItems(cmbColor);
            ProductFilters.CmbInsertM(cmbMarca);
        }

        private void cmbOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbOrder.Text, cmbColor.Text, cmbMarca.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void cmbColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbColor.Text, cmbMarca.Text, cmbOrder.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void cmbMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbMarca.Text, cmbColor.Text, cmbOrder.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cmbColor.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            Maquinas.FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("YES");
        }

    }
}