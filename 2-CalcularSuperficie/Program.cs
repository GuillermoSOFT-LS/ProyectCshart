using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSuperficie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float lado;
            string linea;

            Console.Write("Escribe el valor de un lado del cuadrado");
            linea = Console.ReadLine();
            lado = float.Parse(linea);

            float superficie = lado * lado;
            Console.Write("La superficie de el cuadrado es: " + superficie);
            Console.ReadKey();

        }
    }
}
