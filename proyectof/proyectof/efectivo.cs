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


namespace proyectof
{
    public partial class efectivo : Form
    {

        public decimal CantidadAPagar { get; set; }
        private bool pagoRealizado = false; // Inicialmente, no se ha realizado el pago
        decimal CantidadAPagarConIVA;//Tomará el valor de cantidad a pagar + el porcentaje del iva


        public efectivo()
        {
            InitializeComponent();

            Form1 ventaUsuario = Application.OpenForms.OfType<Form1>().LastOrDefault();//recuera el form1 con la informacion llenada
            string ventaPorUsuario = ventaUsuario.UsuarioAux;//obtiene el usuario del tBUsuario de Form1
            lblNom.Text = "Usuario: " + ventaPorUsuario;
        }


        private void efectivo_Load(object sender, EventArgs e)
        {
            // Actualiza el label con la cantidad a pagar
            labelCantidad.Text = $"{CantidadAPagar * (decimal)1.16:C}";
            //MessageBox.Show($"Cantidad a mostrar: {CantidadAPagar:C}");//depurar mensaje unicamente para corroborar que la cantidad se pasó correctamente
            CantidadAPagarConIVA = CantidadAPagar * (decimal)1.16;
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxPago.Text, out decimal cantidadIngresada))
            {
                if (cantidadIngresada >= CantidadAPagarConIVA)
                {
                    decimal cambio = cantidadIngresada - CantidadAPagarConIVA;
                    MessageBox.Show(cambio > 0
                        ? $"Pago realizado con éxito. Su cambio es: {cambio:C}"
                        : "Pago realizado con éxito. No hay cambio.");

                    //ControlFunciones controlFunciones = new ControlFunciones();

                    // Generar la lista de datos de los controles
                    //List<ControlData> datosRecopilados = new List<ControlData>();
                    //controlFunciones.Venta(this); // Llama a Venta para llenar la lista
                    // Generar el ticket
                    GenerarTicket(CantidadAPagar, cantidadIngresada, cambio);
                    pagoRealizado = true; // Marca que el pago ha sido
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada es insuficiente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
            //imprimirTicket();
        }

        private void buttonOtraCompra_Click(object sender, EventArgs e)
        {
            if (pagoRealizado)
            {
                frmUsuario formUsuario = new frmUsuario();
                formUsuario.Show();
                this.Close(); // Cierra el formulario actual
            }
            else
            {
                MessageBox.Show("Debe realizar el pago antes de continuar.");
            }
        }

        private void GenerarTicket(decimal total, decimal cantidadIngresada, decimal cambio)
        {
            string connectionString = "Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;";
            string rutaArchivo = $"TicketVenta-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.pdf"; // Ruta y nombre del archivo PDF
            string rutaImagen = "dino.png"; // Ruta de la imagen (asegúrate de que esté en el mismo directorio)


            // Crear el documento PDF
            using (var documento = new iTextSharp.text.Document())
            {
                try
                {
                    // Crear el escritor que genera el PDF
                    iTextSharp.text.pdf.PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));

                    // Abrir el documento para edición
                    documento.Open();

                    // Agregar la imagen al PDF
                    if (File.Exists(rutaImagen))
                    {
                        var imagen = iTextSharp.text.Image.GetInstance(rutaImagen);
                        imagen.ScaleToFit(150f, 150f); // Ajustar tamaño
                        imagen.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar imagen
                        documento.Add(imagen);
                    }

                    // Agregar el título
                    var titulo = new iTextSharp.text.Paragraph("TICKET DE VENTA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                    titulo.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(titulo);

                    // Línea divisoria
                    var linea = new iTextSharp.text.Paragraph("------------------------------------------");
                    linea.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(linea);

                    // Agregar detalles del ticket
                    var fecha = new iTextSharp.text.Paragraph($"Fecha: {DateTime.Now}");
                    fecha.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(fecha);

                    var totalPagar = new iTextSharp.text.Paragraph($"Total a pagar: {total:C} (IVA: ${(decimal)total * (decimal).16})");
                    totalPagar.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(totalPagar);

                    var cantidadIngresadaText = new iTextSharp.text.Paragraph($"Cantidad ingresada: {cantidadIngresada:C}");
                    cantidadIngresadaText.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(cantidadIngresadaText);

                    var cambioText = new iTextSharp.text.Paragraph($"Cambio: {cambio:C}");
                    cambioText.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(cambioText);

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
                    lineaFinal.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(lineaFinal);

                    // Mensaje de agradecimiento
                    var agradecimiento = new iTextSharp.text.Paragraph("Gracias por su compra", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.ITALIC));
                    agradecimiento.Alignment = iTextSharp.text.Element.ALIGN_CENTER; // Centrar texto
                    documento.Add(agradecimiento);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar el ticket: {ex.Message}");
                }
                finally
                {
                    // Cerrar el documento
                    documento.Close();
                }
            }

            MessageBox.Show($"El ticket se ha guardado como {rutaArchivo}");
        }

        public void GuardarVenta(decimal totalVenta, string tipoPago, List<(int idProducto, int cantidad, decimal totalProducto)> productos)
        {
            string connectionString = "Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;"; // Actualiza según tu configuración
            int idVenta;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insertar en info_ventas
                    string queryInfoVentas = "INSERT INTO info_ventas (fecha_venta, total_venta, tipo_pago) VALUES (@fechaVenta, @totalVenta, @tipoPago)";
                    using (MySqlCommand command = new MySqlCommand(queryInfoVentas, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@fechaVenta", DateTime.Now);
                        command.Parameters.AddWithValue("@totalVenta", totalVenta);
                        command.Parameters.AddWithValue("@tipoPago", tipoPago);
                        command.ExecuteNonQuery();

                        // Obtener el id_venta generado
                        idVenta = (int)command.LastInsertedId;
                    }

                    // Insertar en ventas_productos
                    string queryVentasProductos = "INSERT INTO ventas_productos (id_venta, id_producto, cantidad_producto, total_venta_producto) VALUES (@idVenta, @idProducto, @cantidadProducto, @totalProducto)";
                    using (MySqlCommand command = new MySqlCommand(queryVentasProductos, connection, transaction))
                    {
                        foreach (var producto in productos)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@idVenta", idVenta);
                            command.Parameters.AddWithValue("@idProducto", producto.idProducto);
                            command.Parameters.AddWithValue("@cantidadProducto", producto.cantidad);
                            command.Parameters.AddWithValue("@totalProducto", producto.totalProducto);
                            command.ExecuteNonQuery();
                        }
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                    MessageBox.Show("Venta guardada con éxito.");
                }
                catch (Exception ex)
                {
                    // Revertir la transacción en caso de error
                    transaction.Rollback();
                    MessageBox.Show($"Error al guardar la venta: {ex.Message}");
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdmonBD.ActualizarFechaHora(lbHora, lbFecha);
        }

        private void lbHora_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Regresar al formulario anterior
            opcVenta formOpcVenta = new opcVenta();
            formOpcVenta.Show();
            this.Close();
        }
    }
}
