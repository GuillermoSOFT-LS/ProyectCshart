using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa la primera calificacion:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la segundo calificacion:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la tercera calificacion:");
            int num3 = int.Parse(Console.ReadLine());

            int promedio = (num1 + num2 + num3) / 3;

            if (promedio >= 7)
            {
                Console.WriteLine("Estudiante promocionado");
            }
            else
            {
                Console.WriteLine("Estudiante reprobado");
            }

            Console.ReadKey();
        }
    }
}
