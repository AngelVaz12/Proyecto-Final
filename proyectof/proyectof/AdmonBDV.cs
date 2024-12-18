
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

namespace proyectof
{

    public class AdmonBDV
    {

        private MySqlConnection connection;

        public AdmonBDV()
        {
            this.Connect();
        }

        public void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();

            }
        }


        public List<Sales> consultaSinAdministrador()
        {
            List<Sales> dataV = new List<Sales>();
            Sales itemV;
            // int numEmp;
            // string usuario;
            string nombre;
            // string apellido;
            int ventas;

            try
            {
                string query = "SELECT * FROM usuarios WHERE usuario != 'administrador'";
                //string query = "SELECT * FROM usuarios";
                MySqlCommand command = new MySqlCommand(query, this.connection);

                // Ejecutar la consulta y leer los resultados
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                   
                    nombre = Convert.ToString(reader["nombre"]) ?? "";
                    ventas = Convert.ToInt32(reader["venta_usuario"]);


                    itemV = new Sales(nombre, ventas);
                    dataV.Add(itemV);

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer la tabla de la base de datos: " + ex.Message);
                this.Disconnect();
            }
            return dataV;

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

        public void ActualizarVentasAdministrador()
        {
            try
            {
                // Consulta SQL para sumar las ventas y actualizar el usuario administrador
                //hace la suma de todos menos el administrador
                string query = @"
            UPDATE usuarios
            SET venta_usuario = (
                SELECT SUM(venta_usuario)
                FROM usuarios
                WHERE usuario != 'administrador'
            )
            WHERE usuario = 'administrador';";

                // Ejecutar la consulta
                MySqlCommand command = new MySqlCommand(query, this.connection);
                int filasAfectadas = command.ExecuteNonQuery();

               // MessageBox.Show($"Ventas del administrador actualizadas correctamente. Filas afectadas: {filasAfectadas}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar las ventas del administrador: " + ex.Message);
            }


        }

        public int ObtenerVentasAdministrador() //para mostrar la cantidad de administrador
        {
            int ventasAdministrador = 0;
            try
            {
                string query = "SELECT venta_usuario FROM usuarios WHERE usuario = 'administrador'";
                MySqlCommand command = new MySqlCommand(query, this.connection);
                ventasAdministrador = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener las ventas del administrador: " + ex.Message);
            }
            return ventasAdministrador;
        }



    }
    
    }

