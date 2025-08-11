using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha
            //corresponde a Navidad.

            //yo mismo determine como ej: que la navidad es desde diciembre desde el 25 asta el dia 6 de enero

            Console.WriteLine("Ingresa dia");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa mes");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa year");
            int year = int.Parse(Console.ReadLine());


            if(month == 12 && day > 24 ||  month == 13  && day < 7)
            {
                Console.WriteLine("Estas en navidad");
            }
            else
            {
                Console.WriteLine("No estas en navidad");
            }

            Console.ReadKey();
        }
    }
}
