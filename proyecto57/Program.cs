using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto57
{
    internal class Cuadrado
    {
        private double lado;

        public void Inicializar()
        {
            Console.Write("Ingrese el valor del lado del cuadrado: ");
            lado = Convert.ToDouble(Console.ReadLine());
            Perimetro();
            Superficie();
        }

        public void Perimetro()
        {
            double perimetro = lado * 4;
            Console.WriteLine($"El perimetro del cuadrado es: {perimetro}");
        }

        public void Superficie()
        {
            double superificie = lado * lado;
            Console.Write($"La superficie del cuadrado es: {superificie}");
        }
        static void Main(string[] args)
        {
            //Problema 4:
            //Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos: cargar el valor de
            //su lado, imprimir su perímetro y su superficie.

            Cuadrado cuadrado = new Cuadrado();
            cuadrado.Inicializar();
            Console.ReadKey();

        }
    }
}
