using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Realizar un programa que permita cargar dos listas de 15 valores cada una.Informar con
            //un mensaje cual de las dos listas tiene un valor acumulado mayor(mensajes "Lista 1
            //mayor", "Lista 2 mayor", "Listas iguales")
            //Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo


            int contador1 = 1;
            int contador2 = 1;
            int TotalLista1 = 0;
            int TotalLista2 = 0;

            Console.WriteLine("---------- Lista 1 ----------");

            while (contador1 <= 15)
            { 
                Console.WriteLine("Valor " + contador1);
                int valor = int.Parse(Console.ReadLine());

                TotalLista1 = TotalLista1 + valor;
                contador1++;
            }

            Console.WriteLine("---------- Lista 2 ----------");

            while (contador2 <= 15)
            {
                Console.WriteLine("Valor " + contador2);
                int valor = int.Parse(Console.ReadLine());

                TotalLista2 = TotalLista2 + valor;
                contador2++;
            }

            if(TotalLista1 > TotalLista2)
            {
                Console.WriteLine("La lista 1 es mayor");
            }else if (TotalLista2 > TotalLista1)
            {
                Console.WriteLine("La lista 2 es mayor");
            }
            else
            {
                Console.WriteLine("Ambas listas son iguales");
            }

            Console.ReadKey();
        }
    }
}
