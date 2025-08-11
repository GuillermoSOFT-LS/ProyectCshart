using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 4:
            //Una planta que fabrica perfiles de hierro posee un lote de n piezas.
            //Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego
            //ingrese la longitud de cada perfil; sabiendo que la pieza cuya longitud esté comprendida en el rango
            //de 1,20 y 1,30 son aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote.


            Console.WriteLine("Ingrese la cantidad de piezas a procesar");
            int piezas = int.Parse(Console.ReadLine());

            int x = 1;
            int cantidad = 0;

            while (x <= piezas)
            {
                Console.WriteLine("Ingrese la longitud del perfil de la pieza " + x + ":");
                double longi = double.Parse(Console.ReadLine());

                if (longi >= 1.20 && longi <= 1.30)
                {
                    cantidad++;
                }
                x++;
            }

            Console.WriteLine("Piezas aptas: "+cantidad);

            Console.ReadKey();

        }
    }
}
