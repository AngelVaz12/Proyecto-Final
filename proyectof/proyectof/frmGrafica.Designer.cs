namespace proyectof
{
    partial class frmGrafica
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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSalir = new Button();
            buttonActualizar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbFecha = new Label();
            lbHora = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = Color.PeachPuff;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 0);
            chart1.Name = "chart1";
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1898, 1044);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            chart1.Click += chart1_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.PeachPuff;
            buttonSalir.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(1314, 846);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(168, 54);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Regresar";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.PeachPuff;
            buttonActualizar.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonActualizar.Location = new Point(146, 846);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(255, 60);
            buttonActualizar.TabIndex = 2;
            buttonActualizar.Text = "Actualizar Grafica";
            buttonActualizar.UseVisualStyleBackColor = false;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFecha.ForeColor = SystemColors.ControlText;
            lbFecha.Location = new Point(70, 46);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(72, 18);
            lbFecha.TabIndex = 12;
            lbFecha.Text = "00/00/0000";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(167, 46);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(60, 18);
            lbHora.TabIndex = 11;
            lbHora.Text = "00:00:00";
            // 
            // frmGrafica
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1898, 1044);
            Controls.Add(lbFecha);
            Controls.Add(lbHora);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonSalir);
            Controls.Add(chart1);
            Name = "frmGrafica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGrafica";
            WindowState = FormWindowState.Maximized;
            Load += frmGrafica_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button buttonSalir;
        private Button buttonActualizar;
        private System.Windows.Forms.Timer timer1;
        private Label lbFecha;
        private Label lbHora;
    }
}