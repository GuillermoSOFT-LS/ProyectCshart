using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto77
{
    internal class Program
    {
        private string[] alumnos;
        private int[] calificaciones;
        private int[] indice;

        public void Inicializar()
        {
            alumnos = new string[5];
            calificaciones = new int[5];

            for (int i = 0; i < calificaciones.Length; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"-------- Datos del alumno #{i + 1} ---------");
                Console.Write("Ingrese el nombre:");
                alumnos[i] = Console.ReadLine();

                Console.Write("Ingrese la calificacion: ");
                calificaciones[i] = int.Parse(Console.ReadLine());              
            }

            Order();
            Imprimir();
        }

        public void Order()
        {
            indice = new int[5];
            for(int k = 0;k < calificaciones.Length -1;k++)
            {
                for(int i = 0; i < calificaciones.Length-1;i++)
                {
                    if (calificaciones[i] < calificaciones[i + 1])
                    {
                        int auxC = calificaciones[i];
                        string auxA = alumnos[i];

                        calificaciones[i] = calificaciones[i + 1];
                        calificaciones[i+1] = auxC;
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i+1] = auxA;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine($"******** Resultados **********");

            for (int i = 0;i < calificaciones.Length;i++)
            {
                Console.WriteLine($"Nombre: {alumnos[i]}");
                Console.WriteLine($"Calificacion: {calificaciones[i]}");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("");
            }
        }


        static void Main(string[] args)
        {
            //Problema 1:
            //Confeccionar un programa que permita cargar los nombres de 5 alumnos y sus notas respectivas.
            //Luego ordenar las notas de mayor a menor. Imprimir las notas y los nombres de los alumnos.

            Program program = new Program();
            program.Inicializar();
            Console.ReadKey();
        }
    }
}
