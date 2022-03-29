using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2022_I_L2_GRUPO4.Objetos
{
    internal abstract class Ca_Datos_Generales
    {
        //public string Nombre { get; set; }
        
        //public string Apellido { get; set; }
        //public string Id { get; set; }
        //public string Email { get; set; }
        //public string NumeroTelefono { get; set; }

        private string nombre;
        private string apellido;
        private string id;
        private string email;
        private string numerotelefono;

        public Ca_Datos_Generales(string pNombre, string pApellido, string pId,
            string pEmail, string pNumeroTelefono)
        {
            Nombre         = pNombre;
            Apellido       = pApellido;
            Id             = pId;
            Email          = pEmail;
            NumeroTelefono = pNumeroTelefono;
        }

        public string Nombre
        {
            get { return  nombre; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Nombre)} debe colocar los datos solicitados");

                }
                nombre = value;
            }
        }
        public string Apellido
        {
            get { return apellido; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Apellido)} debe colocar los datos solicitados");

                }
                apellido = value; 
            }
        }

        public string Id
        {
            get { return id; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Id)} debe colocar los datos solicitados");

                }
                id = value;
            }
        }

        public string Email
        {
            get { return email; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(Email)} debe colocar los datos solicitados");

                }
                email = value;
            }
        }

        public string NumeroTelefono
        {
            get { return numerotelefono; }
            set 
            {
                if (value == "")
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(NumeroTelefono)} debe colocar los datos solicitados");

                }
                numerotelefono = value; 
            }
        }


        public override string ToString() =>
            $"Nombre: {Nombre} {Apellido}\n" +
            $"Numero de Identificacion: {Id}\n" +
            $"Email: {Email}\n" +
            $"Numero Tefonico: {NumeroTelefono}\n";
    }
}
