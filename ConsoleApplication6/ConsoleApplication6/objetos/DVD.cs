using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.objetos
{
    internal class DVD:Productos
    {
        public DVD(string titulo, double precio, double costo)
          : base(titulo, precio, costo)
        {

        }
        public override string imprimirDatos()
        {
            return "DVD: " + nombreProducto + " Precio: " + precioVenta;
        }
    }
}
