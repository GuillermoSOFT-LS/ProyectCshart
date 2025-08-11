using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 2:
            //Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre
            //posteriormente la suma de los valores ingresados y su promedio. Este problema ya lo desarrollamos,
            //lo resolveremos empleando la estructura for.

            int suma = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingresa el valor "+i);   
                
                int valor = int.Parse(Console.ReadLine());

                suma = suma + valor;
            }

            int promedio = suma / 10;

            Console.Write("----------- Resultado ------------");
            Console.WriteLine("La suma de las 10 calificaciones es: " + promedio);
            Console.WriteLine("El promedio de las 10 calificaciones es: " +promedio);
            Console.ReadKey();
        }
    }
}
