using MySql.Data.MySqlClient;
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
    public partial class tarjeta : Form
    {
        public decimal CantidadAPagar { get; set; }
        private bool pagoRealizado = false; // Inicialmente no se ha realizado el pago
        decimal CantidadAPagarConIVA;//Tomará el valor de cantidad a pagar + el porcentaje del iva

        public tarjeta()
        {
            InitializeComponent();
            Form1 ventaUsuario = Application.OpenForms.OfType<Form1>().LastOrDefault();//recuera el form1 con la informacion llenada
            string ventaPorUsuario = ventaUsuario.UsuarioAux;//obtiene el usuario del tBUsuario de Form1
            lblNom.Text = "Usuario: " + ventaPorUsuario;
        }

        private void tarjeta_Load(object sender, EventArgs e)
        {
            CantidadAPagarConIVA = CantidadAPagar * (decimal)1.16;
            labelTotal.Text = $"{CantidadAPagarConIVA:C}"; // Mostrar la cantidad formateada como moneda
        }



        private void buttonPagar_Click_1(object sender, EventArgs e)
        {
            string numeroTarjeta = textBoxTarjeta.Text.Trim();
            string titular = textBoxNombre.Text.Trim();
            string mes = textBoxMes.Text.Trim();
            string ano = textBoxAno.Text.Trim();
            string cvv = textBoxCVV.Text.Trim();

            // Validar que todos los campos estén llenos
            if (string.IsNullOrEmpty(numeroTarjeta) || string.IsNullOrEmpty(titular) ||
                string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(ano) || string.IsNullOrEmpty(cvv))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el número de tarjeta tenga 16 dígitos
            if (numeroTarjeta.Length != 16 || !long.TryParse(numeroTarjeta, out _))
            {
                MessageBox.Show("El número de tarjeta debe tener 16 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el CVV tenga 3 dígitos
            if (cvv.Length != 3 || !int.TryParse(cvv, out _))
            {
                MessageBox.Show("El CVV debe tener 3 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el mes
            if (!int.TryParse(mes, out int mesInt) || mesInt < 1 || mesInt > 12)
            {
                MessageBox.Show("El mes debe ser un número entre 01 y 12.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar el año
            if (!int.TryParse(ano, out int anoInt) || anoInt < DateTime.Now.Year || anoInt > DateTime.Now.Year + 10)
            {
                MessageBox.Show("El año debe ser válido y no menor al actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que la fecha no sea anterior al mes y año actuales
            DateTime fechaActual = DateTime.Now;
            DateTime fechaVencimiento = new DateTime(anoInt, mesInt, 1);

            if (fechaVencimiento < new DateTime(fechaActual.Year, fechaActual.Month, 1))
            {
                MessageBox.Show("La tarjeta está vencida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todo es válido
            MessageBox.Show("Pago realizado con éxito. Gracias por su compra.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GenerarTicket("TARJETA", CantidadAPagar);

            pagoRealizado = true; // Actualizar la bandera
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            // Regresar al formulario anterior
            opcVenta formOpcVenta = new opcVenta();
            formOpcVenta.Show();
            this.Close();

        }

        private void buttonSigue_Click(object sender, EventArgs e)
        {
            if (pagoRealizado)
            {
                // Si ya se realizó el pago, regresar a frmUsuario
                frmUsuario formUsuario = new frmUsuario();
                formUsuario.Show();
                this.Close(); // Cierra el formulario actual
            }
            else
            {
                // Si no se ha pagado, mostrar un mensaje
                MessageBox.Show("Debe realizar el pago antes de continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void GenerarTicket(string metodoPago, decimal totalVenta)
        {
            string connectionString = "Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;";
            string rutaArchivo = "TicketPagoTarjeta.pdf"; // Ruta y nombre del archivo PDF
            string rutaImagen = "dino.png"; // Asegúrate de que la imagen esté en el directorio del proyecto

            using (var documento = new iTextSharp.text.Document())
            {
                try
                {
                    // Crear el escritor del PDF
                    iTextSharp.text.pdf.PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));

                    // Abrir el documento para edición
                    documento.Open();

                    // Agregar la imagen al inicio
                    if (File.Exists(rutaImagen))
                    {
                        var imagen = iTextSharp.text.Image.GetInstance(rutaImagen);
                        imagen.ScaleToFit(150f, 150f); // Ajustar tamaño
                        imagen.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar imagen
                        documento.Add(imagen);
                    }

                    // Agregar el encabezado del ticket
                    var titulo = new iTextSharp.text.Paragraph("TICKET DE PAGO", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(titulo);

                    // Línea divisoria
                    var linea = new iTextSharp.text.Paragraph("------------------------------------------");
                    linea.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    documento.Add(linea);

                    // Detalles de la venta
                    var fecha = new iTextSharp.text.Paragraph($"Fecha: {DateTime.Now}");
                    fecha.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    documento.Add(fecha);

                    var total = new iTextSharp.text.Paragraph($"Total: {totalVenta:C}");
                    total.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    documento.Add(total);

                    var metodo = new iTextSharp.text.Paragraph($"Método de Pago: {metodoPago}");
                    metodo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    documento.Add(metodo);

                    //agrega info de productos
                    AgregarTextoCentrado(documento, "Detalle de productos", 14, iTextSharp.text.Font.BOLD);

                    //agregado
                    using (var connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Consulta para obtener el último id_venta
                        string queryIdVenta = "SELECT MAX(id_venta) AS id_venta FROM info_ventas";
                        int idVenta;

                        using (var command = new MySqlCommand(queryIdVenta, connection))
                        {
                            object result = command.ExecuteScalar();
                            idVenta = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                        }

                        //idVenta = idVenta - 1;//esta linea toma el registro con información por duplicado
                        // Consulta para obtener los productos relacionados con el id_venta
                        string queryProductos = "SELECT idProducto, cantidad_producto, total_venta_producto, nombre_producto FROM ventas_producto WHERE id_venta = @idVenta";

                        using (var command = new MySqlCommand(queryProductos, connection))
                        {
                            command.Parameters.AddWithValue("@idVenta", idVenta);

                            using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string idProducto = reader["idProducto"].ToString();
                                    string nomProd = reader["nombre_producto"].ToString();
                                    string cantidad = reader["cantidad_producto"].ToString();
                                    string totalProducto = Convert.ToDecimal(reader["total_venta_producto"]).ToString("C");

                                    // Agregar detalles del producto al documento
                                    AgregarTextoCentrado(documento, $"ID Producto: {idProducto}", 12);
                                    AgregarTextoCentrado(documento, $"Producto: {nomProd}", 12);
                                    AgregarTextoCentrado(documento, $"Cantidad: {cantidad}", 12);
                                    AgregarTextoCentrado(documento, $"Total: {totalProducto}", 12);
                                }
                            }
                        }
                    }
                    //fin agregado

                    // Línea divisoria final
                    var lineaFinal = new iTextSharp.text.Paragraph("------------------------------------------");
                    lineaFinal.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    documento.Add(lineaFinal);

                    // Mensaje de agradecimiento
                    var agradecimiento = new iTextSharp.text.Paragraph("Gracias por su compra", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.ITALIC));
                    agradecimiento.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    documento.Add(agradecimiento);

                    MessageBox.Show("El ticket se ha generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el ticket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    documento.Close();
                }
            }
        }
        private void AgregarTextoCentrado(iTextSharp.text.Document documento, string texto, int tamañoFuente = 12, int estiloFuente = iTextSharp.text.Font.NORMAL)
        {
            var fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, tamañoFuente, estiloFuente);
            var parrafo = new iTextSharp.text.Paragraph(texto, fuente)
            {
                Alignment = iTextSharp.text.Element.ALIGN_CENTER
            };
            documento.Add(parrafo);
        }


    }
}
