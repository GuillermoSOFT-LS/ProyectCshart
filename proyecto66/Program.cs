using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto66
{
    internal class Suma_Vectores
    {

        private int[] vec1;
        private int[] vec2;
        private int[] vec3;

        public void Inicializar()
        {
            vec1 = new int[4];
            vec2 = new int[4];
            int contador = 0;

            Console.WriteLine("----------- Vector #1 -------------");

            for (int i = 0; i <= 7; i++)
            {
              
                if (i == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("----------- Vector #2 -------------");                  
                }

                Console.WriteLine("Ingrese el valor: ");
                if (i <= 3) vec1[i] = int.Parse(Console.ReadLine());
                if (i > 3) 
                {
                    vec2[contador] = int.Parse(Console.ReadLine());
                    contador++;
                }               
            }

            Suma();
            Imprimir();
        }

        public void Suma()
        {
            vec3 = new int[4];

            for (int i = 0;i <= 3;i++)
            {
                vec3[i] = vec1[i] + vec2[i];
            }
        }

        public void Imprimir() 
        {
            int v1 = 0,v2 = 0,v3 = 0,v4 = 0;

            for (int i = 0; i <= 3 ; i++)
            {
                if(i == 0) v1 = vec3[i];
                if(i == 1) v2 = vec3[i];
                if(i == 2) v3 = vec3[i];
                if(i == 3) v4 = vec3[i];
            }

            Console.WriteLine("************** Resultados ******************");

            Console.WriteLine($"La suma de los 2 vectores es: {v1}, {v2}, {v3}, {v4}");
        }

        static void Main(string[] args)
        {

            //Problema propuesto
            //Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
            //elementos.Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer
            //vector del mismo tamaño. Sumar componente a componente.

            Suma_Vectores vectores = new Suma_Vectores();
            vectores.Inicializar();
            Console.ReadKey();
        }
    }
}
