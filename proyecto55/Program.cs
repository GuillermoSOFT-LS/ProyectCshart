using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto55
{
    internal class Triangulo
    {
        private float lado_A;
        private float lado_B;
        private float lado_C;

        public void Inicializar()
        {
            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Ingrese el valor del {i} lado");
                float lado = float.Parse(Console.ReadLine());

                if(i == 1) lado_A = lado;
                if(i == 2) lado_B = lado;
                if(i == 3) lado_C = lado;
            }     
            
            ImprimirMayor();
            EsEquilatero();
        }

        public void ImprimirMayor()
        {
            if (lado_A > lado_B && lado_A > lado_C) Console.WriteLine($"El lado mayor es: {lado_A}");
            else
            {
                if(lado_B > lado_A && lado_B > lado_C) Console.WriteLine($"El lado mayor es: {lado_B}");             
                else Console.WriteLine($"El lado mayor es: {lado_C}");
            }
        }

        public void EsEquilatero()
        {
            if (lado_A == lado_B && lado_B == lado_C) Console.WriteLine("El triangulo es equilatero");      
            else Console.WriteLine("El triangulo no es equilatero");        
        }


        static void Main(string[] args)
        {
            //Problema 2:
            //Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos:
            //inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero
            //o no.

            Triangulo triangulo = new Triangulo();
            triangulo.Inicializar();
            Console.ReadKey();
        }
    }
}
