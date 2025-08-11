using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto

            //De un operario se conoce su sueldo y los años de antigüedad.Se pide confeccionar un programa que
            //lea los datos de entrada e informe:
            //a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento
            //del 20 %, mostrar el sueldo a pagar.
            //b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5
            //%.
            //c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios. 

            Console.WriteLine("Ingrese su sueldo: ");
            int sueldo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese años de antigüedad: ");
            int year = int.Parse(Console.ReadLine());

            if (sueldo < 500 && year >= 10)
            {
                double nuevoSueldo =(sueldo * 0.20) + sueldo;
                Console.WriteLine("Por tus años de servicio resiviras un aumneto del 20%, tu sueldo es: " + nuevoSueldo);
            }else if(sueldo < 500 && year < 10)
            {
                double nuevoSueldo = (sueldo * 0.05) + sueldo;
                Console.WriteLine("Por tus años de servicio resiviras un aumneto del 5%, tu sueldo es: " + nuevoSueldo);
            }else if(sueldo >= 500)
            {
                Console.WriteLine("tu sueldo es: " + sueldo);
            }

            Console.ReadKey();
        }
    }
}
