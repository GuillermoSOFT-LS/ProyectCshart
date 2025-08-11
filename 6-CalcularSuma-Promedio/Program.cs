using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSuma_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2,num3,num4,suma,promedio;
            string entrada;

            Console.Write("ingresa primer numero: ");
            entrada = Console.ReadLine();
            num1 = float.Parse(entrada);

            Console.Write("ingresa segundo numero: ");
            entrada = Console.ReadLine();
            num2 = float.Parse(entrada);

            Console.Write("ingresa tercero numero: ");
            entrada = Console.ReadLine();
            num3 = float.Parse(entrada);

            Console.Write("ingresa cuarto numero: ");
            entrada = Console.ReadLine();
            num4 = float.Parse(entrada);

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;

            Console.Write("La suma es: " + suma + " y su promedio es: " + promedio);
            Console.ReadKey();

        }
    }
}
