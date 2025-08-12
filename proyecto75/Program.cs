using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto75
{
    internal class Program
    {
        private string[] nombres;

        public void Inicializar()
        {
            nombres = new string[5];

            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Ingresa el nombre #{i+1}");
                nombres[i] = Console.ReadLine();
            }

            OrderAlfa();
            Imprimir();
        }


        public void OrderAlfa()
        {
            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (nombres[i].CompareTo(nombres[i + 1]) > 0)
                    {
                        string aux = nombres[i];
                        nombres[i] = nombres[i + 1];
                        nombres[i + 1] = aux;
                    }
                }
            }
        }


        public void Imprimir()
        {
            for(int i = 0;i < nombres.Length; i++)
            {
                Console.WriteLine($"Nombre #{i}: {nombres[i]}");
            }
        }

        static void Main(string[] args)
        {
            //Problema 2:
            //Definir un vector donde almacenar los nombres de 5 paises.Confeccionar el algoritmo de
            //ordenamiento alfabético.
            Program program = new Program();
            program.Inicializar();
            Console.ReadKey();
        }
    }
}
