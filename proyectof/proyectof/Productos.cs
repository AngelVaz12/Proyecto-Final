using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectof
{
    public class Productos
    {
        private int id;
        private string producto;
        private int precio;
        private int cantidad;
        private string imagen;

        public Productos()
        {

        }

        public Productos(int id, string producto, int precio, int cantidad, string imagen)
        {
            this.id = id;
            this.producto = producto;
            this.precio = precio;
            this.cantidad = cantidad;
            this.imagen = imagen;
        }

        public int Id { get => id; set => id = value; }
        public string Producto { get => producto; set => producto = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Imagen { get => imagen; set => imagen = value; }
    }
    

    
 }
