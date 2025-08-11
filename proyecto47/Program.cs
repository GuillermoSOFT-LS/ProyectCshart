using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto47
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //Se cuenta con la siguiente información:
            //Las edades de 50 estudiantes del turno mañana.
            //Las edades de 60 estudiantes del turno tarde.
            //Las edades de 110 estudiantes del turno noche.
            //Las edades de cada estudiante deben ingresarse por tedado.
            //a) Obtener el promedio de las edades de cada turo(tres promedios)
            //b) Imprimir dichos promedios(promedio de cada turno)
            //c) Mostrar por pantalla un mensaje que indique cual de los tres turnos tiene un promedio
            //de edades mayor.

            int mañana = 0;
            int tarde = 0;
            int noche = 0;

            for (int i = 1; i<=50; i++)
            {
                Console.WriteLine("");
                Console.Write("Ingrese la edad del estudiante del turno mañana " + i + ":");
                int Edad = int.Parse(Console.ReadLine());
                mañana += Edad;
            }

            for (int i = 1; i <= 60; i++)
            {
                Console.WriteLine("");
                Console.Write("Ingrese la edad del estudiante del turno tarde " + i + ":");
                int Edad = int.Parse(Console.ReadLine());
                tarde += Edad;
            }

            for (int i = 1; i <= 110; i++)
            {
                Console.WriteLine("");
                Console.Write("Ingrese la edad del estudiante del turno noche " + i + ":");
                int Edad = int.Parse(Console.ReadLine());
                noche += Edad;
            }

            Console.WriteLine("");
            Console.WriteLine("************* Resultudos ***************");

            Console.WriteLine("Promedio de edades del turno de la mañana: " + mañana/50);
            Console.WriteLine("Promedio de edades del turno de la tarde: " + tarde/60);
            Console.WriteLine("Promedio de edades del turno de la noche: " + noche/110);

            Console.ReadKey();
        }
    }
}
