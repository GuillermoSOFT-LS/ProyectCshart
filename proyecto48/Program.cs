using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto48
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema 1:
            //Escribir un programa que solicite la carga de un número entre 0 y 999, y nos muestre un mensaje de
            //cuántos dígitos tiene el mismo.Finalizar el programa cuando se cargue el valor 0.

           int numero;

            do
            {
                 Console.WriteLine("Ingresa un valor de 1 a 1000");
                 numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0 && numero < 10)
                {
                    Console.WriteLine("El número tiene 1 dígito");
                }
                else 
                { 
                    if(numero >= 10 && numero < 100)
                    {
                      Console.WriteLine("El número tiene 2 dígitos");
                    }
                    else
                    {
                        Console.WriteLine("El número tiene 3 dígitos");
                    }
                } 
            }
            while (numero != 0);

            Console.ReadKey();
        }
    }
}
