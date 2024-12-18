namespace proyectof
{
    partial class opcVenta
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
            efeBoton = new Button();
            tarBoton = new Button();
            transBoton = new Button();
            button4 = new Button();
            lblNom = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 43);
            label1.Name = "label1";
            label1.Size = new Size(423, 36);
            label1.TabIndex = 0;
            label1.Text = "~ Seleccione metodo de pago ~";
            label1.Click += label1_Click;
            // 
            // efeBoton
            // 
            efeBoton.BackColor = Color.SandyBrown;
            efeBoton.Font = new Font("Bodoni MT", 14F, FontStyle.Italic);
            efeBoton.Location = new Point(340, 121);
            efeBoton.Name = "efeBoton";
            efeBoton.Size = new Size(179, 46);
            efeBoton.TabIndex = 1;
            efeBoton.Text = "Efectivo";
            efeBoton.UseVisualStyleBackColor = false;
            efeBoton.Click += efeBoton_Click_1;
            // 
            // tarBoton
            // 
            tarBoton.BackColor = Color.SandyBrown;
            tarBoton.Font = new Font("Bodoni MT", 14F, FontStyle.Italic);
            tarBoton.Location = new Point(340, 187);
            tarBoton.Name = "tarBoton";
            tarBoton.Size = new Size(179, 46);
            tarBoton.TabIndex = 2;
            tarBoton.Text = "Tarjeta credito/debito";
            tarBoton.UseVisualStyleBackColor = false;
            tarBoton.Click += tarBoton_Click_1;
            // 
            // transBoton
            // 
            transBoton.BackColor = Color.SandyBrown;
            transBoton.Font = new Font("Bodoni MT", 14F, FontStyle.Italic);
            transBoton.Location = new Point(340, 250);
            transBoton.Name = "transBoton";
            transBoton.Size = new Size(179, 46);
            transBoton.TabIndex = 3;
            transBoton.Text = "Transferencia bancaria";
            transBoton.UseVisualStyleBackColor = false;
            transBoton.Click += transBoton_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.SandyBrown;
            button4.Font = new Font("Bodoni MT", 14F, FontStyle.Italic);
            button4.Location = new Point(645, 363);
            button4.Name = "button4";
            button4.Size = new Size(125, 29);
            button4.TabIndex = 4;
            button4.Text = "Regresar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Bodoni MT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(331, 9);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(39, 25);
            lblNom.TabIndex = 20;
            lblNom.Text = "---";
            // 
            // opcVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(858, 458);
            Controls.Add(lblNom);
            Controls.Add(button4);
            Controls.Add(transBoton);
            Controls.Add(tarBoton);
            Controls.Add(efeBoton);
            Controls.Add(label1);
            Name = "opcVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "opcVenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button efeBoton;
        private Button tarBoton;
        private Button transBoton;
        private Button button4;
        private Label lblNom;
    }
}