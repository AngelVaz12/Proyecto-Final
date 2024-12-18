using MySql.Data.MySqlClient;

namespace proyectof
{
    internal class Modelo
    {
        public Usuarios validaUsuario(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=dataBaseProyecto;Uid=root;Pwd=;");
            conexion.Open();

            string sql = "SELECT numEmp, usuario, password, nombre, apellido FROM usuarios WHERE  usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();
            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();

                usr.NumEmp = int.Parse(reader["numEmp"].ToString());
                usr.Usuario = reader["usuario"].ToString();
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();
                usr.Apellido = reader["apellido"].ToString();


            }
            return usr;
        }
    }
}
