using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el
            //segundo y a este resultado se lo multiplica por el tercero


            Console.Write("Ingresa el primer valor:");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el primer valor:");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el primer valor:");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 == num2 && num1 == num3)
            {
                int suma = num1 + num2;
                int producto = suma * num3;
                Console.WriteLine("Todos los numeros son iguales");
                Console.WriteLine("El resultado de la suma es: " + suma);
                Console.WriteLine("El resultado del producto es: " + producto);
            }

            Console.ReadKey();
        }
    }
}
