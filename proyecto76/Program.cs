using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto76
{
    internal class Program
    {

        private int[] valores;
        private int cant;

        public void Inicializar()
        {
            Console.WriteLine("Cantidad de valores a ingresar:");
            cant = int.Parse(Console.ReadLine());

            valores = new int[cant];

            for(int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine($"Ingresa el valor entero #{i+1}");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Order();
            Imprimir();
        }


        public void Order()
        {
            for(int k = 0; k < valores.Length-1; k++)
            {
                for(int i = 0;i < valores.Length-1;i++)
                {
                    if (valores[i] > valores[i + 1])
                    {
                        int aux = valores[i];
                        valores[i] = valores[i + 1];
                        valores[i + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for(int k = 0;k < valores.Length; k++)
            {
                Console.WriteLine(valores[k]);
            }
        }

        static void Main(string[] args)
        {
            //Problema propuesto
            //Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
            Program program = new Program();
            program.Inicializar();
            Console.ReadKey();
        }
    }
}
