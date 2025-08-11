using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto70
{
    internal class Program
    {

        private int[] vector;
        private int suma = 0;

        public void Inicializar()
        {
            Console.WriteLine("Cantidad de valores a ingresar: ");
            int valor = int.Parse(Console.ReadLine());

            vector = new int[valor];

            for(int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingresa el valor: ");
                vector[i] = int.Parse(Console.ReadLine());

                suma += vector[i];
            }
            Imprimir();
        }

        public void Imprimir()
        {
            Console.WriteLine("El resultado de la suma es: " + suma);
        }

        static void Main(string[] args)
        {
            //Problema propuesto
            //Desarrollar un programa que permita ingresar un vector de n elementos, ingresar n por
            //teclado.Luego imprimir la suma de todos sus elementos en otro método.

            Program p = new Program();
            p.Inicializar();
            Console.ReadKey();
        }
    }
}
