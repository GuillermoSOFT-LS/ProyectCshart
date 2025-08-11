using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Desarrollar un programa que solicite la carga de 10 numeros e imprima la suma de los ultimos 5 valores ingresados

            int suma = 0;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Ingrese el "+i+" valor:");
                int valor = int.Parse(Console.ReadLine());


                if(i > 5)
                {
                    suma = suma + valor;
                }
            }

            Console.WriteLine("La suma de los ultimos 5 valores es: "+suma);

            Console.ReadKey();

        }
    }
}
