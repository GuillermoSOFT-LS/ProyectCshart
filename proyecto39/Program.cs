using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la
            //medida de la base y la altura de un triángulo. El programa deberá informar:
            //a) De cada triángulo la medida de su base, su altura y su superficie.
            //b) La cantidad de triángulos cuya superficie es mayor a 12.


            Console.WriteLine("Cuantos pares de datos ingresaras:");
            int cantPar = int.Parse(Console.ReadLine());

            int Cant = 0;

            for (int i = 1; i<= cantPar; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("---------------- Triangulo #"+i+" ----------------");
                Console.Write("Ingresa la base:");
                int valor1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa la altura:");
                int valor2 = int.Parse(Console.ReadLine());


                int superficie = (valor1 * valor2) / 2;

                Console.WriteLine("--Base del triangulo #"+i+": "+valor1);
                Console.WriteLine("--Altura del triangulo #" + i + ": " + valor2);
                Console.WriteLine("--Superficie del triangulo #" + i + ": " + superficie);

                if (superficie > 12)
                {
                    Cant++;
                }

            }

            Console.WriteLine("");
            Console.WriteLine("************* Resultado *************");

            Console.WriteLine("Triangulos con superficie mayor a 12: " + Cant);

            Console.ReadKey();


        }
    }
}
