namespace ModuloSP.ViewAdmin
{
    partial class ActivityTracker
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
            this.cmbActions = new System.Windows.Forms.ComboBox();
            this.cmbUtilizador = new System.Windows.Forms.ComboBox();
            this.DateBiggerThan = new System.Windows.Forms.MonthCalendar();
            this.DateSmallerThan = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbActions
            // 
            this.cmbActions.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActions.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbActions.FormattingEnabled = true;
            this.cmbActions.Location = new System.Drawing.Point(34, 47);
            this.cmbActions.Name = "cmbActions";
            this.cmbActions.Size = new System.Drawing.Size(227, 24);
            this.cmbActions.TabIndex = 30;
            this.cmbActions.Text = "Ação";
            this.cmbActions.Visible = false;
            this.cmbActions.SelectedIndexChanged += new System.EventHandler(this.cmbActions_SelectedIndexChanged_1);
            this.cmbActions.Enter += new System.EventHandler(this.cmbActions_Enter);
            this.cmbActions.Leave += new System.EventHandler(this.cmbActions_Leave);
            // 
            // cmbUtilizador
            // 
            this.cmbUtilizador.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUtilizador.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbUtilizador.FormattingEnabled = true;
            this.cmbUtilizador.Location = new System.Drawing.Point(286, 47);
            this.cmbUtilizador.Name = "cmbUtilizador";
            this.cmbUtilizador.Size = new System.Drawing.Size(227, 24);
            this.cmbUtilizador.TabIndex = 31;
            this.cmbUtilizador.Text = "Utilizador";
            this.cmbUtilizador.Visible = false;
            this.cmbUtilizador.SelectedIndexChanged += new System.EventHandler(this.cmbUtilizador_SelectedIndexChanged_1);
            this.cmbUtilizador.Enter += new System.EventHandler(this.cmbUtilizador_Enter);
            this.cmbUtilizador.Leave += new System.EventHandler(this.cmbUtilizador_Leave);
            // 
            // DateBiggerThan
            // 
            this.DateBiggerThan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DateBiggerThan.Enabled = false;
            this.DateBiggerThan.Location = new System.Drawing.Point(34, 140);
            this.DateBiggerThan.MaxSelectionCount = 1;
            this.DateBiggerThan.Name = "DateBiggerThan";
            this.DateBiggerThan.TabIndex = 38;
            this.DateBiggerThan.Visible = false;
            this.DateBiggerThan.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateBiggerThan_DateSelected);
            // 
            // DateSmallerThan
            // 
            this.DateSmallerThan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DateSmallerThan.Enabled = false;
            this.DateSmallerThan.Location = new System.Drawing.Point(34, 336);
            this.DateSmallerThan.MaxSelectionCount = 1;
            this.DateSmallerThan.Name = "DateSmallerThan";
            this.DateSmallerThan.TabIndex = 43;
            this.DateSmallerThan.Visible = false;
            this.DateSmallerThan.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSmallerThan_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Data Inicial";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data Final";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Ação";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Utilizador";
            this.label4.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(543, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 684);
            this.panel1.TabIndex = 46;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(603, 684);
            this.dataGridView1.TabIndex = 26;
            // 
            // ActivityTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateSmallerThan);
            this.Controls.Add(this.cmbUtilizador);
            this.Controls.Add(this.DateBiggerThan);
            this.Controls.Add(this.cmbActions);
            this.Name = "ActivityTracker";
            this.Text = "ActivityTracker";
            this.Load += new System.EventHandler(this.ActivityTracker_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbActions;
        private System.Windows.Forms.ComboBox cmbUtilizador;
        private System.Windows.Forms.MonthCalendar DateSmallerThan;
        private System.Windows.Forms.MonthCalendar DateBiggerThan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}