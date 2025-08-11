using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto56
{
    internal class Plano
    {
        private int x;
        private int y;

        public void Inicializar()
        {
            Console.WriteLine("Ingrese el valor de x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de y:");
            y = Convert.ToInt32(Console.ReadLine());

            ImprimirCuadrante();
        }

        public void ImprimirCuadrante() 
        {
            if (x > 0 && y > 0) Console.WriteLine("El punto se encuentra en el primer cuadrante");
            else if (x < 0 && y > 0) Console.WriteLine("El punto se encuentra en el segundo cuadrante");
            else if (x < 0 && y < 0) Console.WriteLine("El punto se encuentra en el tercer cuadante");
            else if (x > 0 && y < 0) Console.WriteLine("El punto se encuentra en el cuarto cuadrante");
            else { Console.WriteLine("El punto se encuentra en el origen o en uno de los ejes");}
        }

        static void Main(string[] args)
        {
            //Problema 3:
            //Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los
            //valores de xe y, imprimirjen que cuadrante se encuentra dicho punto(concepto matemático, primer
            //cuadrante si x e y son positivas, si x< 0 e y> 0 segundo cuadrante, etc.)

            Plano plano = new Plano();
            plano.Inicializar();
            Console.ReadKey();
        }
    }
}
