using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto67
{
    internal class Promedio_Cursos
    {
        private int[] Curso_A;
        private int[] Curso_B;
        private int[] promedio;

        public void Inicializar()
        {
            Curso_A = new int[5];
            Curso_B = new int[5];
            int contador = 0;

            Console.WriteLine("------------------- Calificaciones del curso A ----------------------");
            for (int i = 0; i <=9; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("");
                    Console.WriteLine("------------------- Calificaciones del curso B ----------------------");
                }

                 Console.Write("Ingrese la calificacion: ");
                 if (i <= 4) Curso_A[i] = int.Parse(Console.ReadLine());
                else
                {
                    if(i > 4)
                    {
                        Curso_B[contador] = int.Parse(Console.ReadLine());
                        contador++;
                    }
                }
            }

            Promedio();
            Imprimir();
        }

        public void Promedio()
        {
            int sumaA = 0;
            int sumaB = 0;

            promedio = new int[2];

            for(int i = 0; i <= 4;i++)
            {
                sumaA += Curso_A[i];
                sumaB += Curso_B[i];
            }
            
            promedio[0] = sumaA / 5;
            promedio[1] = sumaB / 5;
        }

        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("************** Resultados *************");

            if (promedio[0] > promedio[1]) Console.WriteLine($"El curso A saco mejor promedio con: {promedio[0]}");
            else Console.WriteLine($"El curso B saco mejor promedio con: {promedio[1]}");

        }

        static void Main(string[] args)
        {
            //Problema propuesto
            //Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso
            //B, cada curso cuenta con 5 alumnos
            //Realizar un programa que muestre el curso que obtuvo el mayor promedio general.

            
            Promedio_Cursos promedio = new Promedio_Cursos();
            promedio.Inicializar();
            Console.ReadKey();

        }
    }
}
