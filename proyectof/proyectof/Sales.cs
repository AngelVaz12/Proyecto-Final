using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectof
{
    public class Sales
    {
        //private int numEmp;
       // private string usuario;
        private string nombre;
       // private string apellido;
        private int ventas;

        public Sales()
        {

        }

        public Sales(string nombre, int ventas)
        {
           
            this.nombre = nombre;
           
            this.ventas = ventas;
        }

       
        public string Nombre { get => nombre; set => nombre = value; }
      
        public int Ventas { get => ventas; set => ventas = value; }
    }
}
