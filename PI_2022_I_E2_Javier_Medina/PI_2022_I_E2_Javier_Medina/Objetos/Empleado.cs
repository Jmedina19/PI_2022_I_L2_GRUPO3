using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_E2_Javier_Medina.Objetos
{
    internal class Empleado:Ca_Datos_Generales
    {
        public string Puesto { get; }
        public Empleado(string pNombre, string pApellido, string pId, string pPuesto) 
            : base(pNombre, pApellido, pId)
        {
            Puesto = pNombre;
        }
        public override string ToString() =>
            $"Datos Empleado" +
            $"{base.ToString()}" +
            $"El Puesto de Empleado es:\n {Puesto}";




    }
}
