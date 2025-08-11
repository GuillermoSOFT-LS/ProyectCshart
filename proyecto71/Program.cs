using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto71
{
    internal class Program
    {
        private string[] nombres;
        private int[] edades;

        public void Inicializar()
        {

            nombres = new string[5];
            edades = new int[5];

            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre: ");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingresa la edad: ");
                edades[i] = int.Parse(Console.ReadLine());  
            }
            Imprimir();
        }

        public void Imprimir()
        {
           for(int i = 0;i < nombres.Length; i++)
            {
                if (edades[i] >= 18)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
        }


        static void Main(string[] args)
        {
            //Problema 1:
            //Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas.Luego
            //de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de
            //edad(mayores o iguales a 18 años)

            Program p = new Program();
            p.Inicializar();
            Console.ReadKey();
        }
    }
}
