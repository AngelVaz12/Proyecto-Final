namespace proyectof
{
    partial class frmModProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModProd));
            buttonSalirAdmin = new Button();
            buttonMod = new Button();
            textBoxPrecioMod = new TextBox();
            textBoxImgMod = new TextBox();
            textBoxprodMod = new TextBox();
            textBoxModId = new TextBox();
            textBoxidMod = new TextBox();
            buttonInsertar = new Button();
            textBoxPrecio = new TextBox();
            textBoxImagen = new TextBox();
            textBoxproducto = new TextBox();
            textBoxId = new TextBox();
            textBoxEliminar = new TextBox();
            buttonEliminar = new Button();
            textBoxCantidadMod = new TextBox();
            textBoxCantidad = new TextBox();
            buttonver = new Button();
            dataGridView1 = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonMostrarCGrid = new Button();
            buttonActualizar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbFecha = new Label();
            lbHora = new Label();
            timer2 = new System.Windows.Forms.Timer(components);
            lblNom = new Label();
            botSubir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonSalirAdmin
            // 
            buttonSalirAdmin.BackColor = Color.SandyBrown;
            buttonSalirAdmin.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSalirAdmin.Location = new Point(1128, 532);
            buttonSalirAdmin.Name = "buttonSalirAdmin";
            buttonSalirAdmin.Size = new Size(129, 51);
            buttonSalirAdmin.TabIndex = 3;
            buttonSalirAdmin.Text = "Regresar Menu Admin";
            buttonSalirAdmin.UseVisualStyleBackColor = false;
            buttonSalirAdmin.Click += button4_Click;
            // 
            // buttonMod
            // 
            buttonMod.BackColor = Color.SandyBrown;
            buttonMod.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonMod.Location = new Point(1129, 397);
            buttonMod.Margin = new Padding(3, 2, 3, 2);
            buttonMod.Name = "buttonMod";
            buttonMod.Size = new Size(114, 27);
            buttonMod.TabIndex = 22;
            buttonMod.Text = "Modificar";
            buttonMod.UseVisualStyleBackColor = false;
            buttonMod.Click += buttonMod_Click;
            // 
            // textBoxPrecioMod
            // 
            textBoxPrecioMod.Location = new Point(1128, 296);
            textBoxPrecioMod.Margin = new Padding(3, 2, 3, 2);
            textBoxPrecioMod.Name = "textBoxPrecioMod";
            textBoxPrecioMod.Size = new Size(115, 23);
            textBoxPrecioMod.TabIndex = 17;
            // 
            // textBoxImgMod
            // 
            textBoxImgMod.Location = new Point(1128, 361);
            textBoxImgMod.Margin = new Padding(3, 2, 3, 2);
            textBoxImgMod.Name = "textBoxImgMod";
            textBoxImgMod.Size = new Size(115, 23);
            textBoxImgMod.TabIndex = 17;
            // 
            // textBoxprodMod
            // 
            textBoxprodMod.Location = new Point(1128, 264);
            textBoxprodMod.Margin = new Padding(3, 2, 3, 2);
            textBoxprodMod.Name = "textBoxprodMod";
            textBoxprodMod.Size = new Size(115, 23);
            textBoxprodMod.TabIndex = 17;
            // 
            // textBoxModId
            // 
            textBoxModId.Location = new Point(1128, 232);
            textBoxModId.Margin = new Padding(3, 2, 3, 2);
            textBoxModId.Name = "textBoxModId";
            textBoxModId.Size = new Size(115, 23);
            textBoxModId.TabIndex = 17;
            // 
            // textBoxidMod
            // 
            textBoxidMod.Location = new Point(1128, 199);
            textBoxidMod.Margin = new Padding(3, 2, 3, 2);
            textBoxidMod.Name = "textBoxidMod";
            textBoxidMod.PlaceholderText = "id a modificar";
            textBoxidMod.Size = new Size(115, 23);
            textBoxidMod.TabIndex = 17;
            // 
            // buttonInsertar
            // 
            buttonInsertar.BackColor = Color.SandyBrown;
            buttonInsertar.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonInsertar.Location = new Point(127, 397);
            buttonInsertar.Margin = new Padding(3, 2, 3, 2);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(114, 39);
            buttonInsertar.TabIndex = 27;
            buttonInsertar.Text = "Agregar";
            buttonInsertar.UseVisualStyleBackColor = false;
            buttonInsertar.Click += buttonInsertar_Click;
            // 
            // textBoxPrecio
            // 
            textBoxPrecio.Location = new Point(127, 298);
            textBoxPrecio.Margin = new Padding(3, 2, 3, 2);
            textBoxPrecio.Name = "textBoxPrecio";
            textBoxPrecio.PlaceholderText = "precio producto";
            textBoxPrecio.Size = new Size(115, 23);
            textBoxPrecio.TabIndex = 26;
            // 
            // textBoxImagen
            // 
            textBoxImagen.Location = new Point(127, 364);
            textBoxImagen.Margin = new Padding(3, 2, 3, 2);
            textBoxImagen.Name = "textBoxImagen";
            textBoxImagen.PlaceholderText = "nombre imagen";
            textBoxImagen.Size = new Size(115, 23);
            textBoxImagen.TabIndex = 25;
            // 
            // textBoxproducto
            // 
            textBoxproducto.Location = new Point(127, 265);
            textBoxproducto.Margin = new Padding(3, 2, 3, 2);
            textBoxproducto.Name = "textBoxproducto";
            textBoxproducto.PlaceholderText = "nombre producto";
            textBoxproducto.Size = new Size(115, 23);
            textBoxproducto.TabIndex = 24;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(127, 232);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.PlaceholderText = "id";
            textBoxId.Size = new Size(115, 23);
            textBoxId.TabIndex = 23;
            // 
            // textBoxEliminar
            // 
            textBoxEliminar.AllowDrop = true;
            textBoxEliminar.Font = new Font("Bodoni MT", 12F, FontStyle.Italic);
            textBoxEliminar.Location = new Point(127, 544);
            textBoxEliminar.Margin = new Padding(3, 2, 3, 2);
            textBoxEliminar.Name = "textBoxEliminar";
            textBoxEliminar.PlaceholderText = "id a eliminar";
            textBoxEliminar.Size = new Size(115, 27);
            textBoxEliminar.TabIndex = 29;
            textBoxEliminar.TextChanged += textBoxEliminar_TextChanged;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.SandyBrown;
            buttonEliminar.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonEliminar.Location = new Point(127, 576);
            buttonEliminar.Margin = new Padding(3, 2, 3, 2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(114, 29);
            buttonEliminar.TabIndex = 28;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // textBoxCantidadMod
            // 
            textBoxCantidadMod.Location = new Point(1128, 329);
            textBoxCantidadMod.Margin = new Padding(3, 2, 3, 2);
            textBoxCantidadMod.Name = "textBoxCantidadMod";
            textBoxCantidadMod.Size = new Size(115, 23);
            textBoxCantidadMod.TabIndex = 30;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(127, 331);
            textBoxCantidad.Margin = new Padding(3, 2, 3, 2);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.PlaceholderText = "cantidad producto";
            textBoxCantidad.Size = new Size(115, 23);
            textBoxCantidad.TabIndex = 31;
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.SandyBrown;
            buttonver.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonver.Location = new Point(1065, 157);
            buttonver.Margin = new Padding(3, 2, 3, 2);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(239, 29);
            buttonver.TabIndex = 49;
            buttonver.Text = "Ver datos de id a modificar";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(319, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(709, 396);
            dataGridView1.TabIndex = 50;
            // 
            // buttonMostrarCGrid
            // 
            buttonMostrarCGrid.BackColor = Color.SandyBrown;
            buttonMostrarCGrid.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonMostrarCGrid.Location = new Point(499, 111);
            buttonMostrarCGrid.Name = "buttonMostrarCGrid";
            buttonMostrarCGrid.Size = new Size(330, 28);
            buttonMostrarCGrid.TabIndex = 51;
            buttonMostrarCGrid.Text = "Mostrar Menor a Mayor Cantidad";
            buttonMostrarCGrid.UseVisualStyleBackColor = false;
            buttonMostrarCGrid.Click += buttonMostrarCGrid_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.SandyBrown;
            buttonActualizar.Font = new Font("Bodoni MT", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonActualizar.Location = new Point(127, 155);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(114, 28);
            buttonActualizar.TabIndex = 52;
            buttonActualizar.Text = "Actualizar";
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
            lbFecha.Location = new Point(28, 21);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(72, 18);
            lbFecha.TabIndex = 54;
            lbFecha.Text = "00/00/0000";
            // 
            // lbHora
            // 
            lbHora.AutoSize = true;
            lbHora.Font = new Font("Bodoni MT", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbHora.Location = new Point(125, 21);
            lbHora.Name = "lbHora";
            lbHora.Size = new Size(60, 18);
            lbHora.TabIndex = 53;
            lbHora.Text = "00:00:00";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.BackColor = Color.Transparent;
            lblNom.Font = new Font("Baskerville Old Face", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNom.ForeColor = SystemColors.ControlText;
            lblNom.Location = new Point(515, 31);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(302, 40);
            lblNom.TabIndex = 55;
            lblNom.Text = "Lista de Productos.";
            // 
            // botSubir
            // 
            botSubir.BackColor = Color.SandyBrown;
            botSubir.Font = new Font("Bodoni MT", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            botSubir.Location = new Point(125, 441);
            botSubir.Name = "botSubir";
            botSubir.Size = new Size(114, 78);
            botSubir.TabIndex = 56;
            botSubir.Text = "Subir imagen del producto";
            botSubir.UseVisualStyleBackColor = false;
            botSubir.Click += botSubir_Click;
            // 
            // frmModProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1329, 626);
            Controls.Add(botSubir);
            Controls.Add(lblNom);
            Controls.Add(lbFecha);
            Controls.Add(lbHora);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonMostrarCGrid);
            Controls.Add(dataGridView1);
            Controls.Add(buttonver);
            Controls.Add(textBoxCantidad);
            Controls.Add(textBoxCantidadMod);
            Controls.Add(textBoxEliminar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonInsertar);
            Controls.Add(textBoxPrecio);
            Controls.Add(textBoxImagen);
            Controls.Add(textBoxproducto);
            Controls.Add(textBoxId);
            Controls.Add(buttonMod);
            Controls.Add(textBoxPrecioMod);
            Controls.Add(textBoxImgMod);
            Controls.Add(textBoxprodMod);
            Controls.Add(textBoxModId);
            Controls.Add(textBoxidMod);
            Controls.Add(buttonSalirAdmin);
            Name = "frmModProd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSalirAdmin;
        private Button buttonMod;
        private TextBox textBoxPrecioMod;
        private TextBox textBoxImgMod;
        private TextBox textBoxprodMod;
        private TextBox textBoxModId;
        private TextBox textBoxidMod;
        private Button buttonInsertar;
        private TextBox textBoxPrecio;
        private TextBox textBoxImagen;
        private TextBox textBoxproducto;
        private TextBox textBoxId;
        private TextBox textBoxEliminar;
        private Button buttonEliminar;
        private TextBox textBoxCantidadMod;
        private TextBox textBoxCantidad;
        private Button buttonver;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonMostrarCGrid;
        private Button buttonActualizar;
        private System.Windows.Forms.Timer timer1;
        private Label lbFecha;
        private Label lbHora;
        private System.Windows.Forms.Timer timer2;
        private Label lblNom;
        private Button botSubir;
    }
}