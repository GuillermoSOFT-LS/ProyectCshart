using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto82
{
    internal class Matriz
    {
        private int[,] matriz;

        private void Inicializar()
        {
            matriz = new int[2,5];

            for(int c = 0; c < 5; c++)
            {
                for(int f = 0; f < 2; f++)
                {
                    Console.WriteLine("Ingresa los datos: ");
                    matriz[f,c] =  int.Parse(Console.ReadLine());
                }
            }
            Imprimir();
        }

        private void Imprimir()
        {

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine(matriz[f,c] +" ");
                }
                Console.WriteLine();
            }
        }

   

        static void Main(string[] args)
        {
            //Problema propuesto
            //Crear una matriz de 2 filas y 5 columnas.Realizar la carga de componentes por columna
            //(es decir primero ingresar toda la primer columna, luego la segunda columna y así
            //sucesivamente)
            //Imprimir luego la matriz.

            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
