namespace proyectof
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tBUsuario = new TextBox();
            tBPassword = new TextBox();
            labelUsuario = new Label();
            labelPassword = new Label();
            buttonIngresa = new Button();
            buttonSalir = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tBUsuario
            // 
            tBUsuario.Anchor = AnchorStyles.Top;
            tBUsuario.Location = new Point(235, 693);
            tBUsuario.Margin = new Padding(4, 5, 4, 5);
            tBUsuario.Name = "tBUsuario";
            tBUsuario.Size = new Size(337, 31);
            tBUsuario.TabIndex = 0;
            // 
            // tBPassword
            // 
            tBPassword.Anchor = AnchorStyles.Top;
            tBPassword.Location = new Point(235, 812);
            tBPassword.Margin = new Padding(4, 5, 4, 5);
            tBPassword.Name = "tBPassword";
            tBPassword.Size = new Size(337, 31);
            tBPassword.TabIndex = 1;
            tBPassword.UseSystemPasswordChar = true;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.Top;
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Bodoni MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.Location = new Point(333, 628);
            labelUsuario.Margin = new Padding(4, 0, 4, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(140, 42);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario";
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Top;
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Bodoni MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(308, 747);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(190, 42);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Contraseña";
            // 
            // buttonIngresa
            // 
            buttonIngresa.Anchor = AnchorStyles.Top;
            buttonIngresa.BackColor = Color.BurlyWood;
            buttonIngresa.Font = new Font("Bodoni MT", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonIngresa.Location = new Point(320, 866);
            buttonIngresa.Margin = new Padding(4, 5, 4, 5);
            buttonIngresa.Name = "buttonIngresa";
            buttonIngresa.Size = new Size(167, 45);
            buttonIngresa.TabIndex = 4;
            buttonIngresa.Text = "Ingresar";
            buttonIngresa.UseVisualStyleBackColor = false;
            buttonIngresa.Click += buttonIngresa_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSalir.BackColor = Color.BurlyWood;
            buttonSalir.Font = new Font("Bodoni MT", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(1265, 311);
            buttonSalir.Margin = new Padding(4, 5, 4, 5);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(217, 58);
            buttonSalir.TabIndex = 14;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(202, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(298, 463);
            label1.Name = "label1";
            label1.Size = new Size(209, 41);
            label1.TabIndex = 16;
            label1.Text = "¡Ingresa aqui!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Baskerville Old Face", 28F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(768, 136);
            label2.Name = "label2";
            label2.Size = new Size(968, 64);
            label2.TabIndex = 17;
            label2.Text = "\"Calidad y tradición al alcance de tu mano\"";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1044);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonIngresa);
            Controls.Add(labelPassword);
            Controls.Add(labelUsuario);
            Controls.Add(tBPassword);
            Controls.Add(tBUsuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tBPassword;
        private Label labelUsuario;
        private Label labelPassword;
        private Button buttonIngresa;
        private Button buttonSalir;
        public TextBox tBUsuario;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
