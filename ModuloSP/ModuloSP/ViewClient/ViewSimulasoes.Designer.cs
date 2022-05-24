namespace ModuloSP.ViewClient
{
    partial class ViewSimulasoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Equipamentos = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelImpressoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCycleBackward = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCycleFoward = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricaoMaquinas = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.Label();
            this.txtDimensoes = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.Equipamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Equipamentos);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1332, 646);
            this.tabControl1.TabIndex = 0;
            // 
            // Equipamentos
            // 
            this.Equipamentos.Controls.Add(this.dataGridView2);
            this.Equipamentos.Location = new System.Drawing.Point(4, 22);
            this.Equipamentos.Name = "Equipamentos";
            this.Equipamentos.Size = new System.Drawing.Size(1324, 620);
            this.Equipamentos.TabIndex = 2;
            this.Equipamentos.Text = "Equipamentos";
            this.Equipamentos.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1324, 620);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1324, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Equipamento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelImpressoras});
            this.statusStrip1.Location = new System.Drawing.Point(3, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1318, 22);
            this.statusStrip1.TabIndex = 54;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Image = global::ModuloSP.Properties.Resources.icons8_printer_30;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 17);
            this.toolStripStatusLabel1.Text = "Produtos Simulação";
            // 
            // toolStripStatusLabelImpressoras
            // 
            this.toolStripStatusLabelImpressoras.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelImpressoras.Name = "toolStripStatusLabelImpressoras";
            this.toolStripStatusLabelImpressoras.Size = new System.Drawing.Size(14, 17);
            this.toolStripStatusLabelImpressoras.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btCycleBackward);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btCycleFoward);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescricaoMaquinas);
            this.panel1.Controls.Add(this.txtCor);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtDimensoes);
            this.panel1.Location = new System.Drawing.Point(53, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 571);
            this.panel1.TabIndex = 53;
            // 
            // btCycleBackward
            // 
            this.btCycleBackward.BackColor = System.Drawing.Color.Black;
            this.btCycleBackward.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCycleBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCycleBackward.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCycleBackward.ForeColor = System.Drawing.Color.White;
            this.btCycleBackward.Location = new System.Drawing.Point(33, 473);
            this.btCycleBackward.Name = "btCycleBackward";
            this.btCycleBackward.Size = new System.Drawing.Size(61, 33);
            this.btCycleBackward.TabIndex = 52;
            this.btCycleBackward.Text = "<<<";
            this.btCycleBackward.UseVisualStyleBackColor = false;
            this.btCycleBackward.Click += new System.EventHandler(this.btCycleBackward_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(753, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btCycleFoward
            // 
            this.btCycleFoward.BackColor = System.Drawing.Color.Black;
            this.btCycleFoward.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btCycleFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCycleFoward.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCycleFoward.ForeColor = System.Drawing.Color.White;
            this.btCycleFoward.Location = new System.Drawing.Point(1142, 473);
            this.btCycleFoward.Name = "btCycleFoward";
            this.btCycleFoward.Size = new System.Drawing.Size(61, 33);
            this.btCycleFoward.TabIndex = 51;
            this.btCycleFoward.Text = ">>>";
            this.btCycleFoward.UseVisualStyleBackColor = false;
            this.btCycleFoward.Click += new System.EventHandler(this.btCycle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dimensões ";
            // 
            // txtDescricaoMaquinas
            // 
            this.txtDescricaoMaquinas.AutoSize = true;
            this.txtDescricaoMaquinas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoMaquinas.Location = new System.Drawing.Point(29, 113);
            this.txtDescricaoMaquinas.Name = "txtDescricaoMaquinas";
            this.txtDescricaoMaquinas.Size = new System.Drawing.Size(82, 19);
            this.txtDescricaoMaquinas.TabIndex = 16;
            this.txtDescricaoMaquinas.Text = "Descricao";
            // 
            // txtCor
            // 
            this.txtCor.AutoSize = true;
            this.txtCor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(138, 370);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(35, 19);
            this.txtCor.TabIndex = 13;
            this.txtCor.Text = "Cor";
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(27, 49);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(184, 33);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.Text = "Marca Modelo";
            // 
            // txtPreco
            // 
            this.txtPreco.AutoSize = true;
            this.txtPreco.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(29, 423);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(59, 23);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.Text = "Preço";
            // 
            // txtDimensoes
            // 
            this.txtDimensoes.AutoSize = true;
            this.txtDimensoes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensoes.Location = new System.Drawing.Point(138, 336);
            this.txtDimensoes.Name = "txtDimensoes";
            this.txtDimensoes.Size = new System.Drawing.Size(90, 19);
            this.txtDimensoes.TabIndex = 1;
            this.txtDimensoes.Text = "Dimensões";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1324, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Extensões Equipamento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1318, 614);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewSimulasoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 646);
            this.Controls.Add(this.tabControl1);
            this.Name = "ViewSimulasoes";
            this.Text = "Simulação";
            this.Activated += new System.EventHandler(this.ViewSimulasoes_Activated);
            this.Load += new System.EventHandler(this.ViewSimulasoes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ViewSimulasoes_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.Equipamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btCycleFoward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDescricaoMaquinas;
        private System.Windows.Forms.Label txtCor;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label txtDimensoes;
        private System.Windows.Forms.Button btCycleBackward;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelImpressoras;
        private System.Windows.Forms.TabPage Equipamentos;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}