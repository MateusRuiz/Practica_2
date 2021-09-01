using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_String
{
    class Program
    {
        //Pedir por consola el nombre de una persona 

        static void Main(string[] args)
        {
            string Nombre, Ciudad;
            Console.WriteLine("Escribe tu Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe una Ciudad");
            Ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + Nombre + " Bienvenido a " + Ciudad);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
