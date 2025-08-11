using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe cuántos
            //tienen notas mayores[o iguales a 7 y cuántos menores.


            int x = 1;
            int mayores = 0;
            int menores = 0;

            while (x <= 10) 
            {  
                Console.WriteLine("Nota de alumno "+x+":");
                int notas = int.Parse(Console.ReadLine());

                if (notas >= 7) mayores++; 
                else menores++; 

                x++;
            }

            Console.WriteLine("Alumnos con notas mayores o igual a 7: " + mayores);
            Console.WriteLine("Alumnos con notas menores a 7: " + menores);
            Console.ReadKey();
        }
    }
}
