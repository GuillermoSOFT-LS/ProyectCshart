using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto68
{
    internal class OrderVector
    {
        private int[] nums;
        private int estado = 0;
        public void Inicializar()
        {
            nums = new int[10];
            

            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Ingresa el valor: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            VerificarOrdenado();
            Imprimir();

        }

        public void VerificarOrdenado()
        {
            for(int i = 0; i <= 9;i++)
            {
                if (nums[i] < nums[i+1]) estado = 1; 
            }          
        }

        public void Imprimir()
        {
            if(estado == 1)Console.WriteLine("Esta ordenado");
            else Console.WriteLine("No esta ordenado");
        }


        static void Main(string[] args)
        {
            //Problema propuesto
            //Cargar un vector de 10 elementos y verificar posteriormente si el mismo esta
            //ordenado de menor a manor

            OrderVector orderVector = new OrderVector();
            orderVector.Inicializar();
            Console.ReadKey();
        }
    }
}
