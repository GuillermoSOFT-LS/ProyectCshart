using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un numero");
            int num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("el numero es positivo");
            }
            else
            {
                if (num < 0)
                {
                    Console.WriteLine("el numero es negativo");
                }
                else
                {
                    if (num == 0)
                    {
                        Console.WriteLine("el numero es nulo");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

