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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbActions = new System.Windows.Forms.ComboBox();
            this.cmbUtilizador = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DateBiggerThan = new System.Windows.Forms.MonthCalendar();
            this.DateSmallerThan = new System.Windows.Forms.MonthCalendar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 300);
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
            this.cmbActions.Enter += new System.EventHandler(this.cmbActions_Enter);
            this.cmbActions.Leave += new System.EventHandler(this.cmbActions_Leave);
            // 
            // cmbUtilizador
            // 
            this.cmbUtilizador.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUtilizador.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbUtilizador.FormattingEnabled = true;
            this.cmbUtilizador.Location = new System.Drawing.Point(306, 54);
            this.cmbUtilizador.Name = "cmbUtilizador";
            this.cmbUtilizador.Size = new System.Drawing.Size(227, 24);
            this.cmbUtilizador.TabIndex = 31;
            this.cmbUtilizador.Text = "Utilizador";
            this.cmbUtilizador.SelectedIndexChanged += new System.EventHandler(this.cmbUtilizador_SelectedIndexChanged_1);
            this.cmbUtilizador.Enter += new System.EventHandler(this.cmbUtilizador_Enter);
            this.cmbUtilizador.Leave += new System.EventHandler(this.cmbUtilizador_Leave);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(593, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "month";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(521, 274);
            this.chart1.TabIndex = 37;
            this.chart1.Text = "chart1";
            // 
            // DateBiggerThan
            // 
            this.DateBiggerThan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DateBiggerThan.Enabled = false;
            this.DateBiggerThan.Location = new System.Drawing.Point(24, 112);
            this.DateBiggerThan.MaxSelectionCount = 1;
            this.DateBiggerThan.Name = "DateBiggerThan";
            this.DateBiggerThan.TabIndex = 38;
            this.DateBiggerThan.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateBiggerThan_DateSelected);
            // 
            // DateSmallerThan
            // 
            this.DateSmallerThan.BackColor = System.Drawing.SystemColors.MenuBar;
            this.DateSmallerThan.Enabled = false;
            this.DateSmallerThan.Location = new System.Drawing.Point(306, 112);
            this.DateSmallerThan.MaxSelectionCount = 1;
            this.DateSmallerThan.Name = "DateSmallerThan";
            this.DateSmallerThan.TabIndex = 43;
            this.DateSmallerThan.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSmallerThan_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Data Final";
            // 
            // ActivityTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1146, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateSmallerThan);
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
        private System.Windows.Forms.MonthCalendar DateSmallerThan;
        private System.Windows.Forms.MonthCalendar DateBiggerThan;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}