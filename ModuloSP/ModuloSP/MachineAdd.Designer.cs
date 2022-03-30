
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
            this.btAdd = new System.Windows.Forms.Button();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtDimensoes = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.ComboBox();
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
            // 
            // btAdd
            // 
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(683, 509);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 48);
            this.btAdd.TabIndex = 26;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(542, 383);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(171, 26);
            this.txtPreco.TabIndex = 25;
            this.txtPreco.Text = "Preço";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(533, 99);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(324, 26);
            this.txtCor.TabIndex = 34;
            this.txtCor.Text = "Cor";
            // 
            // txtDimensoes
            // 
            this.txtDimensoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensoes.Location = new System.Drawing.Point(533, 235);
            this.txtDimensoes.Name = "txtDimensoes";
            this.txtDimensoes.Size = new System.Drawing.Size(324, 26);
            this.txtDimensoes.TabIndex = 35;
            this.txtDimensoes.Text = "Dimensões";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.FormattingEnabled = true;
            this.txtMarca.ItemHeight = 20;
            this.txtMarca.Location = new System.Drawing.Point(25, 97);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(324, 28);
            this.txtMarca.TabIndex = 36;
            this.txtMarca.Text = "Marca";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.FormattingEnabled = true;
            this.txtModelo.ItemHeight = 20;
            this.txtModelo.Location = new System.Drawing.Point(25, 233);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(324, 28);
            this.txtModelo.TabIndex = 37;
            this.txtModelo.Text = "Modelo";
            // 
            // MachineAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 664);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDimensoes);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtPreco);
            this.Name = "MachineAdd";
            this.Text = "MachineAdd";
            this.Load += new System.EventHandler(this.MachineAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtDimensoes;
        private System.Windows.Forms.ComboBox txtMarca;
        private System.Windows.Forms.ComboBox txtModelo;
    }
}