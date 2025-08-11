using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Escribir un programa que pida ingresar coordenadas(x, y) que representan puntos en el
            //plano.I
            //Informar cuántos puntos se han ingresado en el primer, segundo, tercer y cuarto
            //cuadrante.Al comenzar el programa se pide que se ingrese la cantidad de puntos a
            //procesar.

            //Si x > 0 y y > 0 → Cuadrante I
            //Si x< 0 y y > 0 → Cuadrante II
            //Si x< 0 y y< 0 → Cuadrante III
            //Si x > 0 y y< 0 → Cuadrante IV

            int Cuadrante_I = 0;
            int Cuadrante_II = 0;
            int Cuadrante_III = 0;
            int Cuadrante_IV = 0;

            Console.WriteLine("Cuantos puntos a procesar vas a ingresar:");
            int CantPuntos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= CantPuntos; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("--------Coordenadas numero: "+i+" ----------");
                Console.Write("Coordenada x:");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Coordenada y:");
                int y = int.Parse(Console.ReadLine());

                if(x > 0 && y > 0)
                {
                    Cuadrante_I++;
                }else if (x < 0 && y > 0)
                {
                    Cuadrante_II++;
                }else if (x < 0 && y< 0)
                {
                    Cuadrante_III++;
                }else if (x > 0 && y< 0)
                {
                    Cuadrante_IV++;
                }
                else
                {

                }
            }

            Console.WriteLine("");
            Console.WriteLine("********** Resultados ***********");

            Console.WriteLine("Puntos al Cuadrante I: "+ Cuadrante_I);
            Console.WriteLine("Puntos al Cuadrante II: " + Cuadrante_II);
            Console.WriteLine("Puntos al Cuadrante III: " + Cuadrante_III);
            Console.WriteLine("Puntos al Cuadrante IV: " + Cuadrante_IV);

            Console.ReadKey();

        }
    }
}
