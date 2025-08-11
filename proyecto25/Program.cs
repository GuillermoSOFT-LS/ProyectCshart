using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema 3:
            //Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre
            //posteriormente la suma de los valores ingresados y su promedio.

            int x = 1;
            int suma = 0;

            while (x <= 10)
            {
                Console.WriteLine("Ingrese tu calificacion "+ x +":");
                int valor = int.Parse(Console.ReadLine());
                suma = suma + valor;
                x++;
            }

            Console.WriteLine("");
            Console.WriteLine("Total:" + suma);
            Console.WriteLine("Promedio:" + suma/10);
            Console.ReadKey();
        }
    }
}
