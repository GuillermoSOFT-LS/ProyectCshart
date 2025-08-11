using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se
            //ingresan valores por teclado)

            int x = 0;
            int contador = 0;

            while (contador <= 24 ) 
            {
                x = x + 11;
                Console.WriteLine(x);

                contador++;
            }

            Console.ReadKey();
        }
    }
}
