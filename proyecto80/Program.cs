using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto80
{
    internal class Matriz
    {

        private int[,] matriz;

        private void Inicializar()
        {
            matriz = new int[4,4];

            for(int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine("Ingrese el valor: ");
                    matriz[f,c] = int.Parse(Console.ReadLine());
                }
            }
            Imprimir();
        }

        private void Imprimir()
        {
            //for (int f = 0; f < 4; f++)
            //{
            //    for (int c = 0; c < 4; c++)
            //    {
            //        if (f == c)
            //        {
            //            Console.Write(matriz[f, c] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            for(int m = 0; m < 4; m++)
            {
                Console.Write(matriz[m,m] +" ");
            }
        }


        static void Main(string[] args)
        {
            //Problema 2:
            //Crear y cargar una matriz de enteros de 4 filas por 4 columnas.Imprimir la diagonal principal.


            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();

        }
    }
}
