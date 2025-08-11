using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto15
{
    internal class Program
    {
        static void Main(string[] args)
        {

                //Problema:
                //Se carga una fecha(día, mes y año) por teclado. Mostrar un mensaje si corresponde al primer
                //trimestre del año(enero, febrero o marzo) Cargar por teclado el valor numérico del día, mes y año.
                //Ejemplo: dia: 10 mes: 1 año: 2020.

            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("year: ");
            int  year = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 2 || mes == 3)
            {
                Console.WriteLine("Corresponde al primer trimestre del year");
                Console.WriteLine("dia: " +dia);
                Console.WriteLine("Mes: " + mes);
                Console.WriteLine("year: " + year);
            }

            Console.ReadKey();

        }
    }
}
