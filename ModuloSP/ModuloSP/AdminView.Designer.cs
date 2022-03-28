
namespace ModuloSP
{
    partial class AdminView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClients = new System.Windows.Forms.Button();
            this.btAddOn = new System.Windows.Forms.Button();
            this.btMaquinas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btClients);
            this.panel1.Controls.Add(this.btAddOn);
            this.panel1.Controls.Add(this.btMaquinas);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 720);
            this.panel1.TabIndex = 1;
            // 
            // btClients
            // 
            this.btClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClients.FlatAppearance.BorderSize = 0;
            this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClients.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btClients.Location = new System.Drawing.Point(0, 239);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(220, 63);
            this.btClients.TabIndex = 19;
            this.btClients.Text = "CLIENTES";
            this.btClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btClients.UseVisualStyleBackColor = true;
            this.btClients.Click += new System.EventHandler(this.btClients_Click);
            // 
            // btAddOn
            // 
            this.btAddOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btAddOn.FlatAppearance.BorderSize = 0;
            this.btAddOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddOn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddOn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btAddOn.Location = new System.Drawing.Point(0, 176);
            this.btAddOn.Name = "btAddOn";
            this.btAddOn.Size = new System.Drawing.Size(220, 63);
            this.btAddOn.TabIndex = 18;
            this.btAddOn.Text = "ADD ONS";
            this.btAddOn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddOn.UseVisualStyleBackColor = true;
            this.btAddOn.Click += new System.EventHandler(this.btAddOn_Click);
            // 
            // btMaquinas
            // 
            this.btMaquinas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMaquinas.FlatAppearance.BorderSize = 0;
            this.btMaquinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaquinas.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMaquinas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btMaquinas.Location = new System.Drawing.Point(0, 113);
            this.btMaquinas.Name = "btMaquinas";
            this.btMaquinas.Size = new System.Drawing.Size(220, 63);
            this.btMaquinas.TabIndex = 17;
            this.btMaquinas.Text = "MAQUINAS";
            this.btMaquinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btMaquinas.UseVisualStyleBackColor = true;
            this.btMaquinas.Click += new System.EventHandler(this.btMaquinas_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 658);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 62);
            this.panel3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "LogOut";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(67, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 23);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 113);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 113);
            this.panel4.TabIndex = 14;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesktopPanel.Location = new System.Drawing.Point(220, 113);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(901, 607);
            this.DesktopPanel.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ModuloSP.Properties.Resources.closeicon;
            this.pictureBox4.Location = new System.Drawing.Point(874, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ModuloSP.Properties.Resources.loginicon2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 720);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel DesktopPanel;
        private System.Windows.Forms.Button btClients;
        private System.Windows.Forms.Button btAddOn;
        private System.Windows.Forms.Button btMaquinas;
    }
}