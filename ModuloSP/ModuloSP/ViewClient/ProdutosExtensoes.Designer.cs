namespace ModuloSP.ViewClient
{
    partial class ProdutosExtensoes
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
            this.txtDimensoes = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.Label();
            this.txtCategorias = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.Label();
            this.txtDescricaoMaquinas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Extensoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDimensoes
            // 
            this.txtDimensoes.AutoSize = true;
            this.txtDimensoes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensoes.Location = new System.Drawing.Point(491, 371);
            this.txtDimensoes.Name = "txtDimensoes";
            this.txtDimensoes.Size = new System.Drawing.Size(90, 19);
            this.txtDimensoes.TabIndex = 1;
            this.txtDimensoes.Text = "Dimensões";
            // 
            // txtPreco
            // 
            this.txtPreco.AutoSize = true;
            this.txtPreco.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(381, 438);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(59, 23);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.Text = "Preço";
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(381, 38);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(111, 19);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.Text = "Marca Modelo";
            // 
            // txtCategorias
            // 
            this.txtCategorias.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorias.FormattingEnabled = true;
            this.txtCategorias.Location = new System.Drawing.Point(913, 69);
            this.txtCategorias.Name = "txtCategorias";
            this.txtCategorias.Size = new System.Drawing.Size(509, 28);
            this.txtCategorias.TabIndex = 4;
            this.txtCategorias.SelectedIndexChanged += new System.EventHandler(this.txtCategorias_SelectedIndexChanged);
            this.txtCategorias.TextChanged += new System.EventHandler(this.txtCategorias_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.FormattingEnabled = true;
            this.txtNome.Location = new System.Drawing.Point(913, 154);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(509, 28);
            this.txtNome.TabIndex = 6;
            this.txtNome.SelectedIndexChanged += new System.EventHandler(this.txtNome_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 423);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Extensões";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(909, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Categorias";
            // 
            // txtCor
            // 
            this.txtCor.AutoSize = true;
            this.txtCor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(491, 405);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(35, 19);
            this.txtCor.TabIndex = 13;
            this.txtCor.Text = "Cor";
            // 
            // txtDescricaoMaquinas
            // 
            this.txtDescricaoMaquinas.AutoSize = true;
            this.txtDescricaoMaquinas.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoMaquinas.Location = new System.Drawing.Point(382, 57);
            this.txtDescricaoMaquinas.Name = "txtDescricaoMaquinas";
            this.txtDescricaoMaquinas.Size = new System.Drawing.Size(74, 18);
            this.txtDescricaoMaquinas.TabIndex = 16;
            this.txtDescricaoMaquinas.Text = "Descricao";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dimensões ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cor";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Black;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(1265, 428);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(157, 33);
            this.btAdd.TabIndex = 51;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescricaoMaquinas);
            this.panel1.Controls.Add(this.txtCor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.txtCategorias);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtDimensoes);
            this.panel1.Location = new System.Drawing.Point(7, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1451, 492);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(20, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 431);
            this.panel2.TabIndex = 53;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Extensoes});
            this.dataGridView1.Location = new System.Drawing.Point(913, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 181);
            this.dataGridView1.TabIndex = 52;
            // 
            // Extensoes
            // 
            this.Extensoes.HeaderText = "Extensões";
            this.Extensoes.Name = "Extensoes";
            // 
            // ProdutosExtensoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1475, 653);
            this.Controls.Add(this.panel1);
            this.Name = "ProdutosExtensoes";
            this.Text = "Extensões";
            this.Load += new System.EventHandler(this.ProdutosExtensoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtDimensoes;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.ComboBox txtCategorias;
        private System.Windows.Forms.ComboBox txtNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtCor;
        private System.Windows.Forms.Label txtDescricaoMaquinas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extensoes;
        private System.Windows.Forms.Panel panel2;
    }
}