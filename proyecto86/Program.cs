using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto86
{
    internal class Matriz
    {

        private int[,] matriz;

        private void Inicializar()
        {
            Console.WriteLine("Cantidad de filas:");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de columas");
            int columnas = int.Parse(Console.ReadLine());

            matriz =  new int[filas, columnas];

            for (int f=0; f < matriz.GetLength(0);f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine($"Ingrese el valor, de la posicion[{f},{c}]");
                    matriz[f,c] = int.Parse(Console.ReadLine());
                }
            }
            Imprimir();
        }

        private void Imprimir()
        {
            int F0C0 = 0;
            int F0CU = 0;
            int FUC0 = 0;
            int FUCU = 0;

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(0); c++)
                {
                    F0C0 = matriz[0, 0];
                    F0CU = matriz[0, c];
                    FUC0 = matriz[f, 0];
                    FUCU = matriz[f, c];
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------  Matriz Original -------------");

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(0); c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("------------ Cuatro valores ubicados en los vertices -------------");

            Console.WriteLine($"{F0C0} {F0CU}");
            Console.WriteLine($"{FUC0} {FUCU}");
        }

        static void Main(string[] args)
        {
            //Problema propuesto
            //Crear una matriz de n " m filas (cargar n y m por teclado) Imprimir los cuatro valores que
            //se encuentran en los vértices de la misma(mat[0][O] etc.) Crear una matriz de n* m filas
            //(cargar n y m por teclado) Imprimir los cuatro valores que se encuentran en los vertices de la misma
            //(mat[0][0] etc.)

            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
