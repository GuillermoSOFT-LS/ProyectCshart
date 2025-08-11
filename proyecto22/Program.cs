using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto

            //Escribir un programa en el cual: dada una lista de tres valores numéricos distintos se calcule e
            //informe su rango de variación(debe mostrar el menor y el mayor de ellos)

            Console.Write("Ingrese primer valor:");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese primer valor:");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese primer valor:");
            int valor3 = int.Parse(Console.ReadLine());

            if(valor1 > valor2 && valor1 > valor3)
            {
                if(valor2 < valor3)
                {
                    Console.WriteLine("Mayor: " + valor1);
                    Console.WriteLine("Menor: " + valor2);
                }
                else
                {
                    Console.WriteLine("Mayor: " + valor1);
                    Console.WriteLine("Menor: " + valor3);
                }
               
            }

             else if(valor2 > valor1 && valor2 > valor3)
            {
                if (valor1 < valor3)
                {
                    Console.WriteLine("Mayor: " + valor2);
                    Console.WriteLine("Menor: " + valor1);
                }
                else
                {
                    Console.WriteLine("Mayor: " + valor2);
                    Console.WriteLine("Menor: " + valor3);
                }
            }

            else if (valor3 > valor1 && valor3 > valor2)
            {

                if (valor1 < valor2)
                {
                    Console.WriteLine("Mayor: " + valor3);
                    Console.WriteLine("Menor: " + valor1);
                }
                else
                {
                    Console.WriteLine("Mayor: " + valor3);
                    Console.WriteLine("Menor: " + valor2);
                }
            }
           
            else
            {
                Console.WriteLine("Todos los numeros son iguales");
            }

            Console.ReadKey();



        }
    }
}
