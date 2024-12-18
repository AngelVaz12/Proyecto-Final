
namespace proyectof
{
    partial class frmConsVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsVentas));
            dataGridView1 = new DataGridView();
            buttonSalir = new Button();
            lblTotal = new Label();
            fileSystemWatcher1 = new FileSystemWatcher();
            textBox1 = new TextBox();
            buttonActualizar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbFecha = new Label();
            lbHora = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.SeaShell;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(461, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(669, 482);
            dataGridView1.TabIndex = 0;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.SandyBrown;
            buttonSalir.Font = new Font("Bodoni MT", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSalir.Location = new Point(213, 503);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(188, 40);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Regresar a Menu ";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Baskerville Old Face", 22F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(258, 142);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 102);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total \r\nde \r\nVentas";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(225, 265);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.SandyBrown;
            buttonActualizar.Font = new Font("Bodoni MT", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonActualizar.Location = new Point(246, 316);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(110, 32);
            buttonActualizar.TabIndex = 4;
            buttonActualizar.Text = "Mostrar ";
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
            lbFecha.Location = new Point(21, 19);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(72, 18);
            lbFecha.TabIndex = 12;
            lbFecha.Text = "00/00/0000";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(118, 19);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(60, 18);
            lbHora.TabIndex = 11;
            lbHora.Text = "00:00:00";
            // 
            // frmConsVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1329, 626);
            Controls.Add(lbFecha);
            Controls.Add(lbHora);
            Controls.Add(buttonActualizar);
            Controls.Add(textBox1);
            Controls.Add(lblTotal);
            Controls.Add(buttonSalir);
            Controls.Add(dataGridView1);
            Name = "frmConsVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConsVentas";
            WindowState = FormWindowState.Maximized;
            Load += frmConsVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private DataGridView dataGridView1;
        private Button buttonSalir;
        private Label lblTotal;
        private FileSystemWatcher fileSystemWatcher1;
        private TextBox textBox1;
        private Button buttonActualizar;
        private System.Windows.Forms.Timer timer1;
        private Label lbFecha;
        private Label lbHora;
        private System.Windows.Forms.Timer timer2;
    }
}