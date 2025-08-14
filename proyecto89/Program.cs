using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto89
{
    internal class Matriz_Irregular
    {
        private int[][] matriz;
        private int filas;

        private void Inicializar()
        {
            Console.WriteLine("Cantidad de filas:");
            filas = int.Parse(Console.ReadLine());
            matriz = new int[filas][];

            for (int i=0; i<filas; i++)
            {
                Console.WriteLine($"Ingresa cantidad de columnas de la fila #{i}");
                int columnas = int.Parse(Console.ReadLine());
                matriz[i] = new int[columnas];

                for (int c=0; c < columnas; c++)
                {
                    Console.Write($"Ingresa el dato de [{i},{c}]: ");
                    matriz[i][c] = int.Parse(Console.ReadLine());
                }
            }
            Imprimir();
        }

        private void Imprimir()
        {
            for (int f = 0; f < filas; f++)
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
            //Problema 1:
            //Confeccionaremos un programa que permita crear una matriz irregular y luego imprimir la matriz
            //en forma completa.


            Matriz_Irregular matriz_Irregular = new Matriz_Irregular();
            matriz_Irregular.Inicializar();
            Console.ReadKey();

        }
    }
}
