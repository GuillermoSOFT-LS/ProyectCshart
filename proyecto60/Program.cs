using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace proyecto60
{
    internal class Tabla
    {

        private int numero;

        public void Inicializar()
        {
             do{
                Console.WriteLine("Ingresa un numero (-1 para finalizar el programa)");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero == -1) break; 
                Multiplicar(numero);
            }
                while (numero != -1);
        }

        public void Multiplicar(int n)
        {           
                for(int i = 0; i <=12; i++)
                {
                   int multiplicar = n * i;
                   Console.WriteLine($"{n}x{i}= {multiplicar}");
                }                   
        }
        static void Main(string[] args)
        {
            
            //Problema 1:
            //Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla de
            //multiplicar de dicho valor. Finalizar el programa al ingresar el -1.

            Tabla tabla = new Tabla();
            tabla.Inicializar();
            Console.ReadKey();
        }
    }
}
