using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_GRUPO4.Objetos
{
    internal abstract class ClaseAbstracta
    {
        public string Nombre { get; }
        public string Apellido { get; }
        public string Id { get; }
        public string Email { get; }
        public string NumeroTelefono { get; }

        public ClaseAbstracta(string pNombre, string pApellido, string pId,
            string pEmail, string pNumeroTelefono)
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Id = pId;
            Email = pEmail;
            NumeroTelefono = pNumeroTelefono;
        }
        public  override string ToString() =>
            
            $"Nombre: {Nombre} {Apellido}\n" +
            $"Numero de Identidad: {Id}\n" +
            $"Email: {Email}\n" +
            $"Numero Tefonico: {NumeroTelefono}\n";
    }
}
