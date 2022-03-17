using PI_2022_I_L2_GRUPO4.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_GRUPO3.Objetos
{
    internal class Empleado:Ca_Datos_Generales
    {

        public Empleado(string pNombre, string pApellido, string pId, string pEmail,
            string pNumeroTelefono)
            : base(pNombre, pApellido, pId, pEmail, pNumeroTelefono)
        {

        }

        public override string ToString() =>
           $"Datos del Empleado que lo atendera :\n" +
           $"\n{base.ToString()}";
    }
}
