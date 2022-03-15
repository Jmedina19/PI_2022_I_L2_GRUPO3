using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_GRUPO3.Objetos
{
    internal class Factura : Juegos
    {
        private decimal isv;
        private decimal descuento;
        private int cantidadgame;
        //private decimal totalpagar;
        public Factura(string pNombreGame, string pCodigoGame, string pDescripcionGame,
            decimal pPricegame, decimal pISV, decimal pDescuento, int pCantidadGame)
            : base(pNombreGame, pCodigoGame, pDescripcionGame, pPricegame)
        {
            ISV          = pISV;
            Descuento    = pDescuento;
            CantidadGame = pCantidadGame;
        }

        public decimal ISV
        {
            get { return isv; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(ISV)} deberia ser >=0 ");
                }
                isv = value;
            }
        }
        
        public decimal Descuento
        {
            get { return descuento; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Descuento)} deberia ser >=0 ");
                }
                descuento = value; 
            }
        }
        public int CantidadGame
        {
            get { return cantidadgame; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(CantidadGame)} deberia ser > 0 ");
                }
                cantidadgame = value;
            }
        }

        /*public decimal TotalPagar
        {
            get { return totalpagar; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(TotalPagar)} deberia ser >=0 ");
                }
                totalpagar = value; 
            }
        }
        */

        public override decimal CalcularSubtotal() => CantidadGame * pricegame;
        public virtual decimal CalcularDescuento() => Descuento * CalcularSubtotal();
        public virtual decimal CalcularISV() => CalcularSubtotal() * ISV;
        public virtual decimal CalcularTotal() => (CalcularSubtotal() + CalcularISV()) - CalcularDescuento();

        public override string ToString() =>
           $"{base.ToString()}\n" +
           $"La Cantidad de juegos es:\n {CantidadGame}\n" +
           $"El Descuento es:\n {Descuento:c}\n" +
           $"El ISV es:\n {ISV:c}\n";
          // $"El Sub total es:\n {CalcularSubtotal():c}\n";
           



    }
}
