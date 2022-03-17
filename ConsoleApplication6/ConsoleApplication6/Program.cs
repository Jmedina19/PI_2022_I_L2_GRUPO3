using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    internal class Program
    {
        Libro miLibro = new Libro("Biblioteca del programador", 54.95, 39.95);
        DVD miDVD = new DVD("Curso multimedia de Java", 29.95, 19.95);

        Console.WriteLine("Los datos de mis productos.");
            Console.WriteLine(miLibro.imprimirDatos());
            Console.WriteLine(miDVD.imprimirDatos());


            Console.WriteLine("presione <enter> para terminar.");
            Console.ReadLine();
        
    }
}
