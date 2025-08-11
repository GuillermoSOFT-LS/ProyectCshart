using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //a) La cantidad de valores-ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares.


            int negativos = 0;
            int positivos = 0;
            int multiplo15 = 0;
            int TotalPares = 0;

            for (int i = 1; i <= 5; i++) 
            { 
                Console.Write("Ingresa el "+i+" valor:");
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
                    multiplo15++;
                }
                if(valor%2==0)
                {
                    TotalPares = TotalPares + valor;
                }
            }

            Console.WriteLine("");
            Console.WriteLine("********* Resultados ***********");
            Console.WriteLine("Cantidad de valores negativos: "+negativos);
            Console.WriteLine("Cantidad de valores positivos: " + positivos);
            Console.WriteLine("Cantidad de valores multiplo de 15: " + multiplo15);
            Console.WriteLine("Total acumulado de numeros pares: " + TotalPares);

            Console.ReadKey();
        }
    }
}
