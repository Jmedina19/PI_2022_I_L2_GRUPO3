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
            //JuegosList juegosList = Newtonsoft.Json.JsonConvert.DeserializeObject<JuegosList>(jsontxt2);
            Program objectProgram = new Program();
            char seguir = 'N';
            bool menu1 = true, menu2 = true,menu3=true,menu4=true,metodoborrar=true;
            string Nombre, Apellido, Id, Email, NumeroTelefono;
            int cantidadjuegoscompra1 = 0, cantidadjuegoscompra2 = 0, cantidadjuegoscompra3 = 0;


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
                            //WriteLine("Si desea seguir, Teclee S");
                            //seguir = Char.Parse(ReadLine().Trim());
                            //seguir.ToString().ToUpper() == "S"
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

                            //WriteLine($"Juego #1:\n {Juego1}");
                            //WriteLine($"Juego #2:\n {}");
                            //WriteLine($"Juego #3:\n {}\n");
                            menu3 = false;
                        } while (menu3 == true);
                        break;
                    case "4":
                        Clear();
                        WriteLine("Que Juego desea comprar" + "\n1) Call of duty" + "\n2) Brawl Stars" +
                             "\n3) Fall guys");
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
                        WriteLine($"Nombre del cliente:\n {Nombre} ");
                        WriteLine($"Nombre del cliente:\n{Apellido}");
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
            }
        }
        public void AgregarJuegos()
        {
            var juegosnew = new Juegos(Nombre, Apellido, Id, Email, NumeroTelefono, NombreGame, DescripcionGame,
                CodigoGame, PriceGame);
            try
            {
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var juegoSearch = juegosList != null ? juegosList.Search(id) : null;
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
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var juegoSearch = juegosList.Search(id);
                if (juegoSearch != null)
                {

                    juegosList.Delet(id);
                    jsontxt2 = JsonConvert.SerializeObject(juegosList, Formatting.Indented);
                    File.WriteAllText(FILENAME2, jsontxt2);
                    WriteLine("El Cliente ha sido Borrado Exitosamente");

                }
                else
                {
                    WriteLine("Id de Cliente incorrecto,Intente de nuevo ");
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
                bool Found = false;
                WriteLine("Ingrese el Id: ");
                var id = ReadLine();
                var juegoSearch = juegosList.Search(id);//!= null ? .Search(id) : null;
                if (juegoSearch == null)
                {

                    WriteLine("Clientes Existentes");
                    foreach (var cliente in juegosList.Juegoslist)
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
        public void ListarJuegos()
        {

            try
            {

                if (juegosList != null)
                {

                    WriteLine("Juegos Existentes");
                    foreach (var juego in juegosList.Juegoslist)
                    {
                        WriteLine($"Nombre del cliente:\n {Nombre} {Apellido}");
                        WriteLine($"Id del cliente:\n {Id}");
                        WriteLine($"Numero Telefonico del cliente:\n {NumeroTelefono}");
                        WriteLine($"Email del client:\n {Email}");
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
        //var Juego1 = new Juegos("Steve", "Fudoka", "1357-9024-68014", "activision@gmail.com", "2235-4956", "Call of Duty", "Este Juego es uno de los mejores juegos multijugador " +
        //  "en primera persona shooter", "48372604", 145.14M);

    } 
}
/*string nombrecliente, apellidocliente, idcliente, emailcliente,
                 numerotelefonocliente, decicion;
             int cantidadjuegoscompra1 = 0, cantidadjuegoscompra2 = 0, cantidadjuegoscompra3 = 0;
             bool menu, menu1 = true, choice = true;
             List<Clientes> listcliente = new List<Clientes>();
             List<Empleado> empleados = new List<Empleado>();
             List<Juegos> listjuegos = new List<Juegos>();


             
             var Juego2 = new Juegos("Isse","Hakuya","0309-1987-59738","supercell@gmail.com","2209-1922","Brawl Stars", "Este juego es para jugar en familia y relajarse despues" +
                   " de un arduo dia", "13579246", 35.99M);
             var Juego3 = new Juegos("Midoriya","Izuku","0125-1968-05593","splashgames@gamil.com","2220-4106", "Fall Guys", "Este Juego en linea esta echo para juntar a las familias " +
                   "y pasar un buen rato con muchas carcajadas de por medio", "02468964", 45.99M);
             var empleado1 = new Empleado("Jean", "Jacques", "0901-1999-08794",
                   "epicgames@ujcv.edu.hn", "9452-7994");


             WriteLine("Bienvenidos Epic Game Store\n");

             WriteLine(empleado1.ToString());


             do
             {

                 WriteLine("Elija una opcion y precione enter\n" + "\n.1) Ver inventario de juegos " +
                 "\n.2) Comprar juego" + "\n.3)  Menu Administrativo" + "\n4) Salir");
                 decicion = ReadLine();

                 switch (decicion)
                 {

                     case "1":
                         Clear();
                         menu = true;
                         do
                         {
                             WriteLine("Tenemos en existencia los sigientes juegos");

                             WriteLine($"Juego #1:\n {Juego1}");
                             WriteLine($"Juego #2:\n {Juego2}");
                             WriteLine($"Juego #3:\n {Juego3}\n");
                             menu = false;
                         } while (menu);
                         break;

                     case "2":
                         Clear();
                         WriteLine("Que Juego desea comprar" + "\n1) Call of duty" + "\n2) Brawl Stars" +
                             "\n3) Fall guys");
                         decicion = ReadLine();
                         switch (decicion)
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
                                     WriteLine("Ingrese los datos del Cliente:\n");

                                     WriteLine("Ingrese el Nombre");
                                     nombrecliente = ReadLine();
                                     WriteLine("Ingrese el Apellido");
                                     apellidocliente = ReadLine();
                                     WriteLine("Ingrese el numero de Identificacion");
                                     idcliente = ReadLine();
                                     WriteLine("Ingrese el Numero de Telefono");
                                     numerotelefonocliente = ReadLine();
                                     WriteLine("Ingrese el Email");
                                     emailcliente = ReadLine();
                                     Clear();
                                     var Cliente1 = new Clientes(nombrecliente, apellidocliente, idcliente, emailcliente, numerotelefonocliente);
                                     WriteLine(empleado1.ToString());
                                     WriteLine(Cliente1.ToString());
                                     WriteLine(Factura1.ToString());
                                     WriteLine($"El Subtotal es: {Factura1.CalcularSubtotal():c}");
                                     //WriteLine($"El Descuento por su compra es: {Factura1.CalcularDescuento():c}");
                                     //WriteLine($"El ISV de su compre es {Factura1.CalcularISV():c}");
                                     // WriteLine($"El Total a pagar por su compra es: {Factura1.CalcularTotal():c}");
                                     // WriteLine("Muchas gracias por su compra");


                                 } while (choice == false);
                                 break;

                             case "2":
                                 Clear();

                                do
                                {
                                   WriteLine("Ingrese la cantidad de este juego que desea comprar ");
                                   cantidadjuegoscompra2 = int.Parse(ReadLine());
                                } while (cantidadjuegoscompra2 == 0);
                                 var Factura2 = new Factura("Isse", "Hakuya", "0309-1987-59738", "supercell@gmail.com", "2209-1922", "Este juego es para jugar en familia y relajarse despues" +
                           " de un arduo dia", 35.99M, "Brawl Stars", "13579246", 0.15M, 0.05M, cantidadjuegoscompra2);
                                 do
                                 {
                                     WriteLine("Ingrese los datos del Cliente:\n");

                                     WriteLine("Ingrese el Nombre");
                                     nombrecliente = ReadLine();
                                     WriteLine("Ingrese el Apellido");
                                     apellidocliente = ReadLine();
                                     WriteLine("Ingrese el numero de Identificacion");
                                     idcliente = ReadLine();
                                     WriteLine("Ingrese el Numero de Telefono");
                                     numerotelefonocliente = ReadLine();
                                     WriteLine("Ingrese el Email");
                                     emailcliente = ReadLine();
                                     Clear();
                                     var Cliente1 = new Clientes(nombrecliente, apellidocliente, idcliente, emailcliente, numerotelefonocliente);
                                     WriteLine(empleado1.ToString());
                                     WriteLine(Cliente1.ToString());
                                     WriteLine(Factura2.ToString());
                                     WriteLine($"El Subtotal es: {Factura2.CalcularSubtotal():c}");
                                     WriteLine($"El Descuento por su compra es: {Factura2.CalcularDescuento():c}");
                                     WriteLine($"El ISV de su compre es {Factura2.CalcularISV():c}");
                                     WriteLine($"El Total a pagar por su compra es: {Factura2.CalcularTotal():c}");
                                     WriteLine("Mucchas gracias por su compra");
                                 } while (choice == false);
                                 break;
                             case "3":
                                 Clear();


                                 WriteLine("Ingrese la cantidad de este juego que desea comprar ");
                                 cantidadjuegoscompra3 = int.Parse(ReadLine());
                                 do
                                 {
                                     WriteLine("Ingrese la cantidad de este juego que desea comprar ");
                                     cantidadjuegoscompra3 = int.Parse(ReadLine());

                                 } while (cantidadjuegoscompra3 == 0);
                                 var Factura3 = new Factura("Midoriya", "Izuku", "0125-1968-05593", "splashgames@gamil.com", "2220-4106", "Este Juego en linea esta echo para juntar a las familias " +
                          "y pasar un buen rato con muchas carcajadas de por medio", 45.99M, "Fall Guys", "02468964", 0.015M, 0.06M, cantidadjuegoscompra3);
                                 do
                                 {
                                     WriteLine("Ingrese los datos del Cliente:\n");

                                     WriteLine("Ingrese el Nombre");
                                     nombrecliente = ReadLine();
                                     WriteLine("Ingrese el Apellido");
                                     apellidocliente = ReadLine();
                                     WriteLine("Ingrese el numero de Identificacion");
                                     idcliente = ReadLine();
                                     WriteLine("Ingrese el Numero de Telefono");
                                     numerotelefonocliente = ReadLine();
                                     WriteLine("Ingrese el Email");
                                     emailcliente = ReadLine();
                                     Clear();
                                     var Cliente1 = new Clientes(nombrecliente, apellidocliente, idcliente, emailcliente, numerotelefonocliente);
                                     WriteLine(empleado1.ToString());
                                     WriteLine(Cliente1.ToString());
                                     WriteLine(Factura3.ToString());
                                     WriteLine($"El Subtotal es: {Factura3.CalcularSubtotal():c}");
                                     WriteLine($"El Descuento por su compra es: {Factura3.CalcularDescuento():c}");
                                     WriteLine($"El ISV de su compre es {Factura3.CalcularISV():c}");
                                     WriteLine($"El Total a pagar por su compra es: {Factura3.CalcularTotal():c}");
                                     WriteLine("Mucchas gracias por su compra");
                                 } while (choice == false);
                                 break;
                         }
                         break;

                     case "3":
                         Clear();
                         WriteLine("Elija una opcion y precione enter\n" + "\n.1) Listar todos los datos" + "\n.2) Buscar datos" +
                                   "\n.3) Agregar nuevos datos" + "\n4) Salir");
                         decicion = ReadLine();
                         switch (decicion)
                         {
                             case "1":
                                 Clear();
                                 WriteLine("Lista de empleados");

                                 WriteLine(empleado1.ToString());
                                 WriteLine("Lista de Juegos");
                                 WriteLine(Juego1.ToString());
                                 WriteLine(Juego2.ToString());
                                 WriteLine(Juego3.ToString());

                                 break;
                             case "2":
                                 Clear();

                                 break;
                         }
                         break;




                     case "4":
                         menu1 = false;
                         break;
                 }

             } while (menu1 == true);
             ReadLine();*/
