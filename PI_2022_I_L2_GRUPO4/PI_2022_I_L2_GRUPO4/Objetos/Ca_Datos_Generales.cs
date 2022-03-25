using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_GRUPO4.Objetos
{
    internal abstract class Ca_Datos_Generales
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Id { get; set; }
        public string Email { get; set; }
        public string NumeroTelefono { get; set; }

        public Ca_Datos_Generales(string pNombre, string pApellido, string pId,
            string pEmail, string pNumeroTelefono)
        {
            Nombre         = pNombre;
            Apellido       = pApellido;
            Id             = pId;
            Email          = pEmail;
            NumeroTelefono = pNumeroTelefono;
        }

        public override string ToString() =>
            $"Nombre: {Nombre} {Apellido}\n" +
            $"Numero de Identificacion: {Id}\n" +
            $"Email: {Email}\n" +
            $"Numero Tefonico: {NumeroTelefono}\n";
    }
}
