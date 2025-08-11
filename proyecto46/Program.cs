using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se realiza la carga de 10 valores enteros por teclado. Se desea conocer.
            //a) La cantidad de valores ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares.

            int negativos = 0;
            int positivos = 0;
            int multiplosDe15 = 0;
            int acumuladoPares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Ingresa el " + i + " valor:");
                int valor = int.Parse(Console.ReadLine());

                if (valor < 0)
                {
                    negativos++;
                }
                if (valor > 0)
                {
                    positivos++;
                }
                if (valor % 15 == 0)
                {
                    multiplosDe15++;
                }
                if (valor % 2 == 0)
                {
                    acumuladoPares = acumuladoPares + valor;
                }
            }

            Console.WriteLine("Cantidad de valores negativos: " + negativos);
            Console.WriteLine("Cantidad de valores positivos: " + positivos);
            Console.WriteLine("Cantidad de múltiplos de 15: " + multiplosDe15);
            Console.WriteLine("Acumulado de números pares: " + acumuladoPares);

            Console.ReadKey();
        }
    }
}
