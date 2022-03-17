using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6.objetos
{
    internal abstract class Productos
    {
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreProducto;

        public Productos(string nombre, double precio, double costo)
        {
            nombreProducto = nombre;
            costoFabrica = costo;
            precioVenta = precio;
        }

        public abstract string imprimirDatos();
    }
}

    

