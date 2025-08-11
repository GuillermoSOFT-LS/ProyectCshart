using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto23
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int x = 2;

            while (x <= 100) 
            {
                Console.Write(x);
                Console.Write('-');
                x = x +2;
            }

            Console.ReadKey();
        }
    }
}
