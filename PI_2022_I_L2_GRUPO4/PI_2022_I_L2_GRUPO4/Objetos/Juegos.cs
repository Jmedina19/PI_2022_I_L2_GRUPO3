﻿using PI_2022_I_L2_GRUPO4.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_GRUPO3.Objetos
{
    internal class Juegos:ClaseAbstracta
    {

        public string NombreGame { get; set; }
        public string DescripcionGame { get; set; }
        public string CodigoGame { get; set; }
        protected decimal pricegame;


        public Juegos(string pNombre, string pApellido, string pId, string pEmail, string pNumeroTelefono
            , string pNombreGame, string pDescripcionGame, string pCodigoGame, decimal pPriceGame)
            : base(pNombre, pApellido, pId, pEmail, pNumeroTelefono)
        {
            DescripcionGame = pDescripcionGame;
            PriceGame       = pPriceGame;
            NombreGame      = pNombreGame;
            CodigoGame      = pCodigoGame;
        }

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


        public virtual decimal CalcularSubtotal() => PriceGame ;



        public override string ToString() =>
            
            $"El Nombre del juego es:\n {NombreGame}\n" +
            $"El Codigo del Juegos es:\n {CodigoGame}\n" +
            $"La Descripcion del juegos es:\n {DescripcionGame}\n" +
            $"El Precio del juego es:\n {PriceGame:c}\n"+
            $"Nombre del Autor:\n {Nombre} {Apellido}\n" +
            $"Numero de Identificacion:\n {Id}\n" +
            $"Email de la empresa:\n {Email}\n" +
            $"Numero Tefonico de la empresa:\n {NumeroTelefono}";


    
    }
}
