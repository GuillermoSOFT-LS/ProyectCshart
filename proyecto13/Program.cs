using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero de 1 a 3 cifraz: ");
            int num = int.Parse(Console.ReadLine());

            if (num < 10)
            {
                Console.WriteLine("El numero es de 1 dijito");
            }
            else
            {
                if (num > 9 && num < 100)
                {
                    Console.WriteLine("El numero es de 2 dijitos");
                }
                else
                {
                    if(num > 99 && num < 1000)
                    {
                        Console.WriteLine("El numero es de 3 dijitos");
                    }
                    else
                    {
                        Console.WriteLine("El numero excede el numero de dijitos");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
