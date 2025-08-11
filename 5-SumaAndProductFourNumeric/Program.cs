using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaAndProductFourNumeric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1,num2,num3,num4,suma,product;
            string entrada;

            Console.Write("Ingresa primer numero:");
            entrada= Console.ReadLine();
            num1 = float.Parse(entrada);

            Console.Write("Ingresa primer segundo:");
            entrada = Console.ReadLine();
            num2 = float.Parse(entrada);

            Console.Write("Ingresa primer tercero:");
            entrada = Console.ReadLine();
            num3 = float.Parse(entrada);

            Console.Write("Ingresa primer cuarto:");
            entrada = Console.ReadLine();
            num4 = float.Parse(entrada);

            Console.Clear();

            suma = num1 + num2;
            product = num3 * num4;

            Console.Write("La suma de los 2 primeros es: " + suma);
            Console.Write(" El producto de los 2 ultimos es: " + product);
            Console.ReadKey();


        }
    }
}
