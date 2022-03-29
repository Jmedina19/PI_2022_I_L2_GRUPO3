using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_E2_Javier_Medina.Objetos
{
    internal class Cliente : Ca_Datos_Generales
    {
        public string Categoria { get;}
        public Cliente(string pNombre, string pApellido, string pId,string pCategoria) 
            : base(pNombre, pApellido, pId)
        {
            Categoria = pCategoria;
        }

        public override string ToString() =>
            $"Datos de Cliente" +
            $"{base.ToString()}" +
            $"La Categoria del Cliente es:\n {Categoria}";
        public void Imprimir()
        { 

        }
    }
}
