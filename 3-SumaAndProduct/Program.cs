using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAndProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, suma, product;
            string linea;

            Console.WriteLine("Ingresa primer numero entero");
            linea  = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingresa primer numero entero");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            suma = num1 + num2;
            product = num1 * num2;

            Console.WriteLine("La suna de los numeros es: " + suma + " y su producto es: " + product);
            Console.ReadKey();

        }
    }
}
