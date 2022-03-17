using PI_2022_I_L2_GRUPO3.Objetos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PI_2022_I_L2_GRUPO4.Objetos
{
    internal class ClientesList
    {
       // const string FILENAME = @"C:\Users\Bessy Almendares\Desktop\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\bin\Debug\ClientesList.json";
       
       // static ClientesList clientesList = new ClientesList();
       // static string jsontxt1 = "";
        //        string Nombre, Apellido, Id, Email,
        //        NumeroTelefono;
       
        public List<Clientes> Clienteslist { get; set; }

        public ClientesList()
        {
            Clienteslist = new List<Clientes>();
        }
        public void Add(Clientes pclientes)
        {
            Clienteslist.Add(pclientes);
        }
        public Clientes Search(string pId ) 
        {
            if (Clienteslist == null)
            {
                return null;
            }
            foreach (var clientes in Clienteslist)
            {
                if (clientes.Id== pId)
                {
                    return clientes;
                }  
            }
            return null;
        }
        public void Delet(string pId)
        {
            foreach (var clientes in Clienteslist)
            {
                if (clientes.Id == pId)
                {
                    Clienteslist.Remove(clientes);
                }
                
            }
        }
        /*public void AgregarCliente()
        {
            var clientesnew = new Clientes(Nombre, Apellido, Id, Email, NumeroTelefono);
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var clienteSearch = clientesList != null ? clientesList.Search(id) : null;
                if (clienteSearch == null)
                {
                    clientesnew.Id = id;
                    WriteLine("Ingrese el Nombre:");
                    clientesnew.Nombre = ReadLine();
                    WriteLine("Ingrese el Apellido:");
                    clientesnew.Apellido = ReadLine();
                    WriteLine("Ingrese el Id:");
                    clientesnew.Id = ReadLine();
                    WriteLine("Ingrese el Numero de Telefono:");
                    clientesnew.NumeroTelefono = ReadLine();
                    WriteLine("Ingrese el Email:");
                    clientesnew.Email = ReadLine();
                    clientesList.Add(clientesnew);
                    jsontxt1 = JsonConvert.SerializeObject(clientesList, Formatting.Indented);
                    File.WriteAllText(FILENAME, jsontxt1);
                    WriteLine("Nuevo Cliente Guardado Exitosamente");

                }
                else
                {
                    WriteLine("Id de Cliente incorrecto,Intente de nuevo ");
                    AgregarCliente();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EliminarCliente()
        {

            try
            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var clienteSearch = clientesList.Search(id);
                if (clienteSearch != null)
                {

                    clientesList.Delet(id);
                    jsontxt1 = JsonConvert.SerializeObject(clientesList, Formatting.Indented);
                    File.WriteAllText(FILENAME, jsontxt1);
                    WriteLine("El Cliente ha sido Borrado Exitosamente");

                }
                else
                {
                    WriteLine("Id de Cliente incorrecto,Intente de nuevo ");
                    EliminarCliente();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void BuscarCliente()
        {

            try
            {
                bool Found = false;
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var clienteSearch = clientesList.Search(id);
                if (clienteSearch == null)
                {

                    WriteLine("Clientes Existentes");
                    foreach (var cliente in clientesList.clienteslist)
                    {
                        if (cliente.Id == id)
                        {

                        }
                        WriteLine($"Nombre del cliente:\n {Nombre} {Apellido}");
                        WriteLine($"Id del cliente:\n {Id}");
                        WriteLine($"Numero Telefonico del cliente:\n {NumeroTelefono}");
                        WriteLine($"Email del client:\n {Email}");
                        WriteLine("");
                    }
                    if (Found)
                    {
                        WriteLine("Satisfactorio");
                    }
                    else
                    {
                        WriteLine("No se ha encontrado el Cliente ");

                    }
                }
                else
                {
                    WriteLine("Datos de Cliente vacios");

                }


            }

            catch (Exception)
            {

                throw;
            }
        }
        public void ListarCliente()
        {

            try
            {

                if (clientesList != null)
                {

                    WriteLine("Clientes Existentes");
                    foreach (var cliente in clientesList.clienteslist)
                    {
                        WriteLine($"Nombre del cliente:\n {Nombre} {Apellido}");
                        WriteLine($"Id del cliente:\n {Id}");
                        WriteLine($"Numero Telefonico del cliente:\n {NumeroTelefono}");
                        WriteLine($"Email del client:\n {Email}");
                        WriteLine("");
                    }
                    WriteLine("Se han Listados los Clientes en existencia Exitosamente");

                }
                else
                {
                    WriteLine("Id de Cliente incorrecto,Intente de nuevo ");
                    ListarCliente();
                }
            }
            catch (Exception)
            {

                throw;
            }*/
        
    }
}
