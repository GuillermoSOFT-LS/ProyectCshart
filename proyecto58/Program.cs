using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto58
{
    internal class Empleado
    {
        private string nombre;
        private float sueldo;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el nombre del empleado:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el sueldo del empleado:");
            sueldo = float.Parse(Console.ReadLine());

            Imprimir();
            Impuesto();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Sueldo: {sueldo}");
        }

        public void Impuesto()
        {
            if(sueldo > 3000) Console.WriteLine("Debe pagar impuestos.");
            else Console.WriteLine("No debe pagar impuestos.");
        }

        static void Main(string[] args)
        {

            //Problema Propuesto
            //Confeccionar una dase que represente un empleado.Definir como atributos su nombre y
            //su sueldo. Confeccionar los métodos para la carga, otro para imprimir sus datos y por
            //último uno que imprima un mensaje si debe pagar impuestos(si el sueldo supera a 3000)

            Empleado empleado = new Empleado();
            empleado.Inicializar();
            Console.ReadKey();
        }
    }
}
