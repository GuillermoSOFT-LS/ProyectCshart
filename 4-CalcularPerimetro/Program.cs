using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPerimetro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa la carga de un lado de un cuadrado para calcular su perimetro:");
            string linea = Console.ReadLine();
            int ladoC = int.Parse(linea);

            int Perimetro = ladoC * 4;

            Console.WriteLine("El perimetro del cuadrado es: " + Perimetro);

        }
    }
}
