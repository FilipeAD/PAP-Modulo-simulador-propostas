
namespace ModuloSP.Maquinas
{
    partial class MachineAdd
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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtDimensoes = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btConectImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPreco.Location = new System.Drawing.Point(274, 416);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(250, 26);
            this.txtPreco.TabIndex = 25;
            this.txtPreco.Text = "Preço";
            this.txtPreco.Enter += new System.EventHandler(this.txtPreco_Enter);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // txtCor
            // 
            this.txtCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCor.Location = new System.Drawing.Point(274, 309);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(250, 26);
            this.txtCor.TabIndex = 34;
            this.txtCor.Text = "Cor";
            this.txtCor.Click += new System.EventHandler(this.txtCor_Click);
            this.txtCor.Enter += new System.EventHandler(this.txtCor_Enter);
            this.txtCor.Leave += new System.EventHandler(this.txtCor_Leave);
            // 
            // txtDimensoes
            // 
            this.txtDimensoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDimensoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensoes.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDimensoes.Location = new System.Drawing.Point(274, 213);
            this.txtDimensoes.Name = "txtDimensoes";
            this.txtDimensoes.Size = new System.Drawing.Size(250, 26);
            this.txtDimensoes.TabIndex = 35;
            this.txtDimensoes.Text = "Dimensões";
            this.txtDimensoes.Enter += new System.EventHandler(this.txtDimensoes_Enter);
            this.txtDimensoes.Leave += new System.EventHandler(this.txtDimensoes_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.ItemHeight = 20;
            this.txtMarca.Location = new System.Drawing.Point(274, 95);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(250, 28);
            this.txtMarca.TabIndex = 36;
            this.txtMarca.SelectedIndexChanged += new System.EventHandler(this.txtMarca_SelectedIndexChanged);
            this.txtMarca.Enter += new System.EventHandler(this.txtMarca_Enter);
            this.txtMarca.Leave += new System.EventHandler(this.txtMarca_Leave);
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtModelo.FormattingEnabled = true;
            this.txtModelo.ItemHeight = 20;
            this.txtModelo.Location = new System.Drawing.Point(599, 95);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(273, 28);
            this.txtModelo.TabIndex = 37;
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAdd.BackColor = System.Drawing.Color.Black;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ForeColor = System.Drawing.Color.White;
            this.btAdd.Location = new System.Drawing.Point(274, 488);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(250, 33);
            this.btAdd.TabIndex = 38;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Bahnschrift", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(270, 54);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 19);
            this.lblMarca.TabIndex = 39;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Bahnschrift", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(595, 54);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(62, 19);
            this.lblModelo.TabIndex = 40;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dimensões";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cor";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Imagem";
            // 
            // btConectImage
            // 
            this.btConectImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConectImage.BackColor = System.Drawing.Color.Black;
            this.btConectImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btConectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConectImage.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConectImage.ForeColor = System.Drawing.Color.White;
            this.btConectImage.Location = new System.Drawing.Point(599, 488);
            this.btConectImage.Name = "btConectImage";
            this.btConectImage.Size = new System.Drawing.Size(273, 33);
            this.btConectImage.TabIndex = 46;
            this.btConectImage.Text = "Conectar Imagem";
            this.btConectImage.UseVisualStyleBackColor = false;
            this.btConectImage.Click += new System.EventHandler(this.btConectImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(599, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 237);
            this.panel2.TabIndex = 49;
            // 
            // MachineAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btConectImage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDimensoes);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtPreco);
            this.Name = "MachineAdd";
            this.Text = "MachineAdd";
            this.Load += new System.EventHandler(this.MachineAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtDimensoes;
        private System.Windows.Forms.ComboBox txtMarca;
        private System.Windows.Forms.ComboBox txtModelo;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btConectImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel2;
    }
}