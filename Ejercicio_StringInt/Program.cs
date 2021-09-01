using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre, Edad;
            Console.WriteLine("Escribe tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu edad");
            Edad = Console.ReadLine();
            Console.WriteLine("Te llamas " + Nombre + " Y tienes " + Edad + " años");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}
