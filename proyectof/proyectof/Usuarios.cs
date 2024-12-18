namespace proyectof
{
    internal class Usuarios
    {
        int numEmp;
        string usuario, password, nombre, apellido;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        public int NumEmp { get => numEmp; set => numEmp = value; }
    }
}
