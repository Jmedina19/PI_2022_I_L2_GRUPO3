using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_GRUPO3.Objetos
{
    internal class Juegos
    {
        public Juegos(string pNombreGame, string pCodigoGame, string pDescripcionGame,
           decimal pPricegame) ///*, decimal pSubTotal*/)
        {
            NombreGame      = pNombreGame;
            CodigoGame      = pCodigoGame;
            DescripcionGame = pDescripcionGame;
            PriceGame       = pPricegame;
           // CantidadGame    = pCantidadGame;
         //   SubTotal        = pSubTotal;
        }
                  
        public string NombreGame { get;}
        public string CodigoGame { get;}
        public string DescripcionGame { get;}
        protected decimal pricegame;
       // ;
        //private decimal subtotal;

        public decimal PriceGame
        {
            get { return pricegame; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(PriceGame)} deberia ser >=0 ");
                }
                pricegame = value; 
            }
        }
       /**/
       /* public decimal SubTotal
        {
            get { return subtotal; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(SubTotal)} deberia ser >=0 ");
                }
                subtotal = value;
            }
        }*/

        public virtual decimal CalcularSubtotal() => PriceGame ;
        //public virtual decimal CalcularTotal() => PriceGame;
        //public virtual decimal CalcularDescuento() => PriceGame;


        public override string ToString() =>
          $"El Nombre del juego es:\n {NombreGame}\n" +
           $"El Codigo del Juegos es:\n {CodigoGame}\n" +
           $"La Descripcion del juegos es:\n {DescripcionGame}\n" +
           $"El Precio del juego es:\n {PriceGame:c}";
          

    }
}
