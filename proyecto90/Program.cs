using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto90
{
    internal class Matriz_Irregulares
    {
        private int[][] matriz;

        private void Inicializar()
        {
            matriz = new int[5][];

            for(int f=0; f<matriz.Length; f++)
            {
                matriz[f] = new int[f+1];

                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.WriteLine("Ingresa el valor:");
                    matriz[f][c] = int.Parse(Console.ReadLine());
                }
            }

            Imprimir();
        }

        private void Imprimir()
        {
            Console.WriteLine();
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < matriz[f].Length; c++)
                {
                    Console.Write($"{matriz[f][c]} ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Problema propuesto
            //Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 2
            //columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila(crearla sin la
            //intervención del operador)
            //Realizar la carga por teclado e imprimir posteriormente.

            Matriz_Irregulares matriz = new Matriz_Irregulares();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
