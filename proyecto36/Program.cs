using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto36
{
    internal class Program
    {
        static void Main(string[] args){

            //Problema 3:
            //Escribir un programa que lea 10 notas de alumnos y nos informe cuantos tienen notas mayores o
            //iguales a 7 y cuántos menores.
            //Para resolver este problema se requieren tres contadores:
            //aprobados(Cuenta la cantidad de alumnos aprobados)
            //reprobados(Cuenta la cantidad de reprobados)
            //f(es el contador del for)
            //Dentro de la estructura repetitiva debemos hacer la carga de la variable nota y verificar con una
            //estructura condicional si el contenido de la variable nota es mayor o igual a 7 para incrementar el
            //contador aprobados, en caso de que la condición retorne falso debemos incrementar la variablereprobados.


            int aprobados = 0;
            int reprobados = 0;

            for(int i = 1; i<=10; i++)
            {
                Console.WriteLine("Ingresa la nota del estudiante #"+i);
                int nota = int.Parse(Console.ReadLine());
                if(nota >= 7)
                {
                    aprobados++;
                }
                else { reprobados++;}
            }

            Console.WriteLine("Estudiantes aprobados: " + aprobados);
            Console.WriteLine("Estudiantes reprobados: " + reprobados);
            Console.ReadKey();


        }
    }
}
