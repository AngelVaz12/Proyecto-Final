namespace proyectof
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            buttonSalirAdmin = new Button();
            buttonConsularVentas = new Button();
            buttonModProductos = new Button();
            buttonMosGrafica = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbFecha = new Label();
            lbHora = new Label();
            lblNom = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // buttonSalirAdmin
            // 
            buttonSalirAdmin.BackColor = Color.DarkOrange;
            buttonSalirAdmin.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSalirAdmin.ForeColor = SystemColors.ActiveCaptionText;
            buttonSalirAdmin.Location = new Point(575, 505);
            buttonSalirAdmin.Name = "buttonSalirAdmin";
            buttonSalirAdmin.Size = new Size(117, 72);
            buttonSalirAdmin.TabIndex = 7;
            buttonSalirAdmin.Text = "Regresar a Usuario";
            buttonSalirAdmin.UseVisualStyleBackColor = false;
            buttonSalirAdmin.Click += buttonSalirAdmin_Click;
            // 
            // buttonConsularVentas
            // 
            buttonConsularVentas.BackColor = Color.DarkOrange;
            buttonConsularVentas.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonConsularVentas.ForeColor = SystemColors.ActiveCaptionText;
            buttonConsularVentas.Location = new Point(906, 225);
            buttonConsularVentas.Name = "buttonConsularVentas";
            buttonConsularVentas.Size = new Size(117, 63);
            buttonConsularVentas.TabIndex = 6;
            buttonConsularVentas.Text = "Consultar Ventas";
            buttonConsularVentas.UseVisualStyleBackColor = false;
            buttonConsularVentas.Click += buttonConsularVentas_Click;
            // 
            // buttonModProductos
            // 
            buttonModProductos.BackColor = Color.DarkOrange;
            buttonModProductos.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonModProductos.ForeColor = SystemColors.ActiveCaptionText;
            buttonModProductos.Location = new Point(411, 225);
            buttonModProductos.Name = "buttonModProductos";
            buttonModProductos.Size = new Size(120, 63);
            buttonModProductos.TabIndex = 5;
            buttonModProductos.Text = "Modificar Productos";
            buttonModProductos.UseVisualStyleBackColor = false;
            buttonModProductos.Click += buttonModProductos_Click;
            // 
            // buttonMosGrafica
            // 
            buttonMosGrafica.BackColor = Color.DarkOrange;
            buttonMosGrafica.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonMosGrafica.ForeColor = SystemColors.ActiveCaptionText;
            buttonMosGrafica.Location = new Point(657, 225);
            buttonMosGrafica.Name = "buttonMosGrafica";
            buttonMosGrafica.Size = new Size(120, 63);
            buttonMosGrafica.TabIndex = 8;
            buttonMosGrafica.Text = "Mostrar Grafica";
            buttonMosGrafica.UseVisualStyleBackColor = false;
            buttonMosGrafica.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(394, 324);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(640, 324);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 132);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(887, 324);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(154, 132);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
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
            lbFecha.Location = new Point(27, 20);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(72, 18);
            lbFecha.TabIndex = 13;
            lbFecha.Text = "00/00/0000";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(124, 20);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(60, 18);
            lbHora.TabIndex = 12;
            lbHora.Text = "00:00:00";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Baskerville Old Face", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(575, 128);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(298, 40);
            lblNom.TabIndex = 18;
            lblNom.Text = "~ Administrador ~";
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1340, 630);
            Controls.Add(lblNom);
            Controls.Add(lbFecha);
            Controls.Add(lbHora);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonMosGrafica);
            Controls.Add(buttonSalirAdmin);
            Controls.Add(buttonConsularVentas);
            Controls.Add(buttonModProductos);
            Name = "frmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            WindowState = FormWindowState.Maximized;
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalirAdmin;
        private Button buttonConsularVentas;
        private Button buttonModProductos;
        private Button buttonMosGrafica;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private Label lbFecha;
        private Label lbHora;
        private Label lblNom;
    }
}