using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectof
{
    public partial class trans : Form
    {
        public decimal CantidadAPagar { get; set; }
        private bool pagoRealizado = false; // Inicialmente, no se ha realizado el pago

        public trans()
        {
            InitializeComponent();
            Form1 ventaUsuario = Application.OpenForms.OfType<Form1>().LastOrDefault();//recuera el form1 con la informacion llenada
            string ventaPorUsuario = ventaUsuario.UsuarioAux;//obtiene el usuario del tBUsuario de Form1
            lblNom.Text = "Usuario: " + ventaPorUsuario;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Crear el cuadro de diálogo para seleccionar un archivo
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar imagen";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mostrar la imagen seleccionada en el PictureBox
                    pictureBoxCaptura.Image = Image.FromFile(openFileDialog.FileName);

                    // Obtener el nombre del archivo seleccionado
                    string nombreArchivo = Path.GetFileName(openFileDialog.FileName);

                    // Definir la ruta de la carpeta donde se guardará la imagen
                    string carpetaDestino = Path.Combine(Application.StartupPath, "Capturas");
                    Directory.CreateDirectory(carpetaDestino); // Crear la carpeta si no existe

                    // Ruta completa donde se guardará la imagen
                    string rutaDestino = Path.Combine(carpetaDestino, nombreArchivo);

                    try
                    {
                        // Guardar la imagen seleccionada en la carpeta del proyecto
                        File.Copy(openFileDialog.FileName, rutaDestino, true);
                        MessageBox.Show($"Imagen guardada correctamente en: {rutaDestino}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pagoRealizado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pagoRealizado) {
                frmUsuario frmU = new frmUsuario();
                frmU.Show();
                this.Hide();
            }else
            {
                MessageBox.Show($"Debes subir comprobante de pago antes de seguir.");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Regresar al formulario anterior
            opcVenta formOpcVenta = new opcVenta();
            formOpcVenta.Show();
            this.Close();
        }
    }
}
