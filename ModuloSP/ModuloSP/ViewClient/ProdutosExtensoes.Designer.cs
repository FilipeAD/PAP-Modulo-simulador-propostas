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
            this.txtModelo = new System.Windows.Forms.Label();
            this.txtDimensoes = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.AutoSize = true;
            this.txtModelo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(340, 64);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(62, 19);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.Text = "Modelo";
            // 
            // txtDimensoes
            // 
            this.txtDimensoes.AutoSize = true;
            this.txtDimensoes.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDimensoes.Location = new System.Drawing.Point(211, 130);
            this.txtDimensoes.Name = "txtDimensoes";
            this.txtDimensoes.Size = new System.Drawing.Size(90, 19);
            this.txtDimensoes.TabIndex = 1;
            this.txtDimensoes.Text = "Dimensões";
            // 
            // txtPreco
            // 
            this.txtPreco.AutoSize = true;
            this.txtPreco.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(211, 192);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(52, 19);
            this.txtPreco.TabIndex = 2;
            this.txtPreco.Text = "Preço";
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(211, 64);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(54, 19);
            this.txtMarca.TabIndex = 3;
            this.txtMarca.Text = "Marca";
            // 
            // ProdutosExtensoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtDimensoes);
            this.Controls.Add(this.txtModelo);
            this.Name = "ProdutosExtensoes";
            this.Text = "ProdutosExtensoes";
            this.Load += new System.EventHandler(this.ProdutosExtensoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtModelo;
        private System.Windows.Forms.Label txtDimensoes;
        private System.Windows.Forms.Label txtPreco;
        private System.Windows.Forms.Label txtMarca;
    }
}