using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Problema propuesto
            //    Desarrollar un programa que permita cargar n números enteros y luego nos informe
            //    cuántos valores fueron pares y cuántos impares.
            //    Emplear el operador "% en la condición de la estructura condicional:
            //    if (valor % 2 == 0) //Si el if da verdadero luego es par.



            Console.WriteLine("Que cantidad de numeros ingresaras:");
            int CantNum = int.Parse(Console.ReadLine());


             int x = 1;
             int par = 0;
            int impar = 0;

            while(x <= CantNum)
            {
                Console.WriteLine("Ingresa el "+x+ " numero:");
               int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0) par++;
                else impar++;

                x++;
            }

            Console.WriteLine("------- Resultado -------");

            Console.WriteLine("Pares " + par);
            Console.WriteLine("Impares " + impar);

            Console.ReadKey();
        }
    }
}
