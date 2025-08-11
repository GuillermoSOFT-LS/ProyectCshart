using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema1:
            //Solicitar el ingreso del nombre y edad de 2 personas .
            //Mostrar el nombre de la persona con mayor edad


            //    Console.WriteLine("Ingrese su nombre: ");
            //    string nombre1 = Console.ReadLine();

            //    Console.Write("Ingresa tu edad: ");
            //    int edad1 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Ingrese su nombre: ");
            //    string nombre2 = Console.ReadLine();

            //    Console.Write("Ingresa tu edad: ");
            //    int edad2 = Convert.ToInt32(Console.ReadLine());



            //if (edad1 > edad2)
            //{
            //    Console.WriteLine($"La persona con mayor edad es: {nombre1}");
            //}
            //else
            //{
            //    Console.WriteLine($"La persona con mayor edad es: {nombre2}");
            //}


            //------------------------------------------------------------------------------
            //Problema2:
            //Solicitar el ingreso de 2 nombres y mostras mensaje si son iguales o distintos.

            Console.WriteLine("Ingrese su nombre: ");
            string nombre1 = Console.ReadLine();

            Console.WriteLine("Ingrese su nombre: ");
            string nombre2 = Console.ReadLine();

            if(nombre1 == nombre2)
            {
                Console.WriteLine("Los nombres son iguales.");
            }
            else
            {
                Console.WriteLine("Los nombres son distintos.");
            }


            Console.ReadKey();
        }
    }
}
