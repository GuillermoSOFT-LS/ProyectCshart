using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto64
{
    internal class Empleados_Turnos
    {

        private float[] sueldos;

        public void Inicializar()
        {
            sueldos = new float[8];

            Console.WriteLine("----------- Turno Tarde ----------");
            for(int i = 0; i <= 7; i++)
            { 
                if(i == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("----------- Turno Noche ----------");
                }

                Console.Write("Ingresa el sueldo: ");
                sueldos[i] = float.Parse(Console.ReadLine());        
            }

            Gastos();

        }
        public void Gastos()
        {
            float gastosT = 0;
            float gastosN = 0;

            for(int i = 0; i <= 7; i++)
            {
                if(i <= 3) gastosT += sueldos[i];
                if(i >= 4) gastosN += sueldos[i];
            }

            Console.WriteLine("");
            Console.WriteLine("************ Resultados **************");
            Console.WriteLine($"Gasto total en el turno de la tarde: {gastosT}");
            Console.WriteLine($"Gasto total en el turno de la tarde: {gastosN}");
        }

        static void Main(string[] args)
        {
            //Problema 3:
            //Una empresa tiene dos turnos(mañana y tarde) en los que trabajan 8 empleados(4 por la mañana y
            //4 por la tarde)
            //Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por
            //turno
            //Imprimir los gastos en sueldos de cada turno.

            Empleados_Turnos turnos = new Empleados_Turnos();
            turnos.Inicializar();
            Console.ReadKey();
        }
    }
}
