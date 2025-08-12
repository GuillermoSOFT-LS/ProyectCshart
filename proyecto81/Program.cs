using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto81
{
    internal class Matriz
    {

        private int[,] matriz;

        private void Inicializar()
        {
            matriz = new int[3, 4];
            int c;

            for(int f = 0; f < 3; f++)
            {
                for (c = 0; c < 4; c++)
                {
                    Console.Write("Ingresa el valor");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }

            Imprimir();
        }

        private void Imprimir()
        {
            for (int f=0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {

                    if(f == 0) Console.Write(matriz[f, c] + " ");
                    Console.WriteLine();
                    if(f == 2) Console.WriteLine(matriz[f, c] + " ");
                    Console.WriteLine();
                    if (c == 0) Console.WriteLine(matriz[f, c] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            //Problema 3:
            //Crear y cargar una matriz de 3 filas por 4 columnas.Imprimir la primer fila. Imprimir la última fila
            //e imprimir la primer columna.

            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
