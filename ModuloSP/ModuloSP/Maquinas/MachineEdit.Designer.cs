
namespace ModuloSP.Maquinas
{
    partial class MachineEdit
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
            this.txtID = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btConectImage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDimensoes = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.Location = new System.Drawing.Point(12, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(22, 16);
            this.txtID.TabIndex = 40;
            this.txtID.Text = "ID";
            this.txtID.Visible = false;
            // 
            // lblModelo
            // 
            this.lblModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Bahnschrift", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.Location = new System.Drawing.Point(595, 54);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(62, 19);
            this.lblModelo.TabIndex = 51;
            this.lblModelo.Text = "Modelo";
            this.lblModelo.Click += new System.EventHandler(this.lblModelo_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Bahnschrift", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(270, 54);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(54, 19);
            this.lblMarca.TabIndex = 50;
            this.lblMarca.Text = "Marca";
            this.lblMarca.Click += new System.EventHandler(this.lblMarca_Click);
            // 
            // btEditar
            // 
            this.btEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditar.BackColor = System.Drawing.Color.Black;
            this.btEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(274, 598);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(250, 33);
            this.btEditar.TabIndex = 49;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMarca.Location = new System.Drawing.Point(274, 97);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(250, 26);
            this.txtMarca.TabIndex = 55;
            // 
            // txtModelo
            // 
            this.txtModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModelo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtModelo.Location = new System.Drawing.Point(599, 97);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.ReadOnly = true;
            this.txtModelo.Size = new System.Drawing.Size(273, 26);
            this.txtModelo.TabIndex = 56;
            // 
            // btConectImage
            // 
            this.btConectImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConectImage.BackColor = System.Drawing.Color.Black;
            this.btConectImage.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btConectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConectImage.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConectImage.ForeColor = System.Drawing.Color.White;
            this.btConectImage.Location = new System.Drawing.Point(599, 598);
            this.btConectImage.Name = "btConectImage";
            this.btConectImage.Size = new System.Drawing.Size(273, 33);
            this.btConectImage.TabIndex = 58;
            this.btConectImage.Text = "Conectar Imagem";
            this.btConectImage.UseVisualStyleBackColor = false;
            this.btConectImage.Click += new System.EventHandler(this.btConectImage_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(599, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 237);
            this.panel2.TabIndex = 66;
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
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(595, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Imagem";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Cor";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Dimensões";
            // 
            // txtDimensoes
            // 
            this.txtDimensoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDimensoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensoes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDimensoes.Location = new System.Drawing.Point(274, 202);
            this.txtDimensoes.Name = "txtDimensoes";
            this.txtDimensoes.Size = new System.Drawing.Size(250, 26);
            this.txtDimensoes.TabIndex = 61;
            this.txtDimensoes.Text = "Dimensões";
            // 
            // txtCor
            // 
            this.txtCor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtCor.Location = new System.Drawing.Point(274, 304);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(250, 26);
            this.txtCor.TabIndex = 60;
            this.txtCor.Text = "Cor";
            this.txtCor.Click += new System.EventHandler(this.txtCor_Click);
            this.txtCor.TextChanged += new System.EventHandler(this.txtCor_TextChanged);
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPreco.Location = new System.Drawing.Point(274, 402);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(250, 26);
            this.txtPreco.TabIndex = 59;
            this.txtPreco.Text = "Preço";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescricao.Location = new System.Drawing.Point(274, 496);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(598, 73);
            this.txtDescricao.TabIndex = 67;
            this.txtDescricao.Text = "Descrição";
            // 
            // MachineEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDimensoes);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.btConectImage);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.txtID);
            this.Name = "MachineEdit";
            this.Text = "MachineEdit";
            this.Load += new System.EventHandler(this.MachineEdit_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Button btConectImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDimensoes;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
    }
}