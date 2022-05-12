
namespace ModuloSP
{
    partial class GeneralView
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.mainaction = new System.Windows.Forms.ToolStripMenuItem();
            this.ListPermicoes = new System.Windows.Forms.ToolStripMenuItem();
            this.listUtilizadores = new System.Windows.Forms.ToolStripMenuItem();
            this.ListAddOns = new System.Windows.Forms.ToolStripMenuItem();
            this.lstAddOn = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.ListImpressoras = new System.Windows.Forms.ToolStripMenuItem();
            this.listMaquina = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMarcaModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.ListMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.InterfaceClient = new System.Windows.Forms.ToolStripMenuItem();
            this.Activity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Menu.SuspendLayout();
            this.userpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btMenu);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1241, 38);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(1133, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btMenu
            // 
            this.btMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMenu.FlatAppearance.BorderSize = 0;
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Image = global::ModuloSP.Properties.Resources.menuicon;
            this.btMenu.Location = new System.Drawing.Point(0, 0);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(61, 38);
            this.btMenu.TabIndex = 18;
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1178, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(63, 38);
            this.panel3.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ModuloSP.Properties.Resources.loginicon2;
            this.pictureBox2.Location = new System.Drawing.Point(24, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Silver;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainaction,
            this.Activity});
            this.Menu.Location = new System.Drawing.Point(0, 38);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1241, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            this.Menu.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.Menu_ItemAdded);
            // 
            // mainaction
            // 
            this.mainaction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListPermicoes,
            this.listUtilizadores,
            this.ListAddOns,
            this.ListImpressoras,
            this.InterfaceClient});
            this.mainaction.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainaction.ForeColor = System.Drawing.Color.White;
            this.mainaction.Name = "mainaction";
            this.mainaction.Size = new System.Drawing.Size(114, 20);
            this.mainaction.Text = "Ações Principais";
            // 
            // ListPermicoes
            // 
            this.ListPermicoes.BackColor = System.Drawing.Color.Silver;
            this.ListPermicoes.ForeColor = System.Drawing.Color.White;
            this.ListPermicoes.Name = "ListPermicoes";
            this.ListPermicoes.Size = new System.Drawing.Size(150, 22);
            this.ListPermicoes.Text = "Permições";
            this.ListPermicoes.Visible = false;
            this.ListPermicoes.Click += new System.EventHandler(this.ListPermicoes_Click);
            // 
            // listUtilizadores
            // 
            this.listUtilizadores.BackColor = System.Drawing.Color.Silver;
            this.listUtilizadores.ForeColor = System.Drawing.Color.White;
            this.listUtilizadores.Name = "listUtilizadores";
            this.listUtilizadores.Size = new System.Drawing.Size(150, 22);
            this.listUtilizadores.Text = "Utilizadores";
            this.listUtilizadores.Visible = false;
            this.listUtilizadores.Click += new System.EventHandler(this.listUtilizadores_Click);
            // 
            // ListAddOns
            // 
            this.ListAddOns.BackColor = System.Drawing.Color.Silver;
            this.ListAddOns.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lstAddOn,
            this.AddOnMarca});
            this.ListAddOns.ForeColor = System.Drawing.Color.White;
            this.ListAddOns.Name = "ListAddOns";
            this.ListAddOns.Size = new System.Drawing.Size(150, 22);
            this.ListAddOns.Text = "AddOns";
            this.ListAddOns.Visible = false;
            this.ListAddOns.Click += new System.EventHandler(this.ListAddOns_Click);
            // 
            // lstAddOn
            // 
            this.lstAddOn.BackColor = System.Drawing.Color.Silver;
            this.lstAddOn.ForeColor = System.Drawing.Color.White;
            this.lstAddOn.Name = "lstAddOn";
            this.lstAddOn.Size = new System.Drawing.Size(151, 22);
            this.lstAddOn.Text = "Listagem";
            this.lstAddOn.Click += new System.EventHandler(this.lisAddOn_Click);
            // 
            // AddOnMarca
            // 
            this.AddOnMarca.BackColor = System.Drawing.Color.Silver;
            this.AddOnMarca.ForeColor = System.Drawing.Color.White;
            this.AddOnMarca.Name = "AddOnMarca";
            this.AddOnMarca.Size = new System.Drawing.Size(151, 22);
            this.AddOnMarca.Text = "AddOn|Marca";
            this.AddOnMarca.Click += new System.EventHandler(this.AddOnMarca_Click);
            // 
            // ListImpressoras
            // 
            this.ListImpressoras.BackColor = System.Drawing.Color.Silver;
            this.ListImpressoras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listMaquina,
            this.ListMarcaModelo,
            this.ListMarca});
            this.ListImpressoras.ForeColor = System.Drawing.Color.White;
            this.ListImpressoras.Name = "ListImpressoras";
            this.ListImpressoras.Size = new System.Drawing.Size(150, 22);
            this.ListImpressoras.Text = "Impressoras";
            this.ListImpressoras.Visible = false;
            this.ListImpressoras.Click += new System.EventHandler(this.ListImpressoras_Click);
            // 
            // listMaquina
            // 
            this.listMaquina.BackColor = System.Drawing.Color.Silver;
            this.listMaquina.ForeColor = System.Drawing.Color.White;
            this.listMaquina.Name = "listMaquina";
            this.listMaquina.Size = new System.Drawing.Size(156, 22);
            this.listMaquina.Text = "Listagem ";
            this.listMaquina.Click += new System.EventHandler(this.listMaquina_Click);
            // 
            // ListMarcaModelo
            // 
            this.ListMarcaModelo.BackColor = System.Drawing.Color.Silver;
            this.ListMarcaModelo.ForeColor = System.Drawing.Color.White;
            this.ListMarcaModelo.Name = "ListMarcaModelo";
            this.ListMarcaModelo.Size = new System.Drawing.Size(156, 22);
            this.ListMarcaModelo.Text = "Marca|Modelo";
            this.ListMarcaModelo.Click += new System.EventHandler(this.ListMarcaModelo_Click);
            // 
            // ListMarca
            // 
            this.ListMarca.BackColor = System.Drawing.Color.Silver;
            this.ListMarca.ForeColor = System.Drawing.Color.White;
            this.ListMarca.Name = "ListMarca";
            this.ListMarca.Size = new System.Drawing.Size(156, 22);
            this.ListMarca.Text = "Marcas";
            this.ListMarca.Click += new System.EventHandler(this.ListMarca_Click);
            // 
            // InterfaceClient
            // 
            this.InterfaceClient.BackColor = System.Drawing.Color.Silver;
            this.InterfaceClient.ForeColor = System.Drawing.Color.White;
            this.InterfaceClient.Name = "InterfaceClient";
            this.InterfaceClient.Size = new System.Drawing.Size(150, 22);
            this.InterfaceClient.Text = "Produtos ";
            this.InterfaceClient.Visible = false;
            this.InterfaceClient.Click += new System.EventHandler(this.InterfaceClient_Click);
            // 
            // Activity
            // 
            this.Activity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.Activity.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activity.ForeColor = System.Drawing.Color.White;
            this.Activity.Name = "Activity";
            this.Activity.Size = new System.Drawing.Size(132, 20);
            this.Activity.Text = "Estado de Atividade";
            this.Activity.Visible = false;
            this.Activity.Click += new System.EventHandler(this.Activity_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 22);
            this.toolStripMenuItem2.Visible = false;
            // 
            // userpanel
            // 
            this.userpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.userpanel.Controls.Add(this.pictureBox1);
            this.userpanel.Controls.Add(this.label2);
            this.userpanel.Controls.Add(this.lblEmail);
            this.userpanel.Controls.Add(this.label3);
            this.userpanel.Controls.Add(this.lblUsername);
            this.userpanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userpanel.Location = new System.Drawing.Point(1018, 38);
            this.userpanel.MaximumSize = new System.Drawing.Size(223, 93);
            this.userpanel.Name = "userpanel";
            this.userpanel.Size = new System.Drawing.Size(223, 88);
            this.userpanel.TabIndex = 16;
            this.userpanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModuloSP.Properties.Resources.loginicon2;
            this.pictureBox1.Location = new System.Drawing.Point(17, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Forbrand";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(59, 58);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 16);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(164, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "LogOut";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(59, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 19);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1241, 804);
            this.Controls.Add(this.userpanel);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.panel4);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menu;
            this.Name = "GeneralView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.userpanel.ResumeLayout(false);
            this.userpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel userpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem mainaction;
        private System.Windows.Forms.ToolStripMenuItem listUtilizadores;
        private System.Windows.Forms.ToolStripMenuItem ListImpressoras;
        private System.Windows.Forms.ToolStripMenuItem ListAddOns;
        private System.Windows.Forms.ToolStripMenuItem ListMarcaModelo;
        private System.Windows.Forms.ToolStripMenuItem ListMarca;
        private System.Windows.Forms.ToolStripMenuItem ListPermicoes;
        private System.Windows.Forms.ToolStripMenuItem Activity;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem InterfaceClient;
        private System.Windows.Forms.ToolStripMenuItem listMaquina;
        private System.Windows.Forms.ToolStripMenuItem lstAddOn;
        private System.Windows.Forms.ToolStripMenuItem AddOnMarca;
    }
}