using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10,
            //imprimir en pantalla la leyenda "Alguno de los números es menor a diez".| I


            Console.WriteLine("Escribe el primer valor");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el primer valor");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el primer valor");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < 10 || num2 < 10 || num3 < 10)
            {
                Console.WriteLine("Alguno de los números es menor a diez");
            }
            else
            {
                Console.WriteLine("Todos los numeros son mayor o igual a 10");
            }


            Console.ReadKey();

        }
    }
}
