using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 3:
            //Realizar un programa que permita ingresar el peso(en kilogramos) de piezas. El proceso termina
            //cuando ingresamos el valor 0.Se debe informar:
            //a) Cuántas piezas tienen un peso entre 9.8 Kg.y 10.2 Kg.?, cuántas con más de 10.2 Kg.? y cuántas
            //con menos de 9.8 Kg.? I
            //b) La cantidad total de piezas procesadas.

            float peso;
            int peso1 = 0;
            int peso2 = 0;
            int peso3 = 0;
            int total = 0;

            do
            {
                Console.WriteLine("Ingrese el peso de la pieza en kilogramos (0 para terminar): ");
                peso = float.Parse(Console.ReadLine());

                if(peso >= 9.8 && peso <= 10.2)
                {
                    peso1++;
                }
                else
                {
                    if(peso > 10.2)
                    {
                        peso2++;
                    }
                    else
                    {
                        if(peso < 9.8 && peso >0)
                        {
                            peso3++;
                        }
                    }
                }

                total++;

            }
            while (peso != 0);

                Console.WriteLine("Cuántas piezas tienen un peso entre 9.8 Kg.y 10.2 Kg: " + peso1);
                Console.WriteLine("Cuántas con más de 10.2 Kg: " + peso2);
                Console.WriteLine("Cuántas con menos de 9.8 Kg: " + peso3);
                Console.WriteLine("Total de piezas procesadas " + (total-1));

            Console.ReadKey();
        }
    }
}
