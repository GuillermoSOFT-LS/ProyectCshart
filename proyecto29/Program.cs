using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar
            //un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados
            //cobran entre $100 y $300 y cuántos cobran más de $300.Además el programa deberá
            //informar el importe que gasta la empresa en sueldos al personal.


            Console.WriteLine("Cantidad de empleados:");
            int CantEmpleados = int.Parse(Console.ReadLine());

            int x = 1, menores = 0, mayores = 0;
            float importe = 0;

            while (x <= CantEmpleados) 
            {
                Console.WriteLine("Ingresa el sueldo del empleado " + x + ":");
                float sueldo = float.Parse(Console.ReadLine());

                importe = importe + sueldo;

                if(sueldo >= 100 && sueldo <= 300)
                {
                    menores++;
                }
                else { mayores++; }

                x++;
            }

            Console.WriteLine("Empledos con sueldos de $100 a $300: " +menores);
            Console.WriteLine("Empledos con sueldos por encima de $300: " + mayores);
            Console.WriteLine("Importe total de la empresa en sueldos de personal: " + importe);

            Console.ReadKey();
        }
    }
}
