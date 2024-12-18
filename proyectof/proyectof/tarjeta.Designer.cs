namespace proyectof
{
    partial class tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarjeta));
            label1 = new Label();
            textBoxNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxTarjeta = new TextBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textBoxMes = new TextBox();
            label5 = new Label();
            textBoxAno = new TextBox();
            label6 = new Label();
            textBoxCVV = new TextBox();
            pictureBox2 = new PictureBox();
            buttonPagar = new Button();
            buttonCancelar = new Button();
            buttonSigue = new Button();
            label7 = new Label();
            labelTotal = new Label();
            lblNom = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AntiqueWhite;
            label1.Font = new Font("Baskerville Old Face", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(421, 108);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 0;
            label1.Text = "Pago con tarjeta";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(191, 273);
            textBoxNombre.Margin = new Padding(4, 5, 4, 5);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(329, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 278);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre de titular:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 278);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 3;
            label3.Text = "Numero de tarjeta:";
            // 
            // textBoxTarjeta
            // 
            textBoxTarjeta.BorderStyle = BorderStyle.FixedSingle;
            textBoxTarjeta.Location = new Point(719, 273);
            textBoxTarjeta.Margin = new Padding(4, 5, 4, 5);
            textBoxTarjeta.Name = "textBoxTarjeta";
            textBoxTarjeta.Size = new Size(398, 23);
            textBoxTarjeta.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(272, 660);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(564, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 387);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 6;
            label4.Text = "Mes:";
            // 
            // textBoxMes
            // 
            textBoxMes.BorderStyle = BorderStyle.FixedSingle;
            textBoxMes.Location = new Point(246, 383);
            textBoxMes.Margin = new Padding(4, 5, 4, 5);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(51, 23);
            textBoxMes.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(323, 387);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 8;
            label5.Text = "Año:";
            // 
            // textBoxAno
            // 
            textBoxAno.BorderStyle = BorderStyle.FixedSingle;
            textBoxAno.Location = new Point(377, 383);
            textBoxAno.Margin = new Padding(4, 5, 4, 5);
            textBoxAno.Name = "textBoxAno";
            textBoxAno.Size = new Size(51, 23);
            textBoxAno.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(559, 387);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 10;
            label6.Text = "CVV:";
            // 
            // textBoxCVV
            // 
            textBoxCVV.BorderStyle = BorderStyle.FixedSingle;
            textBoxCVV.Location = new Point(613, 382);
            textBoxCVV.Margin = new Padding(4, 5, 4, 5);
            textBoxCVV.Name = "textBoxCVV";
            textBoxCVV.Size = new Size(108, 23);
            textBoxCVV.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(791, 347);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.SeaShell;
            buttonPagar.Location = new Point(997, 377);
            buttonPagar.Margin = new Padding(4, 5, 4, 5);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(120, 43);
            buttonPagar.TabIndex = 13;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click_1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.SeaShell;
            buttonCancelar.Location = new Point(17, 692);
            buttonCancelar.Margin = new Padding(4, 5, 4, 5);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(107, 38);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "Regresar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click_1;
            // 
            // buttonSigue
            // 
            buttonSigue.BackColor = Color.SeaShell;
            buttonSigue.Location = new Point(970, 692);
            buttonSigue.Margin = new Padding(4, 5, 4, 5);
            buttonSigue.Name = "buttonSigue";
            buttonSigue.Size = new Size(156, 38);
            buttonSigue.TabIndex = 15;
            buttonSigue.Text = "Seguir ventas.";
            buttonSigue.UseVisualStyleBackColor = false;
            buttonSigue.Click += buttonSigue_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(453, 497);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 16;
            label7.Text = "Total a pagar:";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(571, 497);
            labelTotal.Margin = new Padding(4, 0, 4, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(22, 15);
            labelTotal.TabIndex = 17;
            labelTotal.Text = "---";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(421, 9);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(39, 25);
            lblNom.TabIndex = 20;
            lblNom.Text = "---";
            // 
            // tarjeta
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1143, 750);
            Controls.Add(lblNom);
            Controls.Add(labelTotal);
            Controls.Add(label7);
            Controls.Add(buttonSigue);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonPagar);
            Controls.Add(pictureBox2);
            Controls.Add(textBoxCVV);
            Controls.Add(label6);
            Controls.Add(textBoxAno);
            Controls.Add(label5);
            Controls.Add(textBoxMes);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxTarjeta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxNombre);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "tarjeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tarjeta";
            Load += tarjeta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNombre;
        private Label label2;
        private Label label3;
        private TextBox textBoxTarjeta;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox textBoxMes;
        private Label label5;
        private TextBox textBoxAno;
        private Label label6;
        private TextBox textBoxCVV;
        private PictureBox pictureBox2;
        private Button buttonPagar;
        private Button buttonCancelar;
        private Button buttonSigue;
        private Label label7;
        private Label labelTotal;
        private Label lblNom;
    }
}