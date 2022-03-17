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

    internal class JuegosList
    {
       // const string FILENAME2 = @"C:\Users\Bessy Almendares\Desktop\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\PI_2022_I_L2_GRUPO4\bin\Debug\JuegosList.json";
       // static JuegosList juegosList = new JuegosList();
       // static string jsontxt2 = "";
       // string Nombre, Apellido, Id, Email,
       //         NumeroTelefono,NombreGame, DescripcionGame,
       //         CodigoGame;
       // decimal PriceGame;

        public List<Juegos> Juegoslist { get; set; }

        public JuegosList()
        {
            Juegoslist = new List<Juegos>();
        }

        public void Add(Juegos pJuegos)
        {
            Juegoslist.Add(pJuegos);  
        }
        public Juegos Search(string pCodigoGame)
        {
            if (Juegoslist == null)
            {
                return null;
            }
            foreach (var juegos in Juegoslist)
            {
                if (juegos.CodigoGame == pCodigoGame)
                {
                    return juegos;
                }
            }
            return null;
        }
        public void Delet(string pCodigoGame)
        {
            foreach (var juegos in Juegoslist)
            {
                if (juegos.CodigoGame == pCodigoGame)
                {
                    Juegoslist.Remove(juegos);
                }
            }
            
        }
        /* public void AgregarJuegos()
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
                     AgregarCliente();
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
                     jsontxt2 = JsonConvert.SerializeObject(juegoslist, Formatting.Indented);
                     File.WriteAllText(FILENAME2, jsontxt2);
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
                     foreach (var cliente in juegosList.juegoslist)
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

                 if (juegoslist != null)
                 {

                     WriteLine("Clientes Existentes");
                     foreach (var juego in juegosList.juegoslist)
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
             }
         }*/
    }
}
