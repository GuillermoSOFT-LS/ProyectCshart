using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace proyecto38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema 5:
            //Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a
            //1000.
            //Este tipo de problemas también se puede resolver empleando la estructura repetitiva for. Lo primero
            //que se hace es cargar una variable que indique la cantidad de valores a ingresar.Dicha variable se
            //carga antes de entrar a la estructura repetitiva for.
            //La estructura for permite que el valor inicial o final dependa de una variable cargada previamente
            //por teclado.

            Console.WriteLine("Cuantos numeros enteros ingresaras:");
            int cantNNum = int.Parse(Console.ReadLine());


            int mayores = 0;

            for (int i = 1; i<= cantNNum; i++)
            {
                Console.WriteLine("Ingresa el "+i+" valor");
                int valor = int.Parse(Console.ReadLine());  

                if(valor >= 1000)
                {
                    mayores++;
                }
            }

            Console.WriteLine("Cantidad de numeros iguales o mayores a 1000: "+mayores);

            Console.ReadKey();

        }
    }
}
