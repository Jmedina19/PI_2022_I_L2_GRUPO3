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
        const string FILENAME = @"C:\Users\Bessy Almendares\Desktop\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\bin\Debug\ClientesList.json";

        public List<Clientes> clientesList { get; set; }

        public ClientesList()
        {
            clientesList = new List<Clientes>();
        }
        public void Add(Clientes pclientes)
        {
            clientesList.Add(pclientes);
        }
        public Clientes Search(string pId)
        {
            if (clientesList == null)
            {
                return null;
            }
            foreach (var clientes in clientesList)
            {
                if (clientes.Id == pId)
                {
                    return clientes;
                }
            }
            return null;
        }
        public void Delet(string pId)
        {
            foreach (var clientes in clientesList)
            {
                if (clientes.Id == pId)
                {
                    clientesList.Remove(clientes);
                }

            }
        }
        public Clientes Update(Clientes pclientes)
        {
            if (clientesList == null)
            {
                return null;
            }
            foreach (var clientes in clientesList)
            {
                if (clientes.Id == pclientes.Id)
                {
                    clientes.Nombre = pclientes.Nombre;
                    clientes.Apellido = pclientes.Apellido;
                    clientes.Id = pclientes.Id;
                    clientes.Email = pclientes.Email;
                    clientes.NumeroTelefono = pclientes.NumeroTelefono;
                    return clientes;
                }
            }
            return null;
        }
        /*public void AgregarCliente()
        {
            int producto = 6;
            ClientesList clientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
            Clientes clientesnew = new Clientes(Nombre, Apellido, Id, Email, NumeroTelefono);
            do
            {
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
                WriteLine("Si desea seguir agregando clientes, Teclee 1 de lo contratio tecleo otro numero");
                producto = int.Parse(ReadLine());
            } while (producto != 6);

        }
        public void EliminarCliente()
        {

            try
            {
                ClientesList clientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var clienteSearch = clientesList.Search(id);//!= null ? .Search(id) : null;
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
                ClientesList clientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
                bool Found = false;
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var clienteSearch = clientesList.Search(id);
                if (clienteSearch != null)
                {

                    WriteLine("Clientes Existentes");
                    foreach (var cliente in clientesList.clientesList)
                    {
                        if (cliente.Id == id)
                        {
                            WriteLine($"Nombre del cliente:\n {cliente.Nombre} {cliente.Apellido}");
                            WriteLine($"Id del cliente:\n {cliente.Id}");
                            WriteLine($"Numero Telefonico del cliente:\n {cliente.NumeroTelefono}");
                            WriteLine($"Email del client:\n {cliente.Email}");
                            WriteLine("");
                            Found = true;
                        }

                    }
                    if (Found)
                    {
                        WriteLine("Satisfactorio");
                        ReadLine();
                    }
                    else
                    {
                        WriteLine("No se ha encontrado el Cliente ");
                        ReadLine();
                    }
                }
                else
                {
                    WriteLine("Datos de Cliente vacios");
                    ReadLine();
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
                ClientesList clientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
                if (clientesList != null)
                {

                    WriteLine("Clientes Existentes");
                    foreach (var cliente in clientesList.clientesList)
                    {
                        WriteLine($"Nombre del cliente:\n {cliente.Nombre} {cliente.Apellido} ");
                        WriteLine($"Id del cliente:\n {cliente.Id}");
                        WriteLine($"Numero Telefonico del cliente:\n {cliente.NumeroTelefono}");
                        WriteLine($"Email del client:\n {cliente.Email}");
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
            }
        }
        public void ActualizarClientes()
        {
            ClientesList clientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var clienteSearch = clientesList.Search(id);
                if (clienteSearch != null)
                {
                    clienteSearch.Id = id;
                    WriteLine("Nombre del Cliente:");
                    clienteSearch.Nombre = ReadLine();
                    WriteLine("Apellido del Cliente:");
                    clienteSearch.Apellido = ReadLine();
                    WriteLine("Id del Cliente:");
                    clienteSearch.Id = ReadLine();
                    WriteLine("Numero del Cliente:");
                    clienteSearch.NumeroTelefono = ReadLine();
                    WriteLine("Email del Cliente:");
                    clienteSearch.Email = ReadLine(); ;
                    clientesList.Update(clienteSearch);
                    jsontxt1 = JsonConvert.SerializeObject(clientesList, Formatting.Indented);
                    File.WriteAllText(FILENAME, jsontxt1);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("El Codigo del Juego es Incorrecto, Intente de nuevo");
                    ActualizarClientes();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }*/
    }
}
