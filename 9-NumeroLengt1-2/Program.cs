using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroLengt1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero de 1 a 2 dijistros");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 9)
            { 
                    Console.WriteLine("El numero es de 2 dijitos");
            }
            else
            {
                Console.WriteLine("El numero es de 1 dijitos");
            }

            Console.ReadKey();
        }
    }
}
