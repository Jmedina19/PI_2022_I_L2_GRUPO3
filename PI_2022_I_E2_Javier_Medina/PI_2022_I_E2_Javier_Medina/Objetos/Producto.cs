using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_E2_Javier_Medina.Objetos
{
    internal class Producto
    {
        public string Producto1;
        public string Producto2;
        private decimal cantidadcompra;
        private decimal precio1;
        private decimal  precio2;


        public Producto(decimal pPrecio1, decimal pPrecio2, string pProducto1, string pProducto2)
        {
            Precio1   = pPrecio1;
            Precio2   = pPrecio2;
            Producto1 = pProducto1;
            Producto2 = pProducto2;
        }

        public decimal Precio1
        {
            get { return precio1; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                 value, $"{nameof(Precio1)} deberia ser >=0 ");
                }
                precio1 = value;
            }
        }

        public decimal Precio2
        {
            get { return precio2; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                 value, $"{nameof(Precio2)} deberia ser >=0 ");
                }
                precio2 = value; 
            }
        }


        public decimal CantidadCompra
        {
            get { return cantidadcompra; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                 value, $"{nameof(CantidadCompra)} deberia ser >=0 ");
                }
                cantidadcompra = value;
            }
        }
        public override string ToString() =>
            $"Datos de producto 1 y 2" +
             $"El nomnre del producto#1 es:\n {Producto1}" +
             $"El precio es: {Precio1}" +
             $"El nomnre del producto#2 es:\n {Producto2}" +
             $"El precio es: {Precio2}";
             
    }
}
