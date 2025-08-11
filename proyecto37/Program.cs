using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 4:
            //Escribir un programa que lea 10 números enteros y luego muestre cuántos valores ingresados fueron
            //múltiplos de 3 y cuantos de 5.Debemos tener en cuenta que hay números que son múltiplos de 3 y
            //de 5 a la vez.

            int mult3 = 0;
            int mult5 = 0;
            int mult35 = 0;

            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine("Ingresa el el valor #"+i);
                int valor = int.Parse(Console.ReadLine());

                if(valor % 3 == 0)
                {
                    mult3++;
                }else if(valor % 5 == 0)
                {
                    mult5++;
                }else if(valor % 3 == 0 && valor % 5 == 0)
                {
                    mult35++;
                }
            }
            Console.WriteLine("-------- Resultados ---------");
            Console.WriteLine("Multiplos de 3: " + mult3);
            Console.WriteLine("Multiplos de 5: " + mult5);
            Console.WriteLine("Multiplos de 3y5: " + mult35);
            Console.ReadKey();


        }
    }
}
