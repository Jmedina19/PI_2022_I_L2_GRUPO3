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
        static ClientesList clientesList = new ClientesList();
        static JuegosList juegosList = new JuegosList();
        static string jsontxt1 = "";
        static string jsontxt2 = "";
        string Nombre, Apellido, Id, Email,
        NumeroTelefono;
        string Nombreautor, Apellidoautor, Idautor, Emailempresa,
                NumeroTelefonoempresa, NombreGame, DescripcionGame,
                CodigoGame;
        decimal PriceGame;


        static void Main(string[] args)
        {

            var empleado1 = new Empleado("Jean", "Jacques", "0901-1999-08794",
                   "epicgames@ujcv.edu.hn", "9452-7994");
            jsontxt1 = File.ReadAllText(FILENAME);
            jsontxt2 = File.ReadAllText(FILENAME2);
            ClientesList clientesList= Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
            JuegosList JuegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
            Program objectProgram = new Program();
            char seguir = 'N';
            bool menu1 = true, menu2 = true,menu3=true,menu4=true,metodoborrar=true;
            string Nombre, Apellido, Id, Email, NumeroTelefono;
            int cantidadjuegoscompra1 = 0;


            do
            {
                WriteLine("Elija una opcion y precione enter\n" + "\n1) - Menu Administrativo de los clientes" +
                "\n2) - Menu Administrativo de Juegos" + "\n3) - Ver inventario de juegos" + "\n4) - Comprar juego" + "\n5) - Salir");
                var opcion = ReadLine();
                switch (opcion)
                {
                    case "1":
                        Clear();
                        WriteLine("Elija una opcion y precione enter\n" + "\n1) - Agregar" + "\n2) - Buscar" +
                                  "\n3) - Eliminar " + "\n4) - Listar "+"\n5) Regresar");
                        var opcion2 = ReadLine();
                        do
                        {
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
                                    menu1 = false;
                                    break;
                                default:
                                    Main(null);
                                    break;
                            }
                      
                        } while (menu1==true);
                        ReadLine();
                        break;
                    case "2":
                        Clear();
                        Clear();
                        WriteLine("Elija una opcion y precione enter\n" + "\n1) - Agregar" + "\n2) - Buscar" +
                                  "\n3) - Eliminar " + "\n4) - Listar ");
                        var opcion3 = ReadLine();
                        do
                        {
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
                                    menu2 = false;
                            }

                        } while (menu2==true);
                        break;
                    case "3":
                        Clear();
                       
                        do
                        {
                            WriteLine("Tenemos en existencia los sigientes juegos");
                            objectProgram.ListarJuegos();
                            ReadLine();
                            menu3 = false;
                        } while (menu3 == true);
                        break;
                    case "4":
                        Clear();
                        WriteLine($"Que Juego desea comprar ");
                        var opcion4 = ReadLine();
                        switch (opcion4)
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
                                    

                                    
                                    WriteLine(empleado1.ToString());
                                    
                                    WriteLine(Factura1.ToString());
                                    WriteLine($"El Subtotal es: {Factura1.CalcularSubtotal():c}");
                                    WriteLine($"El Descuento por su compra es: {Factura1.CalcularDescuento():c}");
                                    WriteLine($"El ISV de su compre es {Factura1.CalcularISV():c}");
                                    WriteLine($"El Total a pagar por su compra es: {Factura1.CalcularTotal():c}");
                                    WriteLine("Muchas gracias por su compra");
                                    menu4 = false;


                                } while (menu4== true);
                                break;


                            /*case "5":
                                Clear();
                                WriteLine("Si desea continuar, Teclee s");
                                seguir = Char.Parse(ReadLine().Trim());
                                break;*/
                        }break;
                }
            } while (seguir.ToString().ToUpper() == "S");
        }
        private void AgregarCliente()
        {
            ClientesList clientesList = Newtonsoft.Json.JsonConvert.DeserializeObject<ClientesList>(jsontxt1);
            Clientes clientesnew = new Clientes(Nombre, Apellido, Id, Email, NumeroTelefono);
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
                var clienteSearch = clientesList.Search(id);//!= null ? .Search(id) : null;
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
        public void AgregarJuegos()
        {
            var juegosnew = new Juegos(Nombre, Apellido, Id, Email, NumeroTelefono, NombreGame, DescripcionGame,
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
    } 
}

