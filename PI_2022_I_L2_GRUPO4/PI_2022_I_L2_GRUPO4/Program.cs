using Newtonsoft.Json;
using PI_2022_I_L2_GRUPO3.Objetos;
using PI_2022_I_L2_GRUPO4.Objetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_GRUPO3
{
    internal class Program
    {
        // Cambien la direccion del Filename que se encuentra en la carpeta bin y coloque el de su computadora para ambos casos
        const string FILENAME = @"C:\Users\Bessy Almendares\Desktop\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\bin\Debug\ClientesList.json";
        const string FILENAME2 = @"C:\Users\Bessy Almendares\Desktop\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\bin\Debug\JuegosList.json";
        const string FILENAME3 = @"C:\Users\Bessy Almendares\Desktop\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\bin\Debug\Empleados_List.json";
        static ClientesList clientesList = new ClientesList();
        static JuegosList juegosList = new JuegosList();
        static Empleados_List empleadoslist = new Empleados_List();
        static string jsontxt1 = "";
        static string jsontxt2 = "";
        static string jsontxt3 = "";
        string Nombre, Apellido, Id, Email,
        NumeroTelefono;
        string Nombreautor, Apellidoautor, Idautor, Emailempresa,
               NumeroTelefonoempresa, NombreGame, DescripcionGame,
               CodigoGame;
        decimal PriceGame, SalarioMensual;


        static void Main(string[] args)
        {

            
            jsontxt1 = File.ReadAllText(FILENAME);
            jsontxt2 = File.ReadAllText(FILENAME2);
            jsontxt2 = File.ReadAllText(FILENAME3);
            ClientesList clientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
            JuegosList JuegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
            Empleados_List empleadosList = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleados_List>(jsontxt3);
            Program objectProgram = new Program();
            char seguir = 'N';
            bool menu1 = true, menu2 = true, menu3 = true, menu4 = true;
            string Nombre, Apellido, Id, Email, NumeroTelefono;
            int cantidadjuegoscompra1 = 0;
            

            do
            {
                WriteLine("Elija una opcion y precione enter\n" + "\n1) - Menu Administrativo de los clientes" +
                "\n2) - Menu Administrativo de Juegos" + "\n3) - Menu Administrativo de los Empleados" + "\n4) - Ver inventario de juegos" + "\n5) - Comprar juego" + "\n6) - Salir");
                var opcion = ReadLine();
                switch (opcion)
                {
                    case "1":
                        Clear();
                        do

                        {   WriteLine("Elija una opcion y precione enter\n" + "\n1) - Agregar" + "\n2) - Buscar" +
                                  "\n3) - Eliminar " + "\n4) - Listar " + "\n5) - Actualizar Clientes " + "\n6) Regresar");
                            var opcion2 = ReadLine();
                        
                        
                            switch (opcion2)
                            {
                                case "1":
                                    Clear();
                                    objectProgram.AgregarCliente();
                                    break;
                                case "2":
                                    Clear();
                                    objectProgram.BuscarCliente();
                                    break;
                                case "3":
                                    Clear();
                                    objectProgram.EliminarCliente();
                                    break;
                                case "4":
                                    Clear();
                                    objectProgram.ListarCliente();
                                    break;
                                case "5":
                                    objectProgram.ActualizarClientes();
                                    break;
                                case "6":
                                    menu1 = false;
                                    break;
                                default:
                                    Main(null);
                                    break;
                            }

                        } while (menu1 == true);
                        ReadLine();
                        break;
                    case "2":
                        Clear();
                        do
                        {  WriteLine("Elija una opcion y precione enter\n" + "\n1) - Agregar" + "\n2) - Buscar" +
                                  "\n3) - Eliminar " + "\n4) - Listar" + "\n5) - Actualizar Clientes " + "\n6) Regresar");
                           var opcion3 = ReadLine();
                       
                        
                            switch (opcion3)
                            {
                                case "1":
                                    objectProgram.AgregarJuegos();
                                    break;
                                case "2":
                                    objectProgram.BuscarJuegos();
                                    break;
                                case "3":
                                    objectProgram.EliminarJuegos();
                                    break;
                                case "4":
                                    objectProgram.ListarJuegos();
                                    break;
                                case "5":
                                    objectProgram.ActualizarJuegos();
                                    break;
                                case "6":
                                    menu2 = false;
                                    break;
                                default:
                                    Main(null);
                                    break;
                            }

                        } while (menu2 == true);
                        break;
                    case "3":
                        Clear();
                        do
                        {  WriteLine("Elija una opcion y precione enter\n" + "\n1) - Agregar Empleado" + "\n2) - Buscar Empleado" +
                                 "\n3) - Eliminar Empleado" + "\n4) - Listar Empleados" + "\n5) - Actualizar Empleado" + "\n6) - Regresar");
                           var opcion4 = ReadLine();

                            switch (opcion4)
                            {
                                case "1":
                                    objectProgram.AgregarEmpleado();     
                                    break;
                                case "2":
                                    objectProgram.BuscarEmpleado();
                                    break;
                                case "3":
                                    objectProgram.EliminarEmpleado();
                                    break;
                                case "4":
                                    objectProgram.ListarEmpleado();
                                    break;
                                case "5":
                                    objectProgram.ActualizarJuegos();
                                    break;
                                case "6":
                                    menu2 = false;
                                    break;
                                default:
                                    Main(null);
                                    break;
                            }

                        } while (menu2 == true);
                        break;
                    case "4":
                        Clear();

                        do
                        {
                            WriteLine("Tenemos en existencia los sigientes juegos");
                            objectProgram.ListarJuegos();
                            ReadLine();
                            menu3 = false;
                        } while (menu3 == true);
                        break;
                    case "5":
                        Clear();
                        WriteLine($"Que Juego desea comprar ");
                        var opcion5 = ReadLine();
                        switch (opcion5)
                        {
                            case "1":
                                Clear();
                                do
                                {
                                    WriteLine("Ingrese la cantidad de este juego que desea comprar ");
                                    cantidadjuegoscompra1 = int.Parse(ReadLine());
                                } while (cantidadjuegoscompra1 == 0);
                                var Factura1 = new Factura("Steve", "Fudoka", "1357-9024-68014", "activision@gmail.com", "48372604", "Este Juego es uno de los mejores juegos multijugador " +
                                "en primera persona shooter", 145.14M, "Call of Duty", "2235-4956", 0.15M, 0.05M, cantidadjuegoscompra1);
                                do
                                {


                                    WriteLine(Factura1.ToString());
                                    WriteLine($"El Subtotal es: {Factura1.CalcularSubtotal():c}");
                                    WriteLine($"El Descuento por su compra es: {Factura1.CalcularDescuento():c}");
                                    WriteLine($"El ISV de su compre es {Factura1.CalcularISV():c}");
                                    WriteLine($"El Total a pagar por su compra es: {Factura1.CalcularTotal():c}");
                                    WriteLine("Muchas gracias por su compra");
                                    menu4 = false;


                                } while (menu4 == true);
                                break;
                        }
                        break;
                }
            } while (seguir.ToString().ToUpper() == "S");
        }
        private void AgregarCliente()
        {
            //int producto = 0;
            ClientesList ClientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
            var clientesnew = new Clientes(Nombre, Apellido, Id, Email, NumeroTelefono);
            //do
            //{
                try
                {
                    WriteLine("Ingrese el Id: ");
                    var id = ReadLine();
                    var clienteSearch = ClientesList != null ? ClientesList.Search(id) : null;
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
             //   WriteLine("Si desea seguir agregando clientes, Teclee 1 de lo contratio tecleo otro numero");
              //  producto = int.Parse(ReadLine());
           // } while ( producto != 6);
            
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
        void BuscarCliente()
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
        void ListarCliente()
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
                    clienteSearch.Email = ReadLine();;
                    clientesList.Update(clienteSearch);
                    jsontxt1 = JsonConvert.SerializeObject(clientesList, Formatting.Indented);
                    File.WriteAllText(FILENAME, jsontxt1);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("El Id del cliente es Incorrecto, Intente de nuevo");
                    ActualizarClientes();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AgregarJuegos()
        {
            var juegosnew = new Juegos(Nombreautor, Apellidoautor, Idautor, Emailempresa, NumeroTelefonoempresa, NombreGame, DescripcionGame,
                CodigoGame, PriceGame);
            try
            {
                JuegosList JuegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var juegoSearch = JuegosList != null ? JuegosList.Search(id) : null;
                if (juegoSearch == null)
                {
                    juegosnew.Id = id;
                    WriteLine("Ingrese el Nombre:");
                    juegosnew.Nombre = ReadLine();
                    WriteLine("Ingrese el Apellido:");
                    juegosnew.Apellido = ReadLine();
                    WriteLine("Ingrese el Id:");
                    juegosnew.Id = ReadLine();
                    WriteLine("Ingrese el Numero de Telefono:");
                    juegosnew.NumeroTelefono = ReadLine();
                    WriteLine("Ingrese el Email:");
                    juegosnew.Email = ReadLine();
                    WriteLine("Ingrese el Nombre del Juego:");
                    juegosnew.NombreGame = ReadLine();
                    WriteLine("Ingrese la Descripcion del Juego:");
                    juegosnew.DescripcionGame = ReadLine();
                    WriteLine("Ingrese el Codigo del juego:");
                    juegosnew.CodigoGame = ReadLine();
                    WriteLine("Ingrese el Precio del Juego:");
                    juegosnew.PriceGame = decimal.Parse(ReadLine());
                    juegosList.Add(juegosnew);
                    jsontxt2 = JsonConvert.SerializeObject(juegosList, Formatting.Indented);
                    File.WriteAllText(FILENAME2, jsontxt2);
                    WriteLine("Nuevo Cliente Guardado Exitosamente");

                }
                else
                {
                    WriteLine("Id de Cliente incorrecto,Intente de nuevo ");
                    AgregarJuegos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EliminarJuegos()
        {

            try
            {
                JuegosList JuegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var juegoSearch = JuegosList.Search(id);
                if (juegoSearch != null)
                {

                    juegosList.Delet(id);
                    jsontxt2 = JsonConvert.SerializeObject(JuegosList, Formatting.Indented);
                    File.WriteAllText(FILENAME2, jsontxt2);
                    WriteLine("El Juego ha sido Borrado Exitosamente");

                }
                else
                {
                    WriteLine("Codigo de Juego incorrecto,Intente de nuevo ");
                    EliminarJuegos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void BuscarJuegos()
        {

            try
            {
                JuegosList JuegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
                bool Found = false;
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var juegoSearch = JuegosList.Search(id);//!= null ? .Search(id) : null;
                if (juegoSearch == null)
                {

                    WriteLine("Juegos Existentes");
                    foreach (var juego in JuegosList.Juegoslist)
                    {
                        if (juego.Id == id)
                        {
                            WriteLine($"Nombre del Autor:\n {juego.Nombre} {juego.Apellido}");
                            WriteLine($"Id del Autor:\n {juego.Id}");
                            WriteLine($"Numero Telefonico de la Empresa:\n {juego.NumeroTelefono}");
                            WriteLine($"Email de la Empresa:\n {juego.Email}");
                            WriteLine($"Nombre del Juego:\n {juego.NombreGame} ");
                            WriteLine($"Descripcion de Juego:\n {juego.DescripcionGame}");
                            WriteLine($"Numero Telefonico del cliente:\n {juego.CodigoGame}");
                            WriteLine($"Precio del Juego:\n {juego.PriceGame}");
                            WriteLine("");
                        }

                    }
                    if (Found)
                    {
                        WriteLine("Satisfactorio");
                    }
                    else
                    {
                        WriteLine("No se ha encontrado el Juego ");

                    }
                }
                else
                {
                    WriteLine("Datos de Juego vacios");

                }


            }

            catch (Exception)
            {

                throw;
            }
        }
        public void ListarJuegos()
        {

            try
            {
                JuegosList JuegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
                if (JuegosList != null)
                {

                    WriteLine("Juegos Existentes");
                    foreach (var juego in JuegosList.Juegoslist)
                    {
                        WriteLine($"Nombre del Autor:\n {juego.Nombre} {juego.Apellido}");
                        WriteLine($"Id del Autor:\n {juego.Id}");
                        WriteLine($"Numero Telefonico de la Empresa:\n {juego.NumeroTelefono}");
                        WriteLine($"Email de la Empresa:\n {juego.Email}");
                        WriteLine($"Nombre del Juego:\n {juego.NombreGame}");
                        WriteLine($"Descripcion del Juego:\n {juego.DescripcionGame}");
                        WriteLine($"Codigo del Juego :\n {juego.CodigoGame}");
                        WriteLine($"Precio del Juego:\n {juego.PriceGame}");
                        WriteLine("");
                    }
                    WriteLine("Se han Listados los Juegos en existencia Exitosamente");

                }
                else
                {
                    WriteLine("Codigo del Juegos incorrecto,Intente de nuevo ");
                    ListarJuegos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ActualizarJuegos()
        {
            JuegosList JuegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var juegoSearch = JuegosList.Search(id);
                if (juegoSearch != null)
                {
                    juegoSearch.Id = id;
                    WriteLine("Nombre del Autor:");
                    juegoSearch.Nombre = ReadLine();
                    WriteLine("Apellido del Autor:");
                    juegoSearch.Apellido = ReadLine();
                    WriteLine("Id del Autor:");
                    juegoSearch.Id = ReadLine();
                    WriteLine("Numero de la Empresa:");
                    juegoSearch.NumeroTelefono = ReadLine();
                    WriteLine("Email de la empresa:");
                    juegoSearch.Email = ReadLine();
                    WriteLine("Nombre del Juego");
                    juegoSearch.NombreGame = ReadLine();
                    WriteLine("Descripcion del Juego");
                    juegoSearch.DescripcionGame = ReadLine();
                    WriteLine("Codigo del Juego");
                    juegoSearch.CodigoGame = ReadLine();
                    WriteLine("Precio del Juego");
                    juegoSearch.PriceGame = decimal.Parse(ReadLine());
                    JuegosList.Update(juegoSearch);
                    jsontxt3 = JsonConvert.SerializeObject(JuegosList, Formatting.Indented);
                    File.WriteAllText(FILENAME2, jsontxt2);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("El Codigo del Juego es Incorrecto, Intente de nuevo");
                    ActualizarJuegos();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // empleados list
        private void AgregarEmpleado()
        {
            Empleados_List Empleados_List = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleados_List>(jsontxt3);
            var empleadosnew = new Empleado(Nombre, Apellido, Id, Email, NumeroTelefono, SalarioMensual);
            try

            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var empleadosSearch = Empleados_List != null ? Empleados_List.Search(id) : null;
                if (empleadosSearch == null)
                {
                    empleadosnew.Id = id;
                    WriteLine("Ingrese el Nombre:");
                    empleadosnew.Nombre = ReadLine();
                    WriteLine("Ingrese el Apellido:");
                    empleadosnew.Apellido = ReadLine();
                    WriteLine("Ingrese el Id:");
                    empleadosnew.Id = ReadLine();
                    WriteLine("Ingrese el Numero Telefonico de la tienda:");
                    empleadosnew.NumeroTelefono = ReadLine();
                    WriteLine("Ingrese el Email de la tienda:");
                    empleadosnew.Email = ReadLine();
                    WriteLine("Ingrese el salario Mensual");
                    empleadosnew.SalarioMensual = decimal.Parse(ReadLine());
                    empleadoslist.Add(empleadosnew);
                    jsontxt3 = JsonConvert.SerializeObject(empleadoslist, Formatting.Indented);
                    File.WriteAllText(FILENAME3, jsontxt3);
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
            Empleados_List empleadosList = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleados_List>(jsontxt3);
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var empleadosSearch = empleadosList.Search(id);
                if (empleadosSearch != null)
                {

                    empleadoslist.Delet(id);
                    jsontxt3 = JsonConvert.SerializeObject(empleadosList, Formatting.Indented);
                    File.WriteAllText(FILENAME3, jsontxt3);
                    WriteLine("El Empleado ha sido Borrado Exitosamente");

                }
                else
                {
                    WriteLine("Id de Empleado incorrecto,Intente de nuevo ");
                    EliminarEmpleado();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void BuscarEmpleado()
        {
            Empleados_List empleadosList = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleados_List>(jsontxt3);
            try
            {
                bool Found = false;
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var empleadosSearch = empleadosList.Search(id);//!= null ? .Search(id) : null;
                if (empleadosSearch == null)
                {

                    WriteLine("Empleado Existentes");
                    foreach (var empleados in empleadosList.empleadosList)
                    {
                        if (empleados.Id == id)
                        {
                            WriteLine($"Nombre del Empleado:\n {Nombre} {Apellido}");
                            WriteLine($"Id del Empleado:\n {Id}");
                            WriteLine($"Numero Telefonico de la empresa:\n {NumeroTelefono}");
                            WriteLine($"Email de la empresa:\n {Email}");
                            WriteLine($"El Salario Mensual del empleado {Nombre} es: {SalarioMensual} ");
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

        }
        public void ListarEmpleado()
        {

            try
            {
                Empleados_List empleadosList = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleados_List>(jsontxt3);
                if (empleadosList != null)
                {
                    WriteLine("Lista de Empleados");
                    foreach (var empleado in empleadosList.empleadosList)
                    {
                        WriteLine($"Nombre del Empleado es:\n {empleado.Nombre} {empleado.Apellido}");
                        WriteLine($"Id del Empleado es:\n {empleado.Id}");
                        WriteLine($"Numero Telefonico de la Empresa:\n {empleado.NumeroTelefono}");
                        WriteLine($"Email de la Empresa:\n {empleado.Email}");
                        WriteLine($"El Salario Mensual es:\n {empleado.SalarioMensual}");
                        WriteLine("");
                    }
                    WriteLine("Se han Listados los Empleados en existencia Exitosamente");

                }
                else
                {
                    WriteLine("Id de Empleado incorrecto,Intente de nuevo ");
                    ListarEmpleado();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ActualizarEmpleados()
        {
            Empleados_List empleadosList = Newtonsoft.Json.JsonConvert.DeserializeObject<Empleados_List>(jsontxt3);
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var empleadosSearch = empleadosList.Search(id);
                if (empleadosSearch != null)
                {
                    empleadosSearch.Id = id;
                    WriteLine("Nombre del empleado:");
                    empleadosSearch.Nombre = ReadLine();
                    WriteLine("Apellido del empleado:");
                    empleadosSearch.Apellido = ReadLine();
                    WriteLine("Id del empleado:");
                    empleadosSearch.Id = ReadLine();
                    WriteLine("Numero de la Empresa:");
                    empleadosSearch.NumeroTelefono = ReadLine();
                    WriteLine("Email de la empresa:");
                    empleadosSearch.Email = ReadLine();
                    WriteLine($"El Salario Mensual del empleado es:");
                    empleadosSearch.SalarioMensual = decimal.Parse(ReadLine());
                    empleadosList.Update(empleadosSearch);
                    jsontxt3 = JsonConvert.SerializeObject(empleadosList, Formatting.Indented);
                    File.WriteAllText(FILENAME3, jsontxt3);
                    WriteLine("Actualizado Exitosamente");
                }
                else
                {
                    WriteLine("Id de Empleado Incorrecto, Intente de nuevo");
                    ActualizarEmpleados();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
