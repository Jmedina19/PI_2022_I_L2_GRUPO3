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
        protected decimal salariomensual;

        public Empleado(string pNombre, string pApellido, string pId, string pEmail,
            string pNumeroTelefono, decimal pSalarioMensual)
            : base(pNombre, pApellido, pId, pEmail, pNumeroTelefono)
        {
            salariomensual = pSalarioMensual;
        }
        public decimal SalarioMensual
        {
            get { return salariomensual; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(SalarioMensual)} deberia ser >=0 ");
                }
                salariomensual = value;
            }
        }

        public override string ToString() =>
           $"Datos del Empleado que lo atendera :\n" +
           $"{base.ToString()}" +
            $"El salario menusla es: {SalarioMensual}";
    }
}
