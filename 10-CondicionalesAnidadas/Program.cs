using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionalesAnidadas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingresa la primera nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la tercera nota");
            int nota3 = int.Parse(Console.ReadLine());

            int promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio >= 7) 
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                if (promedio >= 4 && promedio < 7)
                  {
                     Console.WriteLine("Regular");
                }
                else
                {
                     if (promedio < 4)
                        {
                          Console.WriteLine("Reprobado");
                        }
                }


            }
          
            

        }
    }
}
