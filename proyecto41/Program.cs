using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto41
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Problema propuesto
            //    Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50)



            Console.WriteLine("*********Tabla del 5 **************");
            Console.WriteLine("");

            for (int i = 0; i<=10; i++)
            {
                int mul = 5 * i;
                Console.WriteLine("5x"+i+"= "+mul);
            }

            Console.ReadKey();

        }
    }
}
