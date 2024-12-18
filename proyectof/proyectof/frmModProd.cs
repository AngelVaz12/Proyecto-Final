using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace proyectof
{
    public partial class frmModProd : Form
    {
        MySqlConnection conectarBD = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");
        List<Productos> data;

        public frmModProd()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)//regresar a menu admin
        {
            frmAdmin admin = new frmAdmin();
            this.Close();
            admin.Show();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxTituloLP_TextChanged(object sender, EventArgs e)
        {

        }

        public void limpiarAgregar()
        {
            // Limpiar los valores de los campos
            this.textBoxId.Text = string.Empty;
            this.textBoxproducto.Text = string.Empty;
            this.textBoxPrecio.Text = string.Empty;
            this.textBoxCantidad.Text = string.Empty;
            this.textBoxImagen.Text = string.Empty;



        }
        public void limpiarModificar()
        {

            // Limpiar los valores de los campos
            this.textBoxidMod.Text = string.Empty;
            this.textBoxModId.Text = string.Empty;
            this.textBoxprodMod.Text = string.Empty;
            this.textBoxPrecioMod.Text = string.Empty;
            this.textBoxCantidadMod.Text = string.Empty;
            this.textBoxImgMod.Text = string.Empty;




        }
        public void limpiarEliminar()
        {
            // Limpiar los valores de los campos
            this.textBoxEliminar.Text = string.Empty;




        }

        private void buttonMod_Click(object sender, EventArgs e)
        {

            int id;
            string producto;
            int precio;
            int cantidad;
            string imagen;

            id = Convert.ToInt32(this.textBoxModId.Text);
            producto = this.textBoxprodMod.Text;
            precio = Convert.ToInt32(this.textBoxPrecioMod.Text);
            cantidad = Convert.ToInt32(this.textBoxCantidadMod.Text);
            imagen = this.textBoxImgMod.Text;



            AdmonBD obj = new AdmonBD();

            obj.actualizar(id, producto, precio, cantidad, imagen);
            limpiarModificar();
            obj.Disconnect();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            //Para agregar un nuevo producto
            //id, nombre(producto), precio, cantidad, imagen

            int id;
            string producto;
            int precio;
            int cantidad;
            string imagen;

            id = Convert.ToInt32(this.textBoxId.Text);
            producto = this.textBoxproducto.Text;
            precio = Convert.ToInt32(this.textBoxPrecio.Text);
            cantidad = Convert.ToInt32(this.textBoxCantidad.Text);
            imagen = this.textBoxImagen.Text;


            AdmonBD obj = new AdmonBD();
            obj.insertar(id, producto, precio, cantidad, imagen);
            limpiarAgregar();
            obj.Disconnect();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Para eleminar algun producto

            AdmonBD obj = new AdmonBD();
            obj.eliminar(Convert.ToInt32(this.textBoxEliminar.Text));
            this.textBoxEliminar.PlaceholderText = "id eliminar";
            limpiarEliminar();
            obj.Disconnect();
        }

        public void CargarProductos()
        {
            // Para mostrar los productos
            AdmonBD obj = new AdmonBD();
            var data = obj.consulta();

            /* Muestra la información en el DataGridView */
            this.dataGridView1.DataSource = null; // Limpia el DataGridView
            this.dataGridView1.DataSource = data;

            obj.Disconnect();
        }

        private void buttonver_Click(object sender, EventArgs e)
        {

            try
            {
                AdmonBD obj = new AdmonBD();

                // Convertimos el texto a un entero y consultamos un registro
                int id = Convert.ToInt32(this.textBoxidMod.Text);
                Productos aux = obj.consultaUnRegistro(id);

                // Verificamos si el registro existe
                if (aux != null)
                {


                    // Rellenamos los campos con los datos del producto
                    this.textBoxModId.Text = aux.Id.ToString();
                    this.textBoxprodMod.Text = aux.Producto;
                    this.textBoxPrecioMod.Text = aux.Precio.ToString();
                    this.textBoxCantidadMod.Text = aux.Cantidad.ToString();
                    this.textBoxImgMod.Text = aux.Imagen;
                }
                else
                {
                    MessageBox.Show("El producto con el ID proporcionado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                obj.Disconnect();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar obtener el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonMostrarCGrid_Click(object sender, EventArgs e)
        {
            // Para mostrar los productos
            AdmonBD obj = new AdmonBD();
            var data = obj.consulta();

            /* Ordena la lista por cantidad de menor a mayor */
            var dataOrdenada = data.OrderBy(p => p.Cantidad).ToList();

            /* Muestra la información en el DataGridView */
            this.dataGridView1.DataSource = null; // Limpia el DataGridView
            this.dataGridView1.DataSource = dataOrdenada;

            obj.Disconnect();
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            // Para mostrar los productos
            AdmonBD obj = new AdmonBD();
            var data = obj.consulta();

            /* Muestra la información en el DataGridView */
            this.dataGridView1.DataSource = null; // Limpia el DataGridView
            this.dataGridView1.DataSource = data;

            obj.Disconnect();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdmonBD.ActualizarFechaHora(lbHora, lbFecha);
        }

        private void botSubir_Click(object sender, EventArgs e)
        {
            // Ruta base donde se guardarán las imágenes en el proyecto
            string rutaDestino = Path.Combine(Application.StartupPath, "imagenes");

            try
            {
                // Crear un OpenFileDialog para seleccionar una imagen
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Seleccionar una imagen";
                    openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                    // Si el usuario selecciona un archivo y presiona OK
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta completa del archivo seleccionado
                        string rutaImagenSeleccionada = openFileDialog.FileName;

                        // Extraer el nombre del archivo
                        string nombreArchivo = Path.GetFileName(rutaImagenSeleccionada);

                        // Construir la ruta final en la carpeta "Imagenes"
                        string rutaFinal = Path.Combine(rutaDestino, nombreArchivo);

                        // Copiar la imagen seleccionada a la carpeta destino
                        File.Copy(rutaImagenSeleccionada, rutaFinal, overwrite: true);

                        // Notificar al usuario
                        MessageBox.Show("Imagen subida exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al subir la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
