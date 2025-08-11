using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace proyecto31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Mostrar los múltiplos de 8 hasta el valor 500.Debe aparecer en pantalla 8 - 16 - 24, etc.

            int x = 8;

            while (x <= 500)
            {
                Console.WriteLine(x);
                x = 8 + x;
            }

            Console.ReadKey();
        }
    }
}
