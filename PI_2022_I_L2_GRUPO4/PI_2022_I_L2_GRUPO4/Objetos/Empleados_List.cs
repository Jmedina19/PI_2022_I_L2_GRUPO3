using PI_2022_I_L2_GRUPO3.Objetos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_GRUPO4.Objetos
{
    internal class Empleados_List
    {
 
        public List<Empleado> empleadosList { get; set; }

        public Empleados_List()
        {
            empleadosList = new List<Empleado>();
        }
        public void Add(Empleado pEmpleado)
        {
            empleadosList.Add(pEmpleado);
        }
        public Empleado Search(string pId)
        {
            if (empleadosList == null)
            {
                return null;
            }
            foreach (var empleado in empleadosList)
            {
                if (empleado.Id == pId)
                {
                    return empleado;
                }
            }
            return null;
        }

        public void Delet(string pId)
        {
            foreach (var empleado in empleadosList)
            {
                if (empleado.Id == pId)
                {
                    empleadosList.Remove(empleado);
                }
            }

        }

        public Empleado Update(Empleado pEmpleado)
        {
            if (empleadosList == null)
            {
                return null;
            }
            foreach (var empleado in empleadosList)
            {
                if (empleado.Id == pEmpleado.Id)
                {
                    empleado.Nombre         = pEmpleado.Nombre;
                    empleado.Apellido       = pEmpleado.Apellido;
                    empleado.Id             = pEmpleado.Id;
                    empleado.Email          = pEmpleado.Email;
                    empleado.NumeroTelefono = pEmpleado.NumeroTelefono;
                    empleado.SalarioMensual = pEmpleado.SalarioMensual;
                    return empleado;
                }
            }
            return null;
        }

        /*private void AgregarEmpleado()
         {
             Empleados_List empel = JsonConvert.DeserializeObject<ClientesList>(jsontxt3);
             Empleados empleadosnew  = new Empleados(Nombre, Apellido, Id, Email, NumeroTelefono);
             try
             {
                 WriteLine("Ingrese el Id: ");
                 var id = ReadLine();
                 var empleadosSearch = empleadosList != null ? empleadosList.Search(id) : null;
                 if (empleadosSearch == null)
                 {
                     empleadosnew.Id = id;
                     WriteLine("Ingrese el Nombre:");
                     empleadosnew.Nombre = ReadLine();
                     WriteLine("Ingrese el Apellido:");
                     empleadosnew.Apellido = ReadLine();
                     WriteLine("Ingrese el Id:");
                     empleadosnew.Id = ReadLine();
                     WriteLine("Ingrese el Numero de Telefono:");
                     empleadosnew.NumeroTelefono = ReadLine();
                     WriteLine("Ingrese el Email:");
                     empleadosnew.Email = ReadLine();
                     empleadosnew.Add(empleadosnew);
                     jsontxt1 = JsonConvert.SerializeObject(empleadosList, Formatting.Indented);
                     File.WriteAllText(FILENAME, jsontxt1);
                     WriteLine("Nuevo Empleado se ha Guardado Exitosamente");

                 }
                 else
                 {
                     WriteLine("Id de Empleado incorrecto,Intente de nuevo ");
                     AgregarEmpleado();
                 }
             }
             catch (Exception)
             {

                 throw;
             }
         }
         public void EliminarEmpleado()
         {

             try
             {
                 WriteLine("Ingrese el Id: ");
                 var id = ReadLine();
                 var empleadosSearch = empleadosList.Search(id);
                 if (empleadosSearch != null)
                 {

                     empleadoslist.Delet(id);
                     jsontxt2 = JsonConvert.SerializeObject(juegoslist, Formatting.Indented);
                     File.WriteAllText(FILENAME3, jsontxt2);
                     WriteLine("El Empleado ha sido Borrado Exitosamente");

                 }
                 else
                 {
                     WriteLine("Id de Empleado incorrecto,Intente de nuevo ");
                     EliminarCliente();
                 }
             }
             catch (Exception)
             {

                 throw;
             }
         }
        public void BuscarEmpleado()
         {

             try
             {
                 bool Found = false;
                 WriteLine("Ingrese el Id: ");
                 var id = ReadLine();
                 var empleadosSearch = empleadosList.Search(id);//!= null ? .Search(id) : null;
                 if (empleadosSearch == null)
                 {

                     WriteLine("Empleado Existentes");
                     foreach (var empleadosSearch in empleadosList.empleadoslist)
                     {
                         if (empleado.Id == id)
                         {
                            WriteLine($"Nombre del Empleado:\n {Nombre} {Apellido}");
                            WriteLine($"Id del Empleado:\n {Id}");
                            WriteLine($"Numero Telefonico de la empresa:\n {NumeroTelefono}");
                            WriteLine($"Email de la empresa:\n {Email}");
                            WriteLine("");
                         }
                        
                     }
                     if (Found)
                     {
                         WriteLine("Satisfactorio");
                     }
                     else
                     {
                         WriteLine("No se ha encontrado el Empleado ");

                     }
                 }
                 else
                 {
                     WriteLine("Datos de Empleado vacios");

                 }


             }

             catch (Exception)
             {

                 throw;
             }
         }*/
    }
}
