using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Horas;
            float Pago;
            string linea;
            Console.WriteLine("Calcular de sueldo ");
            Console.WriteLine("Horas trabajdas: ");
            linea = Console.ReadLine();
            Horas = int.Parse(linea);
            Console.WriteLine("Pago por hora: ");
            linea = Console.ReadLine();
            Pago = float.Parse(linea);

            float Sueldo = Pago * Horas;

            Console.WriteLine("El sueldo del empleado es: " + Sueldo);
            Console.ReadKey();

        }
    }
}
