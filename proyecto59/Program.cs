using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto59
{
    internal class Operaciones
    {
        private int numero1;
        private int numero2;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Suma();
            Resta();
            Multiplicacion();
            Div();
        }

        public void Suma()
        {
            int suma = numero1 + numero2;
            Console.WriteLine($"La suma es: {suma}");
        }
        public void Resta()
        {
            int resta = numero1 - numero2;
            Console.WriteLine($"La resta es: {resta}");
        }

        public void Multiplicacion()
        {
            int mult = numero1 * numero2;
            Console.WriteLine($"La multiplicacion es: {mult}");
        }


        public void Div()
        {
            int div = numero1 / numero2;
            Console.WriteLine($"La division es: {div}");
        }



        static void Main(string[] args)
        {
            //Problema Propuesto
            //Implementar la clase operaciones. Se deben cargar dos valores enteros, calcular su
            //suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.

            Operaciones operaciones = new Operaciones();
            operaciones.Inicializar();
            Console.ReadKey();
        }
    }
}
