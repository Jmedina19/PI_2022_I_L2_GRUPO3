using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_E2_Javier_Medina.Objetos
{
    internal abstract class Ca_Datos_Generales
    {
        public string Nombre { get;}
        public string Apellido { get;}
        public string  Id { get;}

        public Ca_Datos_Generales(string pNombre, string pApellido, string pId)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Id = pId;
        }
        public override string ToString() =>
            $"Nombre:\n {Nombre}" +
            $"Apellido:\n {Apellido}" +
            $"Id:\n {Id}";

    }
}
