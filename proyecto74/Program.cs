using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto74
{
    internal class Program
    {
        private int[] sueldos;

        public void Inicializar()
        {
            sueldos = new int[5];

            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine($"Ingresa el sueldo #{i+1}");
                sueldos[i] = int.Parse(Console.ReadLine());
            }
            OrderVector();
            Imprimir();
        }

        public void OrderVector()
        {
            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < 4; i++)
                {

                    if (sueldos[i] > sueldos[i + 1])
                    {
                        int aux =  sueldos[i];
                        sueldos[i] = sueldos[i + 1];
                        sueldos[i + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for(int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine($"Sueldo #{i}: {sueldos[i]}");
            }
        }


        static void Main(string[] args)
        {

            //Problema 1
            //Se debe crear un vector donde almacenar 5 sueldos. ordenar el vector de menor a mayor
            Program program = new Program();
            program.Inicializar();
            Console.ReadKey();
        }
    }
}
