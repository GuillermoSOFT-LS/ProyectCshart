using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto79
{
    internal class Matriz
    {

        private int[,] matriz;

        public void Inicializar()
        {
            matriz = new int[3, 5];

            for (int f=0; f < 3; f++)
            {
                for(int c =0; c < 5; c++)
                {
                    Console.WriteLine("Ingresa el valor: ");
                    matriz[f,c] = int.Parse(Console.ReadLine());
                }
            }

            Imprimir();
        }

        public void Imprimir()
        {
            Console.WriteLine("******** Matriz *********");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f,c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            //Problema 1:
            //Crear una matriz de 3 filas por 5 columnas con elementos de tipo int, cargar sus componentes y
            //luego imprimirlas.

            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
