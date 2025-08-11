using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de preguntas totales");
            float cantPreguntas = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de respuestas correctas");
            float cantCorrect = float.Parse(Console.ReadLine());

            float porcentaje = (cantCorrect * 100) / cantPreguntas;

            if(porcentaje >= 90)
            {
                Console.WriteLine("Nivel maximo");
            }
            else
            {
                if(porcentaje >= 75 && porcentaje < 90)
                {
                    Console.WriteLine("Nivel medio");
                }
                else
                {
                    if(porcentaje >= 50 &&  porcentaje < 75)
                    {
                        Console.WriteLine("Nivel regular");
                    }
                    else
                    {
                        if(porcentaje < 50)
                        {
                            Console.WriteLine("Fuera de nivel");
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
