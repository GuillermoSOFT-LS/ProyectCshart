using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace proyecto88
{
    internal class Matrices_vectores
    {
        private string[] pais;
        private int[,] temperaturas;
        private int[] temperaturaMedia;

        private void Inicializar()
        {
            pais = new string[4];
            temperaturas = new int[4, 3];

            for(int p =0; p < 4; p++)
            {
                Console.WriteLine();
                Console.WriteLine($"------------- Datos del pais #{p+1} --------------");

                    Console.Write("Pais: ");
                    pais[p] = Console.ReadLine();

                for(int t=0; t < 3; t++)
                {
                    Console.Write($"Temperatura #{t+1}: ");
                    temperaturas[p,t] = int.Parse( Console.ReadLine() );
                }
            }

            Console.WriteLine();
            Console.WriteLine("***************** Resultados ***************");
            Console.WriteLine();

            PrintPaisesTemperaturas();
            MayorTemperaturaMedia();

        }

        private void PrintPaisesTemperaturas()
        {
            Console.WriteLine();
            Console.WriteLine("------- Nombres de los paises y las temperaturas medias mensuales de las mismas -------");

            for (int f = 0; f < 4; f++)
            {
                Console.Write($"{pais[f]} - ");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"{temperaturas[f, c]}°, ");
                }
                Console.WriteLine();
            }

            CalcularTemperaturaMedia();

            Console.WriteLine();
            Console.WriteLine("-------- Nombres de los paises y las temperaturas medias trimestrales --------");

            for (int i = 0; i < 4; i++)
            {           
                Console.WriteLine($"{pais[i]} - {temperaturaMedia[i]}°");
            }
        }

        private void CalcularTemperaturaMedia()
        {
            temperaturaMedia = new int[4];

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    temperaturaMedia[f] += temperaturas[f, c];
                }
            }

            for (int i=0; i < 4; i++)
            {
                temperaturaMedia[i] = temperaturaMedia[i] / 4;
            }
        }


        private void MayorTemperaturaMedia()
        {
            int mayor = 0;
            int posicion = 0;
            for(int i=0; i<4; i++)
            {
                if (mayor < temperaturaMedia[i])
                {
                    mayor = temperaturaMedia[i];
                    posicion = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------- Nombre del país con la temperatura media trimestral mayor --------");

            Console.WriteLine($"El país con la temperatura media trimestral mayor es {pais[posicion]} - {mayor}°");
        }



        static void Main(string[] args)
        {
            //Problema propuesto
            //Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato las
            //temperaturas medias mensuales de dichos paises.
            //Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.
            //Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.
            //a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
            //b - Imprimir los nombres de los paises y las temperaturas medias mensuales de las mismas.
            //c - Calcular la temperatura media trimestral de cada país.
            //d - Imprimir los nombres de los paises y las temperaturas medias trimestrales.
            //e - Imprimir el nombre del país con la temperatura media trimestral mayor. 

            Matrices_vectores matrices_Vectores = new Matrices_vectores();
            matrices_Vectores.Inicializar();
            Console.ReadKey();
        }
    }
}
