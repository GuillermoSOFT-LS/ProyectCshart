using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto83
{
    internal class Matriz
    {
        private int[,] matriz;
        private int filas;
        private int columnas;

        private void Inicializar()
        {
            Console.WriteLine("Cantidad de filas para la matriz: ");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de columnas para la matriz: ");
            columnas = int.Parse(Console.ReadLine());

            matriz = new int[filas, columnas];

            for(int f = 0; f < matriz.GetLength(0); f++)
            {
                for(int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese dato de la matriz:");
                    matriz[f,c] = int.Parse(Console.ReadLine());
                }
            }

            Imprimir();
            ImprimirUltimaFila();

        }

        private void Imprimir()
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(matriz[f,c] +" ");
                    
                }
            }
        }

        private void ImprimirUltimaFila()
        {
            for (int c = 0; c < matriz.GetLength(0); c++)
            {
                Console.Write(matriz[matriz.GetLength(0)-1 ,c] + " ");

            }
        }



        static void Main(string[] args)
        {
            //Problema 1:
            //Crear una matriz de n* m filas(cargar n y m por teclado) Imprimir la matriz completa y la última
            //fila.

            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
