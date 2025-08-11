using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Se ingresan un conjunto de n alturas de personas por teclado.Mostrar la altura promedio
            //de las personas.

            Console.WriteLine("Cuantas alturas de personas ingresaras: ");
            float CantAlturas = float.Parse(Console.ReadLine());

            int x = 1;
            float promedio = 0;

            while (x <= CantAlturas)
            {
                Console.WriteLine("Altura de la persona " + x + ":");
                float altura = float.Parse(Console.ReadLine());

                promedio = promedio + altura;
                x++;
            }

            Console.WriteLine("Promedio de alturas: " + promedio/CantAlturas);
            Console.ReadKey();
        }
    }
}
