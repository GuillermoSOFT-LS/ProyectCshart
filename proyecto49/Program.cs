using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto49
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema 2:
            //Escribir un programa que solicite la carga de números por teclado, obtener su promedio.Finalizar la
            //carga de valores cuando se cargue el valor 0.
            //Cuando la finalización depende de algún valor ingresado por el operador conviene el empleo de la
            //Jestructura do while, por lo menos se cargará un valor(en el caso más extremo se carga 0, que indica
            //la finalización de la carga de valores


            int numero;
            int promedio = 0;
            int contador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero (0 para finalizar): ");
                numero = int.Parse(Console.ReadLine());

                promedio += numero;
                contador++;

            }
            while (numero !=0);

            if(promedio != 0)
            {
                Console.WriteLine("El promedio es: " + promedio/(contador -1));
            }
            else
            {
               Console.WriteLine("No se ingresaron números válidos para calcular el promedio.");
            }

            Console.ReadKey();
        }
    }
}
