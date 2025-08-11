using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Mayor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa primer numero:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tercer numero: ");
            int num3 = int.Parse(Console.ReadLine());


            if(num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El numero " + num1 + " Es el mayor")
            }
            else
            {
                if (num2 > num1 && num2 > num3) 
                {
                    Console.WriteLine("El numero" + num2 +  "Es el mayor");
                }
                else
                {
                    if (num3 > num1 && num3 > num2)
                    {
                        Console.WriteLine("El numero" + num3 + "Es el mayor");
                    }
                }

                Console.ReadKey();
        }
    }
}
