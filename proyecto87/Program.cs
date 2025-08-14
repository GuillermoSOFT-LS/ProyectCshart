using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto87
{
    internal class Matriz_Vectores
    {

        private string[] nombres;
        private int[,] sueldos;
        private int[] totalSueldos;

        private void Inicializar()
        {
            nombres = new string[4];
            sueldos = new int[4, 3];

            for(int f = 0; f < 4; f++)
            {
                Console.WriteLine();
                Console.WriteLine($"--------------- Empleado #{f+1} ----------------");
                Console.Write("Nombre del empleado:");
                nombres[f] = Console.ReadLine();

                    for(int c = 0; c < 3; c++)
                    {
                        Console.Write($"Sueldo del mes #{c+1}:");
                        sueldos[f,c] = int.Parse(Console.ReadLine());
                    }
             }

            Console.WriteLine();
            Console.WriteLine("***************** Resultados *******************");
            Console.WriteLine();
            TotalSueldoEmpleado();
            Console.WriteLine();
            PagoTotalSueldos();
            Console.WriteLine();
            EmpleadoMayorSueldo();               
        }

        private void TotalSueldoEmpleado()
        {
            totalSueldos = new int[4];

            for (int f = 0; f < 4; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    totalSueldos[f] += sueldos[f,c];
                }
            }

            for(int i=0; i < 4; i++)
            {
                Console.WriteLine($"El empleado {nombres[i]} tiene un sueldo total de: {totalSueldos[i]}");
            }
        }

        private void PagoTotalSueldos()
        {
            int pagoTotal = 0;

            for (int i = 0; i < 4; i++)
            {
               pagoTotal+= totalSueldos[i];
            }

            Console.WriteLine($"La empresa a pagado un total de ${pagoTotal} en sueldo de los empleados");
        }

        private void EmpleadoMayorSueldo()
        {
            int mayor = 0;
            int posicion = 0;

            for (int i=0; i<4; i++)
            {
                if (mayor < totalSueldos[i])
                {
                    mayor = totalSueldos[i];
                    posicion = i;
                }              
            }

            Console.WriteLine($"El empleado con mayor sueldo es {nombres[posicion]} con un sueldo de: ${mayor}");
        }


        static void Main(string[] args)
        {
            //Problema 1:
            //Se tiene la siguiente información:
            //Nombres de 4 empleados.
            //- Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.
            //Confeccionar el programa para:
            //a) Realizar la carga de la información mencionada.
            //b) Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para
            //cada empleado.
            //) Mostrar por pantalla el total pagado en sueldos a todos los empleados en los últimos 3 meses
            //d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado

            Matriz_Vectores matriz_Vectores = new Matriz_Vectores();
            matriz_Vectores.Inicializar();
            Console.ReadKey();
        }
    }
}
