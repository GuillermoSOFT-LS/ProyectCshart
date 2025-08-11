using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problema propuesto
            //En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada cuenta
            //corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe finalizar al
            //ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:
            //            a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            //Estado de la cuenta 'Acreedor si el saldo es >0.
            //'Deudor' si el saldo es<0.
            //'Nulo' si el saldo es = 0.
            //b) La suma total de los saldos acreedores.


            int numCuenta;
            double saldo;
            double sumaAcreedores = 0;

            do
            {
                Console.Write("Ingrese el número de cuenta (negativo para finalizar): ");
                numCuenta = Convert.ToInt32(Console.ReadLine());

                if(numCuenta < 0) break; 

                Console.Write("Ingrese el saldo de la cuenta: ");
                saldo = Convert.ToDouble(Console.ReadLine());             


                if(saldo > 0)
                {
                    Console.WriteLine($"--Numero de Cuenta {numCuenta}");
                    Console.WriteLine("--Estado de cuenta: Acreedor");
                    sumaAcreedores += saldo;
                }
                else
                {
                    if(saldo < 0)
                    {
                        Console.WriteLine($"--Numero de Cuenta {numCuenta}");
                        Console.WriteLine("--Estado de cuenta: Deudor");
                    }
                    else
                    {
                        Console.WriteLine($"--Cuenta {numCuenta}");
                        Console.WriteLine("--Estado de cuenta: Nulo");
                    }
                }
            }
            while (numCuenta >= 0);

            Console.WriteLine($"La suma total de los saldos acreedores es: {sumaAcreedores}");
            Console.ReadKey();
        }
    }
}
