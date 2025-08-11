using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto69
{
    internal class Sueldos_Operarios
    {
        private int[] sueldos;

        public void Inicializar()  
        {
            Console.WriteLine("Ingresa cantidad de sueldos a registrar: ");
            int CantSueldos = int.Parse(Console.ReadLine());

            sueldos = new int[CantSueldos];

            for(int i = 0; i <= sueldos.Length -1; i++)
            {
                Console.Write("Ingresa el Sueldo:");
                sueldos[i] = int.Parse(Console.ReadLine());
            }
            Imprimir();
        }

        public void Imprimir()
        {
            for(int i = 0;i <= sueldos.Length -1;i++)
            {
                Console.WriteLine("Sueldo: " + sueldos[i]);
            }
        }

        static void Main(string[] args)
        {
            //Problema 1:
            //Se desea almacen ar los sueldos de operarios. Cuando se ejecuta el programa se debe pedir la
            //cantidad de sueldos a ingresar. Luego crear un vector con dicho tamaño.

            Sueldos_Operarios sueldos_ = new Sueldos_Operarios();
            sueldos_.Inicializar();
            Console.ReadKey();
        }
    }
}
