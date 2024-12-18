using MySql.Data.MySqlClient;
using System.Data;

namespace proyectof
{
    class ControlFunciones

    {
        public double venT { get; private set; }
        public string ctrlLogin(string usuario, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datoUsuario = new Usuarios();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                datoUsuario = modelo.validaUsuario(usuario);
                if (datoUsuario == null)
                {
                    respuesta = "El usuario no existe.";
                }
                else
                {
                    if (datoUsuario.Password != password)
                    {
                        respuesta = "El usuario o contraseña no coinciden.";
                    }
                }
            }
            return respuesta;
        }

        public void ordenaNombre(Form formulario)
        {
            MySqlConnection conectaInv = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");
            System.Data.DataTable tbl = new System.Data.DataTable();
            conectaInv.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaInv;
            MySqlDataAdapter com = new MySqlDataAdapter("SELECT nombre FROM inventario", conectaInv);
            com.Fill(tbl);
            conectaInv.Close();
            int posY = 320; // Posición vertical inicial
            int posX = 220; // Posición horizontal
            int cont = 0;
            int registrosPorFila = 5;

            foreach (System.Data.DataRow row in tbl.Rows)
            {
                // Crear un nuevo Label para cada registro
                Label nuevoLabel = new Label();
                nuevoLabel.Text = row["nombre"].ToString();
                nuevoLabel.Location = new System.Drawing.Point(posX, posY); // Posición en la ventana
                nuevoLabel.AutoSize = true;
                nuevoLabel.TextAlign = ContentAlignment.MiddleCenter;

                // Agregar el Label al formulario
                formulario.Controls.Add(nuevoLabel);

                // Incrementar la posición vertical para el siguiente Label
                posX += 330;
                cont++;
                if (cont % registrosPorFila == 0)
                {
                    posY = 645; // ajusta la posicion vertical de la segunda vista
                    posX = 220; // reinicia la posición horizontal
                }
            }
        }
        public void ordenaPrecio(Form formulario)
        {
            MySqlConnection conectaInv = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");
            System.Data.DataTable tbl = new System.Data.DataTable();
            conectaInv.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conectaInv;
            MySqlDataAdapter com = new MySqlDataAdapter("SELECT precio FROM inventario", conectaInv);
            com.Fill(tbl);
            conectaInv.Close();
            int posY = 360; // Posición vertical inicial
            int posX = 220; // Posición horizontal
            int cont = 0;
            int registrosPorFila = 5;

            foreach (System.Data.DataRow row in tbl.Rows)
            {
                // Crear un nuevo Label para cada registro
                Label nuevoLabel = new Label();
                nuevoLabel.Text = "Precio: " + row["precio"].ToString();
                nuevoLabel.Location = new System.Drawing.Point(posX, posY); // Posición en la ventana
                nuevoLabel.AutoSize = true;
                nuevoLabel.TextAlign = ContentAlignment.MiddleCenter;

                // Agregar el Label al formulario
                formulario.Controls.Add(nuevoLabel);

                // Incrementar la posición vertical para el siguiente Label
                posX += 330;
                cont++;
                if (cont % registrosPorFila == 0)
                {
                    posY = 690; // Posición vertical inicial
                    posX = 220; // Posición horizontal
                }
            }
        }

        public void ordenaImagenes(Form formulario)
        {
            // Ruta base donde están las imágenes en el proyecto
            string rutaBaseImagenes = Path.Combine(Application.StartupPath, "Imagenes");
            DataTable tbl = new DataTable();

            // Crear conexión a la base de datos
            using (MySqlConnection conectaInv = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;"))
            {
                conectaInv.Open();

                // Consulta para obtener los nombres de las imágenes
                using (MySqlDataAdapter com = new MySqlDataAdapter("SELECT imagen FROM inventario", conectaInv))
                {
                    com.Fill(tbl);
                }
            }

            // Configuración de posiciones iniciales (igual al código anterior)
            int posX = 220; // Posición horizontal inicial
            int posY = 120; // Posición vertical inicial
            int imagenesPorFila = 5; // Cantidad de imágenes por fila
            int contador = 0; // Contador de imágenes
            int tamañoImagen = 170; // Tamaño del PictureBox (ancho y alto)

            foreach (DataRow row in tbl.Rows)
            {
                // Obtener el nombre del archivo desde la base de datos
                string nombreImagen = row["imagen"].ToString();

                // Construir la ruta completa de la imagen
                string rutaImagen = Path.Combine(rutaBaseImagenes, nombreImagen);

                // Crear y configurar el PictureBox
                PictureBox nuevoPictureBox = new PictureBox
                {
                    Size = new Size(tamañoImagen, tamañoImagen),
                    Location = new Point(posX, posY), // Mantener las posiciones del código original
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                try
                {
                    if (File.Exists(rutaImagen))
                    {
                        // Cargar y redimensionar la imagen
                        Image imagenOriginal = Image.FromFile(rutaImagen);
                        nuevoPictureBox.Image = new Bitmap(imagenOriginal, new Size(tamañoImagen, tamañoImagen));
                    }
                    else
                    {
                        MessageBox.Show($"La imagen no existe en la ruta: {rutaImagen}");
                        continue;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen '{nombreImagen}': {ex.Message}");
                    continue;
                }

                // Agregar el PictureBox al formulario
                formulario.Controls.Add(nuevoPictureBox);

                // Incrementar posición horizontal
                posX += tamañoImagen + 160; // Espaciado horizontal
                contador++;

                // Si llegamos al límite de imágenes por fila, mover a la siguiente fila
                if (contador % imagenesPorFila == 0)
                {
                    posX = 220; // Reiniciar posición horizontal
                    posY += 340; // Incrementar posición vertical (misma lógica que el código original)
                }
            }
        }



        public void ordenaNUD(Form formulario)
        {
            MySqlConnection conectaInv = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");
            System.Data.DataTable tbl = new System.Data.DataTable();
            conectaInv.Open();
            MySqlDataAdapter com = new MySqlDataAdapter("SELECT idProducto,precio, cantidad FROM inventario", conectaInv);
            com.Fill(tbl);
            conectaInv.Close();

            int posY = 400; // Posición vertical inicial
            int posX = 220; // Posición horizontal
            int cont = 0;
            int registrosPorFila = 5;

            foreach (System.Data.DataRow row in tbl.Rows)
            {
                //idea para que el maximo de los numeric sea la cantidad disponible en el inventario
                /* string consulta = "SELECT cantidad from inventario";
                 MySqlCommand comando = new MySqlCommand(consulta, conectaInv);
                 object resultado = comando.ExecuteScalar();
                 decimal maxValor = Convert.ToDecimal(resultado);
                */
                int productoID = (int)row["idProducto"];
                decimal precio = Convert.ToDecimal(row["precio"]);
                decimal cantidadDisponible = Convert.ToDecimal(row["cantidad"]);

                // Crear un NumericUpDown para que el usuario seleccione la cantidad
                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Name = "nud_" + cont; // Asignar un nombre único basado en el índice
                numericUpDown.Location = new System.Drawing.Point(posX, posY); // Posición en la ventana
                numericUpDown.Minimum = 0; // Valor mínimo permitido
                numericUpDown.Maximum = cantidadDisponible;//(int)row["cantidad"]; // Valor máximo permitido (ajusta según lo necesites)
                numericUpDown.Width = 60;
                numericUpDown.Tag = productoID;

                // Agregar el NumericUpDown al formulario
                formulario.Controls.Add(numericUpDown);

                // Ajustar las posiciones para el próximo control
                posX += 335;
                cont++;
                if (cont % registrosPorFila == 0)
                {
                    posY = 730; // Ajusta la posición vertical para la próxima fila
                    posX = 220; // Reinicia la posición horizontal
                }
            }
        }


        public void Venta(Form formulario)
        {

            MySqlConnection conectaInv = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");
            venT = 0;//cantidad total de VENTA
            List<ControlData> aux = new List<ControlData>();//lista para guardar los objetos vendidos
            string nombreLabel = null;

            try
            {
                conectaInv.Open();

                // Obtener el siguiente id_venta automáticamente para la tabla info_venta
                string obtenerIdVenta = "SELECT IFNULL(MAX(id_venta), 0) +1 FROM info_ventas";
                MySqlCommand idComando = new MySqlCommand(obtenerIdVenta, conectaInv);


                int idVenta = Convert.ToInt32(idComando.ExecuteScalar());

                foreach (Control control in formulario.Controls)
                {
                    if (control is NumericUpDown numeric)
                    {
                        int productoID = (int)numeric.Tag;

                        //Consulta para obtener el preciol del producto y pasar el valor a la variable resultado
                        string costo = "SELECT precio FROM inventario WHERE idProducto = @productoID";
                        MySqlCommand comando = new MySqlCommand(costo, conectaInv);
                        comando.Parameters.AddWithValue("@productoID", productoID);
                        object resultado = comando.ExecuteScalar();

                        string nombre = "SELECT nombre FROM inventario WHERE idProducto = @productoID";
                        MySqlCommand comando2 = new MySqlCommand(nombre, conectaInv);
                        comando2.Parameters.AddWithValue("@productoID", productoID);
                        object resultado2 = comando2.ExecuteScalar();
                        nombreLabel = Convert.ToString(resultado2);

                        if (resultado != null)
                        {
                            double costoProd = Convert.ToDouble(resultado);

                            if (numeric.Value > 0)
                            {
                                //consulta para obtener el ultimo id de venta del producto
                                string ultimoID = "SELECT IFNULL(MAX(id_venta_producto), 0) + 1 FROM ventas_producto";
                                MySqlCommand comUltimoID = new MySqlCommand(ultimoID, conectaInv);
                                object result = comUltimoID.ExecuteScalar();

                                string insertarVentaporProd = "INSERT INTO ventas_producto (id_venta_producto, id_venta, idProducto, cantidad_producto, total_venta_producto, nombre_producto) VALUES (@id_venta_producto, @id_venta, @idProducto, @cantidad_producto, @total_venta_producto, @nombre_producto)";
                                MySqlCommand insertComando = new MySqlCommand(insertarVentaporProd, conectaInv);
                                insertComando.Parameters.AddWithValue("@id_venta_producto", Convert.ToInt32(result));
                                insertComando.Parameters.AddWithValue("@id_venta", idVenta);
                                insertComando.Parameters.AddWithValue("@idProducto", productoID);
                                insertComando.Parameters.AddWithValue("@cantidad_producto", numeric.Value);
                                insertComando.Parameters.AddWithValue("@total_venta_producto", numeric.Value * (decimal)costoProd);
                                insertComando.Parameters.AddWithValue("@nombre_producto", nombreLabel);
                                insertComando.ExecuteNonQuery();

                                venT += (double)numeric.Value * costoProd;

                                // Actualizar la cantidad en inventario
                                string reduceQuery = "UPDATE inventario SET cantidad = cantidad - @cantidadVendida WHERE idProducto = @productoID";
                                MySqlCommand reduceComando = new MySqlCommand(reduceQuery, conectaInv);
                                reduceComando.Parameters.AddWithValue("@cantidadVendida", numeric.Value);
                                reduceComando.Parameters.AddWithValue("@productoID", productoID);
                                reduceComando.ExecuteNonQuery(); // Ejecutar la actualización

                            }
                        }
                        else
                        {
                            MessageBox.Show($"No se pudo obtener el precio del producto");
                        }
                    }
                }
                //MessageBox.Show($"La venta por ${venT} se ha realizado con éxito.");



                // Registrar la venta en la tabla info_ventas
                string fechaVenta = DateTime.Now.ToString("yyyy-MM-dd"); // Fecha actual en formato date

                string insertarVenta = "INSERT INTO info_ventas (id_venta, fecha_venta, total_venta, tipo_pago) VALUES (@idVenta, @fechaVenta, @totalVenta, NULL)";
                MySqlCommand insertarComando = new MySqlCommand(insertarVenta, conectaInv);
                insertarComando.Parameters.AddWithValue("@idVenta", idVenta);
                insertarComando.Parameters.AddWithValue("@fechaVenta", fechaVenta);
                insertarComando.Parameters.AddWithValue("@totalVenta", venT);
                insertarComando.ExecuteNonQuery();

                Form1 ventaUsuario = Application.OpenForms.OfType<Form1>().LastOrDefault();//recuera el form1 con la informacion llenada
                string ventaPorUsuario = ventaUsuario.UsuarioAux;//obtiene el usuario del tBUsuario de Form1
                if (string.IsNullOrEmpty(ventaPorUsuario))
                {
                    throw new Exception("El usuario no puede estar vacío.");
                }
                else
                {
                    //MessageBox.Show($"Usuario obtenido: {ventaPorUsuario}");
                }

                //primero se tiene que conseguir el valor que hay en la celda de venta antes de agregar el valor
                string cantidadAnterior = "SELECT venta_usuario FROM usuarios WHERE usuario=@ventaPorUsuario";
                MySqlCommand queryCantidad = new MySqlCommand(cantidadAnterior, conectaInv);
                queryCantidad.Parameters.AddWithValue("@ventaPorUsuario", ventaPorUsuario);
                object cantidadAntiguaObj = queryCantidad.ExecuteScalar();
                decimal cantidadAntigua = Convert.ToDecimal(cantidadAntiguaObj);//null ? Convert.ToDecimal(cantidadAntiguaObj) : 0;//esta es en caso de que el registro este vacio
                decimal nuevaCantidad = cantidadAntigua + (decimal)venT;

                string actualizaVenta = "UPDATE usuarios SET venta_usuario=@nuevaCantidad WHERE usuario=@ventaPorUsuario";//insercion de la venta a la tabla
                MySqlCommand actualiza = new MySqlCommand(actualizaVenta, conectaInv);
                actualiza.Parameters.AddWithValue("@ventaPorUsuario", ventaPorUsuario);
                actualiza.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                actualiza.ExecuteNonQuery();

                //ventaUsuario.tBUsuario = null;
            }
            catch (MySqlException sqlEx)
            {
                MessageBox.Show($"Error de MySQL: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                // En caso de error, mostrar un mensaje
                MessageBox.Show($"Error al realizar la venta.{ex.Message}");
            }
            finally
            {
                // Cerrar la conexión
                if (conectaInv.State == System.Data.ConnectionState.Open)
                {
                    conectaInv.Close();
                }
            }

        }

        public void ActualizaNUD(Form formulario)
        {
            MySqlConnection conectaInv = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");

            try
            {
                conectaInv.Open();

                foreach (Control control in formulario.Controls)
                {
                    if (control is NumericUpDown numeric)
                    {
                        int productoID = (int)numeric.Tag;

                        // Consultar la cantidad actualizada del inventario
                        string consultaCantidad = "SELECT cantidad FROM inventario WHERE idProducto = @productoID";
                        MySqlCommand comandoCantidad = new MySqlCommand(consultaCantidad, conectaInv);
                        comandoCantidad.Parameters.AddWithValue("@productoID", productoID);
                        object resultadoCantidad = comandoCantidad.ExecuteScalar();

                        if (resultadoCantidad != null)
                        {
                            int nuevaCantidadDisponible = Convert.ToInt32(resultadoCantidad);

                            // Actualizar el máximo del NumericUpDown
                            numeric.Maximum = nuevaCantidadDisponible;

                            // Si el valor actual excede el nuevo máximo, ajustarlo
                            if (numeric.Value > nuevaCantidadDisponible)
                            {
                                numeric.Value = nuevaCantidadDisponible;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No se encontró información para el producto con ID {productoID}.");
                        }
                    }
                }

                //MessageBox.Show("Controles actualizados correctamente según el inventario.");
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al actualizar los controles: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión
                if (conectaInv.State == System.Data.ConnectionState.Open)
                {
                    conectaInv.Close();
                }
            }
        }

        public void ReiniciaNUD(Form formulario)
        {
            MySqlConnection conectaInv = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");

            try
            {
                conectaInv.Open();

                foreach (Control control in formulario.Controls)
                {
                    if (control is NumericUpDown numeric)
                    {
                        int productoID = (int)numeric.Tag;

                        if (numeric.Value > 0)
                        {
                            numeric.Value = 0;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Error al actualizar los controles: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión
                if (conectaInv.State == System.Data.ConnectionState.Open)
                {
                    conectaInv.Close();
                }
            }
        }
    }
}