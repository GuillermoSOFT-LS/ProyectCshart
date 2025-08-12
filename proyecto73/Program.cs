using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto73
{
    internal class Program
    {

        private int[] vect;
        private int menor;

        public void Inicializar()
        {
            Console.WriteLine("Que cantidad de valores piensas ingresar");
            int Cant = int.Parse(Console.ReadLine());

            vect = new int[Cant];

            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine($"Ingresa el dato #{i+1}");
                vect[i] = int.Parse(Console.ReadLine());
            }

            CalcularMenor();
            Repit();

        }

        public void CalcularMenor()
        {
             menor = vect[0];

            for(int i = 1; i <= vect.Length-1; i++)
            {
                if (vect[i] < menor)
                 {
                    menor = vect[i];
                 }
            }

            Console.WriteLine($"El valor menor dentro del vector es: {menor}");
        }

        public void Repit()
        {
            int repet = 0;
            
            for (int i = 1; i <= vect.Length-1; i++)
            {
                if (menor == vect[i])
                {
                    repet++;
                }
            }

            Console.WriteLine($"El numero menor se repite {repet} veces");
        }



        static void Main(string[] args)
        {
            //Problema propuesto
            //Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro delvector.

            Program program = new Program();
            program.Inicializar();  
            Console.ReadKey();
        }
    }
}
