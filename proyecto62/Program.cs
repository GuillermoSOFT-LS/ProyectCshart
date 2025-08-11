using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace proyecto62
{
    internal class Operarios
    {

        private int[] sueldos;

        public void Inicializar()
        {
         
              sueldos = new int[5];

            for(int i = 0; i <= 4; i++)
            {             
                Console.WriteLine($"Ingresa el {i} sueldo:");
                sueldos[i] = int.Parse(Console.ReadLine());
            }

            Imprimir();
        }

        public void Imprimir()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"Sueldo {i}: {sueldos[i]}");
            }
        }


        static void Main(string[] args)
        {

            //Problema 1:
            //Se desea guardar los sueldos de 5 operarios.
            //Según lo conocido deberíamos definir 5 variables si queremos tener en un cierto momento los 5
            //sueldos almacenados en memoria.
            //Empleando un vector solo se requiere definir un único nombre y accedemos a cada elemento por
            //medio del subíndice.

            Operarios  operarios = new Operarios();
            operarios.Inicializar();
            Console.ReadKey();

       }
    }
}
