using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApplication6.objetos.Productos;

namespace ConsoleApplication6.objetos
{
    internal class Libro : Producto
    {
        public Libro(string titulo, double precio, double costo)
           : base(titulo, precio, costo)
        {

        }

        public override string imprimirDatos()
        {
            return "Libro: " + nombreProducto + ", Precio: " + precioVenta;
        }
    }
}
