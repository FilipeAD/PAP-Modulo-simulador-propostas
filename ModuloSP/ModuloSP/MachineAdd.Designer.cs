
namespace ModuloSP
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
            this.txtID = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtDimensoes = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.txtID.TabIndex = 27;
            this.txtID.Text = "ID";
            this.txtID.Visible = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPreco.Location = new System.Drawing.Point(274, 365);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(250, 26);
            this.txtPreco.TabIndex = 25;
            this.txtPreco.Text = "Preço";
            this.txtPreco.Enter += new System.EventHandler(this.txtPreco_Enter);
            this.txtPreco.Leave += new System.EventHandler(this.txtPreco_Leave);
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCor.Location = new System.Drawing.Point(274, 288);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(250, 26);
            this.txtCor.TabIndex = 34;
            this.txtCor.Text = "Cor";
            this.txtCor.Enter += new System.EventHandler(this.txtCor_Enter);
            this.txtCor.Leave += new System.EventHandler(this.txtCor_Leave);
            // 
            // txtDimensoes
            // 
            this.txtDimensoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensoes.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDimensoes.Location = new System.Drawing.Point(274, 210);
            this.txtDimensoes.Name = "txtDimensoes";
            this.txtDimensoes.Size = new System.Drawing.Size(250, 26);
            this.txtDimensoes.TabIndex = 35;
            this.txtDimensoes.Text = "Dimensões";
            this.txtDimensoes.Enter += new System.EventHandler(this.txtDimensoes_Enter);
            this.txtDimensoes.Leave += new System.EventHandler(this.txtDimensoes_Leave);
            // 
            // txtMarca
            // 
            this.txtMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.ForeColor = System.Drawing.SystemColors.ScrollBar;
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
            this.txtModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtModelo.FormattingEnabled = true;
            this.txtModelo.ItemHeight = 20;
            this.txtModelo.Location = new System.Drawing.Point(599, 95);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(250, 28);
            this.txtModelo.TabIndex = 37;
            this.txtModelo.Enter += new System.EventHandler(this.txtModelo_Enter);
            this.txtModelo.Leave += new System.EventHandler(this.txtModelo_Leave);
            // 
            // btAdd
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
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
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Cor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 43;
            this.label5.Text = "Preço";
            // 
            // MachineAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDimensoes);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPreco);
            this.Name = "MachineAdd";
            this.Text = "MachineAdd";
            this.Load += new System.EventHandler(this.MachineAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtDimensoes;
        private System.Windows.Forms.ComboBox txtMarca;
        private System.Windows.Forms.ComboBox txtModelo;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}