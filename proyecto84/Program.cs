using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace proyecto84
{
    internal class Matriz
    {

        private int[,] matriz;
        private int [] posicion;
        private int mayor;

        private void Inicializar()
        {
            Console.WriteLine("Ingresa cantidad de filas:");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa cantidad de columnas");
            int col = int.Parse(Console.ReadLine());

            matriz = new int[filas, col];

            for(int f =0 ; f < matriz.GetLength(0); f++)
            {
                for(int c=0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Ingrese un valor:");
                    matriz[f,c] = int.Parse(Console.ReadLine());
                }
            }

            Mayor_Posicion();
            Imprimir();

        }

        private void Mayor_Posicion()
        {
            posicion = new int[2];
            mayor = matriz[0, 0];
            posicion[0] = 0;
            posicion[1] = 0;

            for (int f = 0; f < matriz.GetLength(0); f++)
            {       
                for (int c = 1; c < matriz.GetLength(1); c++)
                {

                    if (matriz[f, c] > mayor)
                    {
                        mayor = matriz[f, c];
                        posicion[0] = f;
                        posicion[1] = c;
                    }
                }
            }
        }

       private void Imprimir()
        {
            Console.WriteLine("El elemento mayor es: "+ mayor);
            Console.WriteLine($"La posicion del elemento es: {posicion[0]},{posicion[1]}, fila 1 culumna 2");
        }

        static void Main(string[] args)
        {
            //Problema 2:
            //Crear una matriz de n* m filas(cargar n y m por teclado) Imprimir el mayor elemento y la fila y
            //columna donde se almacena.


            Matriz matriz = new Matriz();
            matriz.Inicializar();
            Console.ReadKey();
        }
    }
}
