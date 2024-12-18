using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
using Mysqlx.Crud;
using Microsoft.VisualBasic;
using proyectof;
using System.Media;
using System.Windows.Forms;


namespace proyectof
{

    public class AdmonBD
    {

        private MySqlConnection connection;
        private MusicPlayer musicPlayer;


        public AdmonBD()
        {
            this.Connect();
            musicPlayer = new MusicPlayer(@"berlioz-deep-in-it.wav");
            musicPlayer.PlayLooping();

        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
               
            }
        }
        public static void ActualizarFechaHora(Label lbHora, Label lbFecha)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        public List<Productos> consulta()
        {
            List<Productos> data = new List<Productos>();
            Productos item;
            int id;
            string producto;
            int precio;
            int cantidad;
            string imagen;

            try
            {
                string query = "SELECT * FROM inventario";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Ejemplo: mostrar los datos de las columnas
                    id = Convert.ToInt32(reader["idProducto"]);
                    producto = Convert.ToString(reader["nombre"]) ?? "";
                    precio = Convert.ToInt32(reader["precio"]);
                    cantidad = Convert.ToInt32(reader["cantidad"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";

                    item = new Productos(id, producto, precio, cantidad, imagen);
                    data.Add(item);

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return data;

        }

        public void insertar(int idp, string prod, int price,int cant, string img)
        {
            int  cont=0;
            AdmonBD obj = new AdmonBD();
            var data = obj.consulta();
            string query = "";
            try
            {
                foreach (var item in data)
                {
                    cont++;
                }

                if (cont <= 9)
                {
                    /* Esta forma de insertar es la menos segura en cuanto ataques por mysql pero la mas sencilla por lo pronto*/
                    query = "INSERT INTO inventario (idProducto,nombre,precio,cantidad,imagen) VALUES ("
                   + "'" + idp + "',"
                   + "'" + prod + "',"
                   + "'" + price + "', "
                   + "'" + cant + "' , "
                   + "'" + img + "')";



                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("\nRegistro Agregado");
                }
                else
                {
                    MessageBox.Show("Llego a Su Maxima Capacidad el Inventario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nClave duplicada" + ex.Message);
                this.Disconnect();
            }


        }

        public Productos consultaUnRegistro(int idp)
        {

            Productos item = null;
            int id;
            string producto;
            int precio;
            int cantidad;
            string imagen;
            
            try
            {
                string query = "SELECT * FROM inventario where idProducto=" + idp + ";";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())  //solo encontrara un registro da una vuelta
                {

                    id = Convert.ToInt32(reader["idProducto"]);
                    producto = Convert.ToString(reader["nombre"]) ?? "";
                    precio = Convert.ToInt32(reader["precio"]);
                    cantidad = Convert.ToInt32(reader["cantidad"]);
                    imagen = Convert.ToString(reader["imagen"]) ?? "";
                    

                    item = new Productos(id, producto, precio, cantidad, imagen);


                }
                reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return item;
        }


        public void eliminar(int idp)
        {
            int cont = 0;
            AdmonBD obj = new AdmonBD();
            var data = obj.consulta();
            string query = "";

            try
            {
                foreach (var item in data)
                {
                    cont++;
                }

                if (cont >=7)
                {
                    query = "DELETE FROM inventario WHERE idProducto=" + idp + ";";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("Inventario en Capacidad Minima", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(query + "\nError " + ex.Message);
                this.Disconnect();
            }
        }


        public void actualizar(int idp, string prod, int price, int cant, string img)
        {
            try
            {
                string query = "UPDATE inventario SET idProducto=" + "'" + idp + "'" + ",nombre=" + "'" + prod + "'" + ",precio=" + "'" + price + "'" + ",cantidad=" + "'" + cant + "'" + ",imagen=" + "'" + img + "'" + "where idProducto=" + idp + ";";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado Correctamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la actualizacion: " + ex.Message);
                this.Disconnect();
            }
        }

        public void Connect()
        {
            string cadena = "Server=localhost; Database=databaseproyecto; User=root; Password=; SslMode=none;";
            try
            {
                connection = new MySqlConnection(cadena);
                connection.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    



    }
