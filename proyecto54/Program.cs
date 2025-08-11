using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto54
{
    internal class Persona
    {

        private string nombre;
        private int edad;

        public void Inicializar() 
        {
            Console.WriteLine("Ingrese el nombre de la persona:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la edad de la persona:");
            edad = int.Parse(Console.ReadLine());
            MostrarDatos();
        }

        public void MostrarDatos()
        { 
            if(edad >= 18)
            {
                Console.WriteLine($"Nombre: {nombre}, Edad: {edad} - Es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"Nombre: {nombre}, Edad: {edad} - No es mayor de edad.");
            }
        }


        static void Main(string[] args)
        {

            Persona persona1 = new Persona();
            persona1.Inicializar();

            Console.ReadKey();

            //Problema 1:
            //Confeccionar una clase que permita carga el nombre y la edad de una persona. Mostrar los datos
            //cargados.Imprimir un mensaje si es mayor de edad(edad>= 18)
        }
    }
}
