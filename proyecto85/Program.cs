using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto85
{
    internal class Matriz
    {

        private int[,] matriz;

        private void Inicializar()
        {
            Console.WriteLine("Ingresa cantidad de filas:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa cantidad de columnas:");
            int col = int.Parse(Console.ReadLine());
            
            matriz = new int[filas,col];

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write($"Ingresa el valor de la matriz [{f},{c}]: ");
                    matriz[f,c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("------- Matriz Original --------");
            ImprimirOriginal();
            Console.WriteLine("------- Matriz Intercambiada --------");
            Intercambiar();
        }

        private void ImprimirOriginal()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }



        private void Intercambiar()
        {
            for (int f = 0; f <matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                 {
                    int aux = matriz[f, c];
                    matriz[f, c] = matriz[f+1, c];
                    matriz[f,c] = aux;

                 }
            }
                
            ImprimirNuevaMatriz();

        }

        private void ImprimirNuevaMatriz()
        {
            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Problema propuesto
            //Crear una matriz de n* m filas(cargar n y m por teclado) Intercambiar la primer fila con la
            //segundo.Imprimir luego la matriz.

            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
