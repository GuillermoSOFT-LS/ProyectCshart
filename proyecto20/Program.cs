using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Escribir un programa que płda ingresar la coordenada de un punto en el plano, es decir dos valores
            //enteros x e y(distintos a cero).
            //Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1° Cuadrante si x > 0 Y
            //y > 0, 2° Cuadrante: x < 0Yy > 0, etc.)


            Console.WriteLine("-------Calculador de coordenadas----");
            Console.WriteLine("");
            Console.Write("Ingresa eje x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ingresa eje y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Coordenada: 1° Cuadrante");
            }else if (x < 0 && y > 0)
            {
                Console.WriteLine("Coordenada: 2° Cuadrante");
            }else if (x < 0 && y < 0)
            {
                Console.WriteLine("Coordenada: 3° Cuadrante");
            }else if (x > 0 && y < 0)
            {
                Console.WriteLine("Coordenada: 4° Cuadrante");
            }
            else
            {
                Console.WriteLine("Coordenada: en un eje");
            }

            Console.ReadKey();


        }
    }
}
