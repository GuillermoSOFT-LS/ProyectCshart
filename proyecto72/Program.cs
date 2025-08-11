using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto72
{
    internal class Program
    {
        private string[] nombres;
        private int[] sueldos;

        public void Inicializar()
        {
            nombres = new string[5];
            sueldos = new int[5];

            for(int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("Ingresa el nombre:");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingrese el sueldo: ");
                sueldos[i] = int.Parse(Console.ReadLine());
            }
            Imprimir();
        }

        public void Imprimir()
        {
            int mayor = sueldos[0];
            int pos = 0;
            for(int i = 1; i < nombres.Length; i++)
            {
                if (sueldos[i] > mayor)
                {
                    mayor = sueldos[i];
                    pos = i;
                }
            }

            Console.WriteLine("El empledo con el mayor sueldo es: "+ nombres[pos]);
            Console.Write("Sueldo: " + mayor);

        }

        


        static void Main(string[] args)
        {
            //Problema 1:
            //Confeccionar un programa que permita cargar los nombres de 5 operarios y sus sueldos respectivos.
            //Mostrar el sueldo mayor y el nombre del operario.

            Program program = new Program();
            program.Inicializar();
            Console.ReadKey();
        }
    }
}
