using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //Realizar un programa que lea los lados de n triángulos, e informar:
            //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales), isósceles
            //(dos lados iguales), o escaleno(ningún lado igual)
            //b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.


            Console.WriteLine("Cuantos triangulos pienzas ingresar:");
            int CantTriangulos = int.Parse(Console.ReadLine());

            int equilatero = 0;
            int isosceles = 0;
            int escaleno = 0;

            for(int i = 1; i <= CantTriangulos; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("-----------Triangulo #"+i+" ------------");
                Console.Write("Ingrese el lado A:");
                int lado_A = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el lado B:");
                int lado_B = int.Parse(Console.ReadLine()); 

                Console.Write("Ingrese el lado C:");
                int lado_C = int.Parse(Console.ReadLine());

                if(lado_A == lado_B && lado_A == lado_C)
                {
                    Console.WriteLine("Tipo de triangulo: equilátero");
                    equilatero++;
                }
                else if (lado_A == lado_B || lado_A == lado_C || lado_B == lado_C)
                {
                    Console.WriteLine("Tipo de triangulo: Isósceles");
                    isosceles++;
                }
                else
                {
                    Console.WriteLine("Tipo de triangulo: Escaleno");
                    escaleno++;
                }

            }

            Console.WriteLine("");
            Console.WriteLine("************ Resultados ****************");
            Console.WriteLine("");

            Console.WriteLine("Triangulos equilátero: " + equilatero);
            Console.WriteLine("Triangulos isósceles: " + isosceles);
            Console.WriteLine("Triangulos escaleno: " + escaleno);

            if (equilatero < isosceles && equilatero < escaleno)
            {
                Console.WriteLine("El tipo de triangulo que posee menor cantidad es 'Equilátero'");
            }
            else if (isosceles < equilatero && isosceles < escaleno)
            {
                Console.WriteLine("El tipo de triangulo que posee menor cantidad es 'Isósceles'");
            }
            else
            {
                Console.WriteLine("El tipo de triangulo que posee menor cantidad es 'Escaleno'");
            }

            Console.ReadKey();
        }
    }
}
