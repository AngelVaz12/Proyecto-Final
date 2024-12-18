namespace proyectof
{
    partial class trans
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBoxCaptura = new PictureBox();
            lblNom = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 28);
            label1.Name = "label1";
            label1.Size = new Size(273, 28);
            label1.TabIndex = 0;
            label1.Text = "Pago por tranferencia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 67);
            label2.Name = "label2";
            label2.Size = new Size(355, 25);
            label2.TabIndex = 1;
            label2.Text = "Numero de tarjeta: 5579 0345 4633 8423";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(260, 104);
            label3.Name = "label3";
            label3.Size = new Size(317, 25);
            label3.TabIndex = 2;
            label3.Text = "Cuente Clabe: 014012452974023638";
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Bodoni MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(38, 397);
            button1.Name = "button1";
            button1.Size = new Size(129, 29);
            button1.TabIndex = 3;
            button1.Text = "Regresa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Font = new Font("Bodoni MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(304, 145);
            button2.Name = "button2";
            button2.Size = new Size(223, 25);
            button2.TabIndex = 4;
            button2.Text = "Subir Comprobante de pago.";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.Font = new Font("Bodoni MT", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(620, 397);
            button3.Name = "button3";
            button3.Size = new Size(147, 29);
            button3.TabIndex = 5;
            button3.Text = "Seguir comprando";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBoxCaptura
            // 
            pictureBoxCaptura.Location = new Point(326, 185);
            pictureBoxCaptura.Name = "pictureBoxCaptura";
            pictureBoxCaptura.Size = new Size(179, 253);
            pictureBoxCaptura.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCaptura.TabIndex = 6;
            pictureBoxCaptura.TabStop = false;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(304, 3);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(39, 25);
            lblNom.TabIndex = 19;
            lblNom.Text = "---";
            // 
            // trans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNom);
            Controls.Add(pictureBoxCaptura);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "trans";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBoxCaptura;
        private Label lblNom;
    }
}