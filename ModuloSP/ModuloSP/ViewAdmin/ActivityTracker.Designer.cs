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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbActions = new System.Windows.Forms.ComboBox();
            this.cmbUtilizador = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DateBiggerThan = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateSmallerThan = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 286);
            this.dataGridView1.TabIndex = 26;
            // 
            // cmbActions
            // 
            this.cmbActions.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbActions.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbActions.FormattingEnabled = true;
            this.cmbActions.Location = new System.Drawing.Point(24, 54);
            this.cmbActions.Name = "cmbActions";
            this.cmbActions.Size = new System.Drawing.Size(227, 24);
            this.cmbActions.TabIndex = 30;
            this.cmbActions.Text = "Ação";
            this.cmbActions.SelectedIndexChanged += new System.EventHandler(this.cmbActions_SelectedIndexChanged_1);
            // 
            // cmbUtilizador
            // 
            this.cmbUtilizador.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUtilizador.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbUtilizador.FormattingEnabled = true;
            this.cmbUtilizador.Location = new System.Drawing.Point(324, 54);
            this.cmbUtilizador.Name = "cmbUtilizador";
            this.cmbUtilizador.Size = new System.Drawing.Size(227, 24);
            this.cmbUtilizador.TabIndex = 31;
            this.cmbUtilizador.Text = "Utilizador";
            this.cmbUtilizador.SelectedIndexChanged += new System.EventHandler(this.cmbUtilizador_SelectedIndexChanged_1);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(592, 42);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkGray;
            series1.Legend = "Legend1";
            series1.Name = "Year";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Year2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(521, 274);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // DateBiggerThan
            // 
            this.DateBiggerThan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DateBiggerThan.Location = new System.Drawing.Point(24, 144);
            this.DateBiggerThan.Name = "DateBiggerThan";
            this.DateBiggerThan.TabIndex = 38;
            this.DateBiggerThan.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateBiggerThan_DateSelected);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(21, 334);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 14);
            this.lblUser.TabIndex = 40;
            this.lblUser.Text = "Username";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(105, 334);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 14);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "|";
            // 
            // DateSmallerThan
            // 
            this.DateSmallerThan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DateSmallerThan.Location = new System.Drawing.Point(324, 144);
            this.DateSmallerThan.Name = "DateSmallerThan";
            this.DateSmallerThan.TabIndex = 43;
            this.DateSmallerThan.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DateSmallerThan_DateChanged);
            // 
            // ActivityTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.DateSmallerThan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbUtilizador);
            this.Controls.Add(this.DateBiggerThan);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cmbActions);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ActivityTracker";
            this.Text = "ActivityTracker";
            this.Load += new System.EventHandler(this.ActivityTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbActions;
        private System.Windows.Forms.ComboBox cmbUtilizador;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar DateSmallerThan;
        private System.Windows.Forms.MonthCalendar DateBiggerThan;
    }
}