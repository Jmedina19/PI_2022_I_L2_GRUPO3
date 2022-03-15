using PI_2022_I_L2_GRUPO3.Objetos;
using PI_2022_I_L2_GRUPO4.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_2022_I_L2_GRUPO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombrecliente, apellidocliente, idcliente, emailcliente,
                numerotelefonocliente, decicion;//, seleccion = "Y";
            int cantidadjuegoscompra1 = 0, cantidadjuegoscompra2 = 0, cantidadjuegoscompra3 = 0;

            bool menu, menu1 = true, choice = true;


            var Juego1 = new Juegos("Steve","Fudoka","1357-9024-68014","activision@gmail.com","2235-4956","Call of Duty", "Este Juego es uno de los mejores juegos multijugador " +
                  "en primera persona shooter","48372604", 145.14M);
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
                "\n.2) Comprar juego" + "\n.3) Ravisar facturas"+"\n4) Salir");
                decicion = ReadLine();

                switch (decicion)
                {
                    case "1":
                        Clear();
                        menu = true;
                        do
                        {
                            WriteLine("Tenemos en existencia los sigientes juegos");

                            WriteLine($"Juego #1 es:\n {Juego1}");
                            WriteLine($"Juego #2 es:\n {Juego2}");
                            WriteLine($"Juego #3 es:\n {Juego3}\n");
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
                                    WriteLine($"El Descuento por su compra es: {Factura1.CalcularDescuento():c}");
                                    WriteLine($"El ISV de su compre es {Factura1.CalcularISV():c}");
                                    WriteLine($"El Total a pagar por su compra es: {Factura1.CalcularTotal():c}");
                                    WriteLine("Muchas gracias por su compra");
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
                        var juegosventas = new List<ClaseAbstracta>() {Juego1,Juego2,Juego3};
                        WriteLine("Cantidad y nombre de los juegos vendidos");
                        foreach (var juegosvendidos in juegosventas)
                        {
                            WriteLine(juegosvendidos)
                        }
                        break;

                    case "4":
                        menu1 = false;
                        break;
                }
                
            } while (menu1 == true);
            ReadLine();
        }   
    }
} 
