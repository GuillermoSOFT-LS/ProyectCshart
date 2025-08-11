using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto65
{
    internal class Valor_Acumulado
    {
        private int[] valor;
        private int acumulativo = 0;
        private int mayores36 = 0;
        private int mayores50 = 0;

        public void Inicializar()
        {
            valor = new int[8];
          
            for (int i = 0; i <= 7; i++)
            {
                Console.Write("Ingrese el valor:");
                valor[i] = int.Parse(Console.ReadLine());

                acumulativo += valor[i];
                if (valor[i] > 36) mayores36 += valor[i];
                if (valor[i] > 50) mayores50++;
            }

            Imprimir();
        }

        public void Imprimir()
        {
            Console.WriteLine("");
            Console.WriteLine("************ Resultados ***********");
            Console.WriteLine($"Valores acumulados: {acumulativo}");
            Console.WriteLine($"Valores acumulados mayores a 36: {mayores36}");
            Console.WriteLine($"Valores acumulados mayores a 50: {mayores50}");
        }


        static void Main(string[] args)
        {
            //Problema propuesto
            //Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
            //El valor acumulado de todos los elementos del vector.
            //El valor acumulado de los elementos del vector que sean mayores a 36.
            //Cantidad de valores mayores a 50.

            Valor_Acumulado valor = new Valor_Acumulado();
            valor.Inicializar();
            Console.ReadKey();
        }
    }
}
