using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en
            //pantalla la leyenda "Todos los números son menores a diez".

            Console.WriteLine("Ingresa el primer valor");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo valor");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer valor");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.WriteLine("Todos los numeros son menores a diez");
            }

            Console.ReadKey();

        }
    }
}
