namespace ModuloSP.ViewClient
{
    partial class ProdutoShow
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
            this.txtCor = new System.Windows.Forms.Label();
            this.txtDescricaoMaquinas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btExtensoes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btConect = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // txtCor
            // 
            this.txtCor.AutoSize = true;
            this.txtCor.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(138, 370);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(35, 19);
            this.txtCor.TabIndex = 13;
            this.txtCor.Text = "Cor";
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
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
            // btExtensoes
            // 
            this.btExtensoes.BackColor = System.Drawing.Color.Black;
            this.btExtensoes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btExtensoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExtensoes.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExtensoes.ForeColor = System.Drawing.Color.White;
            this.btExtensoes.Location = new System.Drawing.Point(744, 477);
            this.btExtensoes.Name = "btExtensoes";
            this.btExtensoes.Size = new System.Drawing.Size(157, 33);
            this.btExtensoes.TabIndex = 51;
            this.btExtensoes.Text = "ACESSÓRIOS";
            this.btExtensoes.UseVisualStyleBackColor = false;
            this.btExtensoes.Click += new System.EventHandler(this.btExtensoes_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btConect);
            this.panel1.Controls.Add(this.btExtensoes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescricaoMaquinas);
            this.panel1.Controls.Add(this.txtCor);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.txtPreco);
            this.panel1.Controls.Add(this.txtDimensoes);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 552);
            this.panel1.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(624, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btConect
            // 
            this.btConect.BackColor = System.Drawing.Color.Black;
            this.btConect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btConect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConect.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConect.ForeColor = System.Drawing.Color.White;
            this.btConect.Location = new System.Drawing.Point(917, 477);
            this.btConect.Name = "btConect";
            this.btConect.Size = new System.Drawing.Size(157, 33);
            this.btConect.TabIndex = 54;
            this.btConect.Text = "CONECTAR";
            this.btConect.UseVisualStyleBackColor = false;
            // 
            // ProdutoShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 576);
            this.Controls.Add(this.panel1);
            this.Name = "ProdutoShow";
            this.Text = "Extensões";
            this.Load += new System.EventHandler(this.ProdutosExtensoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtDimensoes;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.Label txtCor;
        private System.Windows.Forms.Label txtDescricaoMaquinas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btExtensoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btConect;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}