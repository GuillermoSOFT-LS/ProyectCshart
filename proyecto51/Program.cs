using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace proyecto51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Realizar un programa que acumule(sume) valores ingresados por teclado hasta ingresar
            //el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el valor
            //acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int valor;
            int total = 0;

            do
            {
                Console.WriteLine("Ingrese un valor (9999 para finalizar): ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor != 9999)
                {
                    total = total + valor;
                }
            }
            while (valor != 9999);

            if(total <= 0)
            {
                Console.WriteLine("El resultado es un numero negativo, lo cual no es permitido")
            }
            else
            {
                Console.WriteLine("El valor acumulado es: " + total);
            }
            

            Console.ReadKey();

        }
    }
}
