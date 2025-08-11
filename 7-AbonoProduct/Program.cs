using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonoProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Escribe el nombre del producto: ");
            string Producto = Console.ReadLine();

            Console.Write("Precio del producto: ");
            float precioUnit = float.Parse(Console.ReadLine());

            Console.Write("Cantidad del producto: ");
            float cantidad = float.Parse(Console.ReadLine());
             
            float importe= precioUnit * cantidad;
             
            Console.WriteLine("--------Factura------------");
            Console.WriteLine("Producto: " + Producto);
            Console.WriteLine("Precio: " + precioUnit);
            Console.WriteLine("Cantidad: " + cantidad);
            Console.WriteLine("Abono: " + importe);

            Console.ReadKey();

        }
    }
}
