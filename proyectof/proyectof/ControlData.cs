using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectof
{
    //Clase para guardar las ventas que se hayan realizado para pasar la info al ticket
    public class ControlData
    {
        public int IdVentaProd {  get; set; }//id unico de venta de ese producto
        public int IdVentaGenerada {  get; set; }//id de la venta que se generó con todos los productos
        public int IdProd {  get; set; }
        public string Nombre {  get; set; }
        public int Cantidad { get; set; }
        public decimal TotalProducto { get; set; } // Total por producto (cantidad * precio)
    }
}
