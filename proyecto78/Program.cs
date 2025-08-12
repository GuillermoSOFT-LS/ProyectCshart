using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto78
{
    internal class Program
    {
        private string[] paises;
        private int[] habitantes;

        public void Inicializar()
        {
            paises = new string[5];
            habitantes = new int[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"--------- Datos del pais #{i+1} ------------");
                Console.Write("Nombre del pais: ");
                paises[i] = Console.ReadLine();

                Console.Write("Cantidad de habitantes: ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }
            
            Imprimir("Pais", ()=> Order("pais"));
            Imprimir("canitdad de habitantes", ()=>Order("habitantes"));
        }

        public void Swarp(int i, string[] paises, int[] habitantes, string auxP, int auxH)
        {
            habitantes[i] = habitantes[i + 1];
            habitantes[i+1] = auxH;

            paises[i] = paises[i + 1];
            paises[i+1] = auxP;
        }

        public void Order(string order)
        {
            for (int k = 0; k < habitantes.Length - 1; k++)
            {
                for (int i = 0; i < habitantes.Length - 1; i++)
                {
                    string auxP = paises[i];
                    int auxH = habitantes[i];

                    if (order == "pais")
                    {
                        if (paises[i].CompareTo(paises[i + 1]) > 0)
                        {
                            Swarp(i,paises,habitantes,auxP,auxH);
                        }
                    }
                    if(order == "habitantes")
                    {
                        if (habitantes[i] < habitantes[i + 1])
                        {
                            Swarp(i, paises, habitantes, auxP, auxH);
                        }
                    }
                }
            }
        }

        public void Imprimir(string titulo, Action funcion)
        {
            funcion();
            Console.WriteLine("");
            Console.WriteLine($"---Resultados imprimidos alfabeticamente por {titulo}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Pais: {paises[i]}");
                Console.WriteLine($"Habitantes: {habitantes[i]}");
                Console.WriteLine("");
            }
        }


        static void Main(string[] args)
        {
            //Problema propuesto
            //Cargar en un vector los nombres de 5 paises y en otro vector paralelo la cantidad de
            //habitantes del mismo. Ordenar alfabéticamente e imprimir los resultados. Por ultimo
            //ordenar con respecto a la cantidad de habitantes(de mayor a menor) e imprimir
            //nuevamente.

            Program program = new Program();
            program.Inicializar();
            Console.ReadKey();
        }
    }
}
