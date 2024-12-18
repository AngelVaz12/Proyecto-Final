namespace proyectof
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            Pagar = new Button();
            buttonSalir = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbFecha = new Label();
            lbHora = new Label();
            lblNom = new Label();
            SuspendLayout();
            // 
            // Pagar
            // 
            Pagar.BackColor = Color.BurlyWood;
            Pagar.Font = new Font("Bodoni MT", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pagar.Location = new Point(981, 833);
            Pagar.Name = "Pagar";
            Pagar.Size = new Size(158, 34);
            Pagar.TabIndex = 11;
            Pagar.Text = "Pagar";
            Pagar.UseVisualStyleBackColor = false;
            Pagar.Click += Pagar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.BurlyWood;
            buttonSalir.Font = new Font("Bodoni MT", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(1163, 833);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(158, 34);
            buttonSalir.TabIndex = 12;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
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
            lbFecha.Location = new Point(24, 15);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(72, 18);
            lbFecha.TabIndex = 15;
            lbFecha.Text = "00/00/0000";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(121, 15);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(60, 18);
            lbHora.TabIndex = 14;
            lbHora.Text = "00:00:00";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(492, 8);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(39, 25);
            lblNom.TabIndex = 20;
            lblNom.Text = "---";
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1329, 876);
            Controls.Add(lblNom);
            Controls.Add(lbFecha);
            Controls.Add(lbHora);
            Controls.Add(buttonSalir);
            Controls.Add(Pagar);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "usuario";
            WindowState = FormWindowState.Maximized;
            Load += frmUsuario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Pagar;
        private Button buttonSalir;
        private System.Windows.Forms.Timer timer1;
        private Label lbFecha;
        private Label lbHora;
        private Label lblNom;
    }
}