namespace proyectof
{
    partial class efectivo
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
            label1 = new Label();
            label2 = new Label();
            labelCantidad = new Label();
            label4 = new Label();
            textBoxPago = new TextBox();
            buttonPagar = new Button();
            button2 = new Button();
            buttonOtraCompra = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbHora = new Label();
            lbFecha = new Label();
            lblNom = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 26F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 60);
            label1.Name = "label1";
            label1.Size = new Size(251, 40);
            label1.TabIndex = 0;
            label1.Text = "Pago en efectivo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 156);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 1;
            label2.Text = "Vas a pagar:";
            // 
            // labelCantidad
            // 
            labelCantidad.AutoSize = true;
            labelCantidad.Font = new Font("Bodoni MT", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelCantidad.Location = new Point(423, 156);
            labelCantidad.Name = "labelCantidad";
            labelCantidad.Size = new Size(40, 26);
            labelCantidad.TabIndex = 2;
            labelCantidad.Text = "----";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(116, 209);
            label4.Name = "label4";
            label4.Size = new Size(280, 25);
            label4.TabIndex = 3;
            label4.Text = "Ingresa con cuanto vas a pagar:";
            label4.Click += label4_Click;
            // 
            // textBoxPago
            // 
            textBoxPago.BorderStyle = BorderStyle.FixedSingle;
            textBoxPago.Location = new Point(423, 214);
            textBoxPago.Name = "textBoxPago";
            textBoxPago.Size = new Size(136, 23);
            textBoxPago.TabIndex = 4;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.SandyBrown;
            buttonPagar.Location = new Point(332, 265);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(79, 31);
            buttonPagar.TabIndex = 5;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            buttonPagar.Click += buttonPagar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Font = new Font("Bodoni MT", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(43, 382);
            button2.Name = "button2";
            button2.Size = new Size(104, 36);
            button2.TabIndex = 6;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // buttonOtraCompra
            // 
            buttonOtraCompra.BackColor = Color.SandyBrown;
            buttonOtraCompra.Font = new Font("Bodoni MT", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonOtraCompra.Location = new Point(676, 382);
            buttonOtraCompra.Name = "buttonOtraCompra";
            buttonOtraCompra.Size = new Size(137, 36);
            buttonOtraCompra.TabIndex = 7;
            buttonOtraCompra.Text = "Otra venta";
            buttonOtraCompra.UseVisualStyleBackColor = false;
            buttonOtraCompra.Click += buttonOtraCompra_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(585, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 305);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(116, 9);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(60, 18);
            lbHora.TabIndex = 9;
            lbHora.Text = "00:00:00";
            lbHora.Click += lbHora_Click;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbFecha.ForeColor = SystemColors.ControlText;
            lbFecha.Location = new Point(19, 9);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(72, 18);
            lbFecha.TabIndex = 10;
            lbFecha.Text = "00/00/0000";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(255, 9);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(39, 25);
            lblNom.TabIndex = 20;
            lblNom.Text = "---";
            // 
            // efectivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(858, 458);
            Controls.Add(lblNom);
            Controls.Add(lbFecha);
            Controls.Add(lbHora);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOtraCompra);
            Controls.Add(button2);
            Controls.Add(buttonPagar);
            Controls.Add(textBoxPago);
            Controls.Add(label4);
            Controls.Add(labelCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "efectivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += efectivo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelCantidad;
        private Label label4;
        private TextBox textBoxPago;
        private Button buttonPagar;
        private Button button2;
        private Button buttonOtraCompra;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lbHora;
        private Label lbFecha;
        private Label lblNom;
    }
}