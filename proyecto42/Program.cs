using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace proyecto42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla
            //de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.

            Console.WriteLine("Ingresa un valor del 1 al 10:");
            int tabla = int.Parse(Console.ReadLine());

            Console.WriteLine("*************** Tabla del " + tabla+" *************");

            for(int i = 0; i <= 13; i++)
            {
                int mult = tabla * i;

                Console.WriteLine(tabla+"x"+i+"= "+mult);
            }

            Console.ReadKey();

        }
    }
}
