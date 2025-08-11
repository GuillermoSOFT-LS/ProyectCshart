using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace proyecto24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 2:
            //Escribir un programa que solicite la carga de un valor positivo y nos muestre desde 1 hasta el valor
            //ingresado de uno en uno.
            //Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30.
            //Es de FUNDAMENTAL importancia analizar los diagramas de flujo y la posterior codificación en
            //C# de los siguientes problemas, en varios problemas se presentan otras situaciones no vistas en el
            //ejercicio anterior.


            Console.WriteLine("Ingrese un numero positivo:");
            int num = int.Parse(Console.ReadLine());

            int x = 1;

            while (x <= num)
            {
                Console.Write(x + " - ");
                x++;
            } 

            Console.ReadKey();
        }
    }
}
